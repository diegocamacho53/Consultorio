using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio.Formularios
{
    public partial class FrmCitas : Form
    {
        #region Variables

        private string connectionString;

        private bool Operacion = false;

        private int idCitaSeleccionada = 0;

        private bool estadoSeleccionado = false;

        private bool isNewRole = true;

        private bool habilitarCambio = true;

        #endregion

        #region Metodos

        private void LlenarComboBoxPacientes()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT IdPaciente, Nombre + ' ' + Apellido AS NombreCompleto FROM dbo.fn_GetPacientes()";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable pacientesTable = new DataTable();
                    adapter.Fill(pacientesTable);

                    if (pacientesTable.Rows.Count > 0)
                    {
                        DataRow row = pacientesTable.NewRow();
                        row["IdPaciente"] = DBNull.Value;
                        row["NombreCompleto"] = "-Seleccione un paciente-";
                        pacientesTable.Rows.InsertAt(row, 0);

                        comboBoxPacientes.DataSource = pacientesTable;
                        comboBoxPacientes.DisplayMember = "NombreCompleto";
                        comboBoxPacientes.ValueMember = "IdPaciente";
                    }
                    else
                    {
                        MessageBox.Show("No se pudieron obtener los datos de los pacientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al llenar el ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> ObtenerHorasDisponiblesParaCita(DateTime fechaCita)
        {
            List<string> horasDisponibles = new List<string>();

            try
            {
                // Formatear la fecha como yyyy/MM/dd
                string fechaFormateada = fechaCita.ToString("yyyy/MM/dd");

                // Conexión a la base de datos y ejecución de la función de tabla
                using (SqlConnection connection = new SqlConnection(Conexion.ConnectionString))
                {
                    connection.Open();

                    // Consulta SQL para ejecutar la función de tabla
                    string query = "SELECT HorasCitas FROM dbo.ObtenerHorasDisponiblesParaCita(@FechaCita)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FechaCita", fechaFormateada);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string horaCita = reader["HorasCitas"].ToString();
                        horasDisponibles.Add(horaCita);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener las horas disponibles para la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return horasDisponibles;
        }

        private void LlenarComboBoxHoraCitas(DateTime fechaCita)
        {
            try
            {
                // Obtener la lista de horas disponibles para la fecha de cita especificada
                List<string> horasDisponibles = ObtenerHorasDisponiblesParaCita(fechaCita);

                // Limpiar ComboBox antes de agregar nuevos elementos
                comboBoxHorasCitas.Items.Clear();

                // Agregar las horas disponibles al ComboBox
                foreach (string hora in horasDisponibles)
                {
                    comboBoxHorasCitas.Items.Add(hora);
                }

                // Seleccionar el primer elemento si hay elementos en el ComboBox
                if (comboBoxHorasCitas.Items.Count > 0)
                {
                    comboBoxHorasCitas.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No hay horas disponibles para la fecha seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al llenar el ComboBox de horas de citas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RegistrarCita()
        {
            try
            {
                DateTime fechaCita = dateTimePickerFechaCita.Value.Date;
                string fechaFormateada = fechaCita.ToString("yyyy/MM/dd");

                Cursor = Cursors.WaitCursor;

                // Obtener el valor del pago y el total como enteros
                int pago = Convert.ToInt32(textBoxPago.Text);
                int total = Convert.ToInt32(textBoxValorTotal.Text);

                // Verificar si el pago es mayor que el total
                if (pago > total)
                {
                    MessageBox.Show("El monto del pago no puede ser mayor que el valor total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Si la validación pasa, continuar con la inserción de la cita
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GECitasSUDI";
                    command.Parameters.AddWithValue("@Oprcion", "I");
                    command.Parameters.AddWithValue("@Opcion", "1");
                    command.Parameters.AddWithValue("@IdPaciente", (int)comboBoxPacientes.SelectedValue);
                    command.Parameters.AddWithValue("@FechaCita", fechaFormateada);
                    command.Parameters.AddWithValue("@HoraCita", comboBoxHorasCitas.Text);
                    command.Parameters.AddWithValue("@Estado", checkBoxEstado.Checked ? 1 : 0);
                    command.Parameters.AddWithValue("@Pago", pago);
                    command.Parameters.AddWithValue("@Total", total);
                    command.Parameters.AddWithValue("@Notas", richTextBoxNotas.Text);

                    Conexion.EjecutarComando(command);

                    // Obtener la fecha seleccionada por el usuario
                    DateTime fechaSeleccionada = dateTimePickerFechaCita.Value;

                    // Llamar al método para llenar el ComboBox de horas disponibles
                    LlenarComboBoxHoraCitas(fechaSeleccionada);
                    // Si no hay excepción, mostrar mensaje de confirmación
                    MessageBox.Show($"La información ha sido guardada correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Operacion = true;
                }
            }
            catch (SqlException sqlEx)
            {
                // Capturar errores específicos de SQL Server
                MessageBox.Show($"Error al insertar la cita en la tabla GECitas. {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                // Capturar otros errores generales
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        public void CargarCitas()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                // Crear un DataSet para almacenar los datos
                DataSet dataSet = new DataSet();

                // Crear una conexión y un comando para ejecutar el procedimiento almacenado
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("GECitasSUDI", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Oprcion", "S");
                    command.Parameters.AddWithValue("@Opcion", "3");

                    // Abrir la conexión
                    connection.Open();

                    // Ejecutar el comando y llenar el DataSet con los resultados
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataSet);
                    }
                }

                // Limpiar las columnas existentes en el DataGridView
                dataGridViewAgenda.Columns.Clear();

                dataGridViewAgenda.DataSource = dataSet.Tables[0];

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al insertar la cita en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Aquí puedes agregar más código para manejar el error según sea necesario
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar la tabla Citas. {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void CargarPacientes()
        {
            string query = "SELECT IdPaciente, Nombre FROM GEPacientes";

            using (SqlConnection connection = new SqlConnection(Conexion.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        comboBoxPacientes.DisplayMember = "Nombre";
                        comboBoxPacientes.ValueMember = "IdPaciente";
                        comboBoxPacientes.DataSource = dataTable;
                    }
                }
            }
        }

        private void EditarCita()
        {
            try
            {
                DateTime fechaCita = dateTimePickerFechaCita.Value.Date;
                string fechaFormateada = fechaCita.ToString("yyyy/MM/dd");

                Cursor = Cursors.WaitCursor;



                // Si la validación pasa, continuar con la inserción de la cita
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GECitasSUDI";
                    command.Parameters.AddWithValue("@Oprcion", "U");
                    command.Parameters.AddWithValue("@Opcion", "1");
                    command.Parameters.AddWithValue("@IdCita", idCitaSeleccionada);
                    command.Parameters.AddWithValue("@IdCita", comboBoxHorasCitas.Text);
                    command.Parameters.AddWithValue("@HoraCita", comboBoxHorasCitas.Text);
                    command.Parameters.AddWithValue("@Notas", richTextBoxNotas.Text);
                    command.Parameters.AddWithValue("@Estado", checkBoxEstado.Checked ? 1 : 0);
                    command.Parameters.AddWithValue("@FechaCita", fechaFormateada);




                    Conexion.EjecutarComando(command);

                    MessageBox.Show($"La información ha sido guardada correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Operacion = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar la cita en la tabla GECitas. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }

        private void bloquearCampos()
        {
            comboBoxPacientes.Enabled = false;
            dateTimePickerFechaCita.Enabled = false;
            comboBoxHorasCitas.Enabled = false;
            textBoxValorTotal.ReadOnly = true;
            textBoxPago.ReadOnly = true;
            richTextBoxNotas.ReadOnly = true;
            checkBoxEstado.Enabled = false;
        }

        private void habilitarCampo()
        {
            comboBoxPacientes.Enabled = true;
            dateTimePickerFechaCita.Enabled = true;
            comboBoxHorasCitas.Enabled = true;
            textBoxValorTotal.ReadOnly = false;
            textBoxPago.ReadOnly = false;
            richTextBoxNotas.ReadOnly = false;
            checkBoxEstado.Enabled = true;
        }

        public void limpiarCampos()
        {
            // Limpiar los TextBox y otros controles
            textBoxValorTotal.Clear();
            textBoxPago.Clear();
            richTextBoxNotas.Clear();
            checkBoxEstado.Checked = false;

            comboBoxPacientes.DataSource = null;  // Primero desvincula cualquier fuente de datos existente
            comboBoxPacientes.Items.Clear();      // Limpia los items actuales
            comboBoxPacientes.Items.Add("-Seleccione un paciente-");  // Agrega el elemento predeterminado
            comboBoxPacientes.SelectedIndex = 0;
        }

        public void limpiarCamposConTabla()
        {
            // Limpiar los TextBox y otros controles
            textBoxValorTotal.Clear();
            textBoxPago.Clear();
            richTextBoxNotas.Clear();
            checkBoxEstado.Checked = false;

            // Limpiar el DataGridView
            dataGridViewAgenda.DataSource = null; // Desvincula cualquier fuente de datos
            dataGridViewAgenda.Rows.Clear();      // Limpia las filas

            // Limpiar y configurar el ComboBox de pacientes
            comboBoxPacientes.DataSource = null;  // Desvincula cualquier fuente de datos
            comboBoxPacientes.Items.Clear();      // Limpia los items actuales
            comboBoxPacientes.Items.Add("-Seleccione un paciente-");  // Agrega el elemento predeterminado
            comboBoxPacientes.SelectedIndex = 0;  // Selecciona el elemento predeterminado
        }

        private void habilitarCamposEditar()
        {

            dateTimePickerFechaCita.Enabled = true;
            comboBoxHorasCitas.Enabled = true;
            checkBoxEstado.Enabled = true;
            textBoxValorTotal.ReadOnly = true;
            textBoxPago.ReadOnly = true;
            comboBoxPacientes.Enabled = false;
        }

        #endregion

        #region Controlador

        public FrmCitas(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            CargarPacientes();


        }

        #endregion

        #region Eventos

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            LlenarComboBoxPacientes();
            dateTimePickerFechaCita.MinDate = DateTime.Today; // Establece la fecha mínima como la fecha actual
            //dateTimePickerFechaCita.MaxDate = DateTime.Today.AddDays(7); // Opcional: Establece la fecha máxima permitida (por ejemplo, 7 días después de hoy)
            dateTimePickerFechaCita.Value = DateTime.Today;
            bloquearCampos();
            // Obtener la fecha seleccionada por el usuario
            DateTime fechaSeleccionada = dateTimePickerFechaCita.Value;

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (isNewRole)
                {


                    RegistrarCita();
                    CargarCitas();
                    bloquearCampos();
                    limpiarCampos();
                }
                else
                {
                    EditarCita();
                    CargarCitas();
                    bloquearCampos();
                    limpiarCampos();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            CargarCitas();
        }

        private void buttonAbonar_Click(object sender, EventArgs e)
        {
            // Verificar si se seleccionó una cita válida
            if (idCitaSeleccionada != 0)
            {
                // Crear instancia del formulario FrmAbonarPago
                FrmAbonarPago frmAbonarPago = new FrmAbonarPago();

                // Pasar idCitaSeleccionada al formulario FrmAbonarPago
                frmAbonarPago.IdCitaSeleccionada = idCitaSeleccionada;

                // Mostrar el formulario FrmAbonarPago
                frmAbonarPago.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una cita antes de abonar el pago.", "Selección de Cita", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se hizo clic en una fila válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridViewAgenda.Rows[e.RowIndex];

                // Obtener los valores de la fila completa
                int idCita = Convert.ToInt32(filaSeleccionada.Cells["Cita"].Value);
                bool estado = Convert.ToBoolean(filaSeleccionada.Cells["Estado"].Value);
                DateTime fechaCita = Convert.ToDateTime(filaSeleccionada.Cells["FechaCita"].Value);

                // Obtener la hora de la cita como string (varchar)
                string horaCitaString = filaSeleccionada.Cells["Hora de la cita"].Value.ToString();

                decimal valorTotal = Convert.ToDecimal(filaSeleccionada.Cells["Total"].Value);
                string nombrePaciente = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string apellidoPaciente = filaSeleccionada.Cells["Apellido"].Value.ToString();

                // Concatenar nombre y apellido
                string nombreCompletoPaciente = $"{nombrePaciente} {apellidoPaciente}";

                // Asignar los valores a los controles correspondientes
                idCitaSeleccionada = idCita;
                checkBoxEstado.Checked = estado;
                dateTimePickerFechaCita.Value = fechaCita.Date;

                // Asignar la hora de la cita al ComboBox directamente como string
                comboBoxHorasCitas.Text = horaCitaString;

                textBoxValorTotal.Text = valorTotal.ToString();
                comboBoxPacientes.Text = nombreCompletoPaciente;
                idCitaSeleccionada = idCita;

                habilitarCambio = false;
                isNewRole = false;
            }
        }


        private void textBoxPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un dígito o no es una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Marca el evento como manejado para evitar la entrada del carácter
            }
        }

        private void textBoxValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un dígito o no es una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Marca el evento como manejado para evitar la entrada del carácter
            }
        }
        #endregion

        private void buttonHabilitarCampos_Click(object sender, EventArgs e)
        {

            if (habilitarCambio == true)
            {
                habilitarCampo();
            }
            else
            {
                habilitarCamposEditar();

            }

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCamposConTabla();
            bloquearCampos();
        }

        private void dateTimePickerFechaCita_ValueChanged(object sender, EventArgs e)
        {
            // Obtener la fecha seleccionada por el usuario
            DateTime fechaSeleccionada = dateTimePickerFechaCita.Value;

            // Llamar al método para llenar el ComboBox de horas disponibles
            LlenarComboBoxHoraCitas(fechaSeleccionada);
        }
    }
}

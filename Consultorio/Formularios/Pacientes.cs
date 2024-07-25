using System.Data.SqlClient;
using System.Data;
using MongoDB.Driver.Core.Configuration;
using System.Windows.Forms;
using System;

namespace Consultorio
{
    public partial class Form1 : Form
    {

        #region Variables

        /// <summary>
        /// Indica si la operación (registro o edición) en la tabla Pacientes fue exitosa.
        /// </summary>
        private bool Operacion = false;

        /// <summary>
        /// Indica si se está creando un nuevo rol (paciente) o editando uno existente.
        /// </summary>
        private bool isNewRole = true;

        /// <summary>
        /// Almacena el ID del paciente actualmente seleccionado en la interfaz.
        /// </summary>
        private int idPacienteActual;



        #endregion

        #region Metodos

        /// <summary>
        /// Muestra la lista de pacientes obtenida desde la base de datos utilizando el procedimiento almacenado "GEPacientesSUDI".
        /// </summary>
        /// <param name="connectionString">Cadena de conexión a la base de datos.</param>
        private void MostrarPacientes(string connectionString)
        {

            try
            {
                Cursor = Cursors.WaitCursor;
                // Crear un DataSet para almacenar los datos
                DataSet dataSet = new DataSet();

                // Crear una conexión y un comando para ejecutar el procedimiento almacenado
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("GEPacientesSUDI", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Oprcion", "S");
                    command.Parameters.AddWithValue("@Opcion", "2");

                    // Abrir la conexión
                    connection.Open();

                    // Ejecutar el comando y llenar el DataSet con los resultados
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataSet);
                    }
                }

                // Limpiar las columnas existentes en el DataGridView
                dataGridViewTablaPacientes.Columns.Clear();

                dataGridViewTablaPacientes.DataSource = dataSet.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar la tabla Pacientes. {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }

        /// <summary>
        /// Registra un nuevo paciente en la base de datos utilizando el procedimiento almacenado "GEPacientesSUDI".
        /// </summary>
        private void RegistrarPaciente()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GEPacientesSUDI";
                    command.Parameters.AddWithValue("@Oprcion", "I");
                    command.Parameters.AddWithValue("@Opcion", "1");
                    command.Parameters.AddWithValue("@Nombre", textBoxNombre.Text);
                    command.Parameters.AddWithValue("@Apellido", textBoxApellido.Text);
                    command.Parameters.AddWithValue("@Celular", textBoxCelular.Text);
                    command.Parameters.AddWithValue("@NombreAcudiente", textBoxAcudiente.Text);
                    if (int.TryParse(textBoxEdad.Text, out int edad))
                    {
                        command.Parameters.AddWithValue("@Edad", edad);
                    }
                    else
                    {
                        // Manejar el caso en que textBoxCelular.Text no sea un número válido
                        MessageBox.Show("El número de edad no es válido. Debe ser un número entero.");
                        return;
                    }
                    command.Parameters.AddWithValue("@Estado", checkBoxEstado.Checked ? 1 : 0);
                    DateTimePicker dateTimePickerFechaNacimiento = panelRegistroPacientes.Controls.OfType<DateTimePicker>().FirstOrDefault(dtp => dtp.Name == "dateTimePickerFechaNacimiento");

                    if (dateTimePickerFechaNacimiento != null)
                    {
                        command.Parameters.AddWithValue("@FechaNacimiento", dateTimePickerFechaNacimiento.Value);
                    }
                    else
                    {
                        // Manejar el caso en que el DateTimePicker no se encuentre
                        MessageBox.Show("No se encontró el control DateTimePicker para la fecha de nacimiento.");
                        return;
                    }

                    Conexion.EjecutarComando(command);

                    MessageBox.Show($"La informacion a sido guardada correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Operacion = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar el rol en la tabla Pacientes. {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Edita los datos de un paciente existente en la base de datos utilizando el procedimiento almacenado "GEPacientesSUDI".
        /// </summary>
        private void EditarPaciente()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GEPacientesSUDI";
                    command.Parameters.AddWithValue("@Oprcion", "U");
                    command.Parameters.AddWithValue("@Opcion", "1");
                    command.Parameters.AddWithValue("@IdPaciente", idPacienteActual);
                    command.Parameters.AddWithValue("@Nombre", textBoxNombre.Text);
                    command.Parameters.AddWithValue("@Apellido", textBoxApellido.Text);
                    command.Parameters.AddWithValue("@NombreAcudiente", textBoxAcudiente.Text);
                    if (int.TryParse(textBoxEdad.Text, out int edad))
                    {
                        command.Parameters.AddWithValue("@Edad", edad);
                    }
                    else
                    {
                        // Manejar el caso en que textBoxCelular.Text no sea un número válido
                        MessageBox.Show("El número de edad no es válido. Debe ser un número entero.");
                        return;
                    }
                    command.Parameters.AddWithValue("@Celular", textBoxCelular.Text);

                    command.Parameters.AddWithValue("@Estado", checkBoxEstado.Checked ? 1 : 0);
                    DateTimePicker dateTimePickerFechaNacimiento = panelRegistroPacientes.Controls.OfType<DateTimePicker>().FirstOrDefault(dtp => dtp.Name == "dateTimePickerFechaNacimiento");

                    if (dateTimePickerFechaNacimiento != null)
                    {
                        command.Parameters.AddWithValue("@FechaNacimiento", dateTimePickerFechaNacimiento.Value);
                    }
                    else
                    {
                        // Manejar el caso en que el DateTimePicker no se encuentre
                        MessageBox.Show("No se encontró el control DateTimePicker para la fecha de nacimiento.");
                        return;
                    }

                    Conexion.EjecutarComando(command);

                    MessageBox.Show($"La informacion a sido actualizada correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Operacion = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el rol en la tabla Pacientes. {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Bloquea todos los campos del formulario de registro de pacientes.
        /// </summary>
        private void BloquearCampos()
        {
            textBoxNombre.ReadOnly = true;
            textBoxAcudiente.ReadOnly = true;
            textBoxEdad.ReadOnly = true;
            textBoxCelular.ReadOnly = true;
            textBoxApellido.ReadOnly = true;
            checkBoxEstado.Enabled = false;
            dateTimePickerFechaNacimiento.Enabled = false;

        }

        /// <summary>
        /// Habilita todos los campos del formulario de registro de pacientes.
        /// </summary>
        private void HabilitarCampos()
        {
            textBoxNombre.ReadOnly = false;
            textBoxAcudiente.ReadOnly = false;
            textBoxEdad.ReadOnly = false;
            textBoxCelular.ReadOnly = false;
            textBoxApellido.ReadOnly = false;
            checkBoxEstado.Enabled = true;
            dateTimePickerFechaNacimiento.Enabled = true;
        }

        /// <summary>
        /// Limpia todos los campos del formulario de registro de pacientes.
        /// </summary>
        private void Limpiar()
        {
            try
            {
                if (Operacion == true)
                {
                    textBoxNombre.Clear();
                    textBoxAcudiente.Clear();
                    textBoxEdad.Clear();
                    textBoxCelular.Clear();
                    textBoxApellido.Clear();
                    checkBoxEstado.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar limpiar {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Calcula la edad en base a la fecha de nacimiento proporcionada.
        /// </summary>
        /// <param name="fechaNacimiento">La fecha de nacimiento del paciente.</param>
        /// <returns>La edad calculada del paciente.</returns>
        private int CalcularEdad(DateTime fechaNacimiento)
        {
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Today;

            // Calcular la edad
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Ajustar si la fecha de nacimiento aún no ha ocurrido este año
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad)) edad--;

            return edad;
        }


        #endregion

        #region Controlador

        /// <summary>
        /// Constructor de la clase Form1.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            dateTimePickerFechaNacimiento.MaxDate = DateTime.Today; // Establece la fecha mínima como la fecha actual
            //dateTimePickerFechaCita.MaxDate = DateTime.Today.AddDays(7); // Opcional: Establece la fecha máxima permitida (por ejemplo, 7 días después de hoy)
            dateTimePickerFechaNacimiento.Value = DateTime.Today;
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Muestra la lista de pacientes al hacer clic en el botón "Mostrar".
        /// </summary>
        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            MostrarPacientes(Conexion.ConnectionString);
        }

        /// <summary>
        /// Guarda los cambios realizados en un paciente o registra uno nuevo al hacer clic en el botón "Guardar".
        /// </summary>
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isNewRole)
                {


                    this.EditarPaciente();
                    this.MostrarPacientes(Conexion.ConnectionString);
                    this.BloquearCampos();
                    this.Limpiar();
                }
                else
                {
                    this.RegistrarPaciente();
                    this.Limpiar();
                    this.BloquearCampos();
                    this.MostrarPacientes(Conexion.ConnectionString);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Limpia los campos del formulario al hacer clic en el botón "Limpiar".
        /// </summary>
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Permite solo la entrada de dígitos en el campo de edad al presionar teclas en el teclado.
        /// </summary>
        private void textBoxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un dígito o no es una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Marca el evento como manejado para evitar la entrada del carácter
            }
        }

        /// <summary>
        /// Permite solo la entrada de dígitos en el campo de celular al presionar teclas en el teclado.
        /// </summary>
        private void textBoxCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un dígito o no es una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Marca el evento como manejado para evitar la entrada del carácter
            }
        }

        /// <summary>
        /// Maneja el evento de clic en una celda de la tabla de pacientes, mostrando los detalles del paciente seleccionado en los controles del formulario.
        /// </summary>
        private void dataGridViewTablaPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar si se hizo clic en una fila válida
            {
                DataGridViewRow filaSeleccionada = dataGridViewTablaPacientes.Rows[e.RowIndex];

                idPacienteActual = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);

                // Obtener los valores de la fila seleccionada
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string apellido = filaSeleccionada.Cells["Apellido"].Value.ToString();
                string Acudiente = filaSeleccionada.Cells["Acudiente"].Value.ToString();
                string celular = filaSeleccionada.Cells["Celular"].Value.ToString();
                string edad = filaSeleccionada.Cells["Edad"].Value.ToString();
                bool estado = (bool)filaSeleccionada.Cells["Estado"].Value;
                //int IdPaciente = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);
                DateTime fechaNacimiento = (DateTime)filaSeleccionada.Cells["FechaNacimiento"].Value;

                // Asignar los valores a los controles
                textBoxEdad.Text = edad;
                textBoxAcudiente.Text = Acudiente;
                textBoxNombre.Text = nombre;
                textBoxApellido.Text = apellido;
                textBoxCelular.Text = celular;
                checkBoxEstado.Checked = estado;
                dateTimePickerFechaNacimiento.Value = fechaNacimiento;


                isNewRole = false;
            }
        }

        /// <summary>
        /// Habilita los campos del formulario para editar al hacer clic en el botón "Editar".
        /// </summary>
        private void buttonEditar_Click_1(object sender, EventArgs e)
        {
            this.HabilitarCampos();
        }

        /// <summary>
        /// Maneja el evento ValueChanged del dateTimePickerFechaNacimiento.
        /// Calcula la edad en base a la fecha seleccionada y la asigna al textBoxEdad.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void dateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            // Obtener la fecha seleccionada
            DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;

            // Calcular la edad
            int edad = CalcularEdad(fechaNacimiento);

            // Asignar la edad al TextBox
            textBoxEdad.Text = edad.ToString();
        }

#endregion
    }
}

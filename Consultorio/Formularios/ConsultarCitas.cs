using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio.Formularios
{
    public partial class ConsultarCitas : Form
    {
        #region Variables

        #endregion

        #region Controlador
        public ConsultarCitas()
        {
            InitializeComponent();
            
        }

        #endregion

        #region Metodos

        private void CargarCitasDia(string connectionString)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                // Crear un DataSet para almacenar los datos
                //DataSet dataSet = new DataSet();

                // Obtener la fecha seleccionada del dateTimePickerFechaCita
                DateTime fechaCita = dateTimePickerFechaCita.Value.Date;

                // Formatear la fecha como 'YYYY-MM-DD'
                string fechaFormateada = fechaCita.ToString("yyyy/MM/dd");
                //string fechaFormateada = fechaCita.ToString("dd-MM-yyyy");


                // Crear una conexión y un comando para ejecutar el procedimiento almacenado
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("GECitasSUDI", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Oprcion", "S");
                    command.Parameters.AddWithValue("@Opcion", 2);
                    command.Parameters.AddWithValue("@Activo", DBNull.Value);
                    command.Parameters.AddWithValue("@FechaCita", fechaFormateada);
                    command.Parameters.AddWithValue("@Notas", DBNull.Value);
                    command.Parameters.AddWithValue("@Pago", DBNull.Value);
                    command.Parameters.AddWithValue("@IdPaciente", DBNull.Value);
                    command.Parameters.AddWithValue("@Estado", DBNull.Value);
                    command.Parameters.AddWithValue("@Pendiente", DBNull.Value);
                    command.Parameters.AddWithValue("@Total", DBNull.Value);
                    command.Parameters.AddWithValue("@IdCita", DBNull.Value);
                    // Abrir la conexión
                    connection.Open();

                    SqlDataAdapter daTable = new SqlDataAdapter(command);
                    DataSet dsTabla = new DataSet();

                    daTable.Fill(dsTabla, "Resultado");

                    //if (dsTabla.Tables[0].Rows.Count > 0)
                    //{
                    //    dataGridViewTablaAgenda.DataSource = dsTabla.Tables[0];                
                    //}
                    if (dsTabla.Tables["Resultado"].Rows.Count > 0)
                    {
                        dataGridViewTablaAgenda.DataSource = dsTabla.Tables["Resultado"];
                    }
                    else
                    {
                        MessageBox.Show("No hay citas programadas para el día de hoy.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }                     
                
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

        private void BuscarCitaPaciente(string connectionString)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxNombrePaciente.Text))
                {
                    MessageBox.Show("Por favor ingrese el nombre de el paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
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
                        command.Parameters.AddWithValue("@Opcion", "1");
                        command.Parameters.AddWithValue("@Nombre", textBoxNombrePaciente.Text);

                        // Abrir la conexión
                        connection.Open();

                        // Ejecutar el comando y llenar el DataSet con los resultados
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataSet);
                        }
                    }

                    // Limpiar las columnas existentes en el DataGridView
                    dataGridViewTablaAgenda.Columns.Clear();

                    dataGridViewTablaAgenda.DataSource = dataSet.Tables[0];

                }
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
        private void AutoCompletar()
        {
            using (SqlConnection connection = new SqlConnection(Conexion.ConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM GEPacientes", connection);
                DataTable datos = new DataTable();
                adapter.Fill(datos);

                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    //lista.Add(datos.Rows[i]["Nombre"].ToString());
                    //lista.Add(datos.Rows[i]["Apellido"].ToString());
                    string nombreCompleto = datos.Rows[i]["Nombre"].ToString() + " " + datos.Rows[i]["Apellido"].ToString();
                    lista.Add(nombreCompleto);
                }

                textBoxNombrePaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBoxNombrePaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBoxNombrePaciente.AutoCompleteCustomSource = lista;
            }
        }


        #endregion

        #region Eventos
        private void ConsultarCitas_Load(object sender, EventArgs e)
        {
            dateTimePickerFechaCita.Value = DateTime.Today;
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            CargarCitasDia(Conexion.ConnectionString);
        }

        private void buttonBuscarCitaNombre_Click(object sender, EventArgs e)
        {
            BuscarCitaPaciente(Conexion.ConnectionString);
        }

        #endregion


        //private DateTime ObtenerFechaActual()
        //{
        //    DateTime fechaActual = DateTime.Today;
        //    return fechaActual;
        //}

    }
}

using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio.Formularios
{
    public partial class FrmBuscarPaciente : Form
    {

        #region Variables

        /// <summary>
        /// DataTable utilizado para capturar los datos de los pacientes y posteriormente utilizarlos para el autocompletar
        /// </summary>
        DataTable datos = new DataTable();

        #endregion

        #region Metodos

        private void BuscarPaciente(string connectionString)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxBusquedaPaciente.Text))
                {
                    MessageBox.Show("Por favor ingrese el nombre de el paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {

                    Cursor = Cursors.WaitCursor;
                    // Crear un DataSet para almacenar los datos
                    DataSet dataSet = new DataSet();

                    // Obtener nombre y apellido del TextBox
                    string nombreCompleto = textBoxBusquedaPaciente.Text.Trim();
                    string[] partesNombre = nombreCompleto.Split(' '); // Suponiendo que el nombre y el apellido están separados por espacio

                    string nombre = partesNombre[0]; // Primer parte es el nombre
                    string apellido = partesNombre.Length > 1 ? partesNombre[1] : ""; // Segunda parte es el apellido, si existe

                    // Crear una conexión y un comando para ejecutar el procedimiento almacenado
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand("GEPacientesSUDI", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Oprcion", "S");
                        command.Parameters.AddWithValue("@Opcion", "1");
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellido", apellido);

                        // Abrir la conexión
                        connection.Open();

                        // Ejecutar el comando y llenar el DataSet con los resultados
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataSet);
                        }
                    }

                    // Verificar si el DataSet contiene datos
                    if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                    {
                        // Limpiar las columnas existentes en el DataGridView
                        dataGridViewBusquedaPaciente.Columns.Clear();

                        // Asignar el origen de datos al DataGridView
                        dataGridViewBusquedaPaciente.DataSource = dataSet.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados para la búsqueda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void MostrarTodosPacientes(string connectionString)
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
                dataGridViewBusquedaPaciente.Columns.Clear();

                dataGridViewBusquedaPaciente.DataSource = dataSet.Tables[0];

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
        /// Configura el autocompletado para el TextBox de búsqueda de pacientes, utilizando nombres y apellidos obtenidos de la base de datos.
        /// </summary>
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

                textBoxBusquedaPaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBoxBusquedaPaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBoxBusquedaPaciente.AutoCompleteCustomSource = lista;
            }
        }

        #endregion

        #region Controlador
        public FrmBuscarPaciente()
        {
            InitializeComponent();
            AutoCompletar();
            
        }

        #endregion

        #region Eventos
        private void buttonBuscarPaciente_Click(object sender, EventArgs e)
        {
            BuscarPaciente(Conexion.ConnectionString);
        }

        private void buttonDescargar_Click(object sender, EventArgs e)
        {
            ExportarAExcel.ExportarDataGridViewAExcel(dataGridViewBusquedaPaciente);
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            MostrarTodosPacientes(Conexion.ConnectionString);
        }

        #endregion

        
    }
}

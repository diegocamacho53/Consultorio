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
    public partial class FrmRegistrarRoles : Form
    {

        #region Variables

        /// <summary>
        /// Variable que indica si la operación está activa o no.
        /// Por defecto, se establece en falso.
        /// <summary>
        private bool Operacion = false;

        /// <summary>
        /// Variable que indica si se está creando un nuevo rol o no.
        /// Por defecto, se establece en verdadero.
        /// </summary>
        private bool isNewRole = true;

        /// <summary>
        /// Almacena el identificador del rol.
        /// Por defecto, se establece en 0.
        /// </summary>
        private int IdRol = 0;
        #endregion

        #region Constructor

        public FrmRegistrarRoles()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Registra un nuevo rol en la base de datos o actualiza uno existente, según el estado de la operación.
        /// </summary>
        private void RegistrarRol()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GERegistrarRolesSUDI";
                    command.Parameters.AddWithValue("@Oprcion", "I");
                    command.Parameters.AddWithValue("@Opcion", "1");
                    command.Parameters.AddWithValue("@Rol", textBoxRol.Text);
                    command.Parameters.AddWithValue("@Estado", checkBoxEstadoRol.Checked ? 1 : 0);

                    Conexion.EjecutarComando(command);

                    MessageBox.Show($"La informacion a sido guardada correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Operacion = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar el rol en la tabla ROLES. {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Limpia los campos de entrada de datos en la interfaz gráfica después de una operación exitosa.
        /// </summary>
        private void Limpiar()
        {
            try
            {
                if (Operacion == true)
                {
                    textBoxRol.Clear();
                    checkBoxEstadoRol.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar limpiar {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Habilita la edición de los campos de entrada de datos en la interfaz gráfica.
        /// </summary>
        private void HabilitarCampos()
        {
            try
            {
                textBoxRol.ReadOnly = false;
                checkBoxEstadoRol.Enabled = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Carga los roles desde la base de datos y los muestra en un DataGridView.
        /// </summary>
        /// <param name="connectionString">Cadena de conexión a la base de datos.</param>
        private void CargarRoles(string connectionString)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                // Crear un DataSet para almacenar los datos
                DataSet dataSet = new DataSet();

                // Crear una conexión y un comando para ejecutar el procedimiento almacenado
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("GERegistrarRolesSUDI", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Oprcion", "S");
                    command.Parameters.AddWithValue("@Opcion", "1");

                    // Abrir la conexión
                    connection.Open();

                    // Ejecutar el comando y llenar el DataSet con los resultados
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataSet);
                    }
                }

                // Limpiar las columnas existentes en el DataGridView
                dataGridViewRoles.Columns.Clear();

                dataGridViewRoles.DataSource = dataSet.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar la tabla ROLES. {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Bloquea los campos de entrada de texto y deshabilita los controles de estado.
        /// </summary>
        private void BloquearCampos()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                textBoxRol.ReadOnly = true;
                checkBoxEstadoRol.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar la tabla ROLES. {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }

        /// <summary>
        /// Edita un rol existente en la base de datos.
        /// </summary>
        private void EditarRol()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GERegistrarRolesSUDI";
                    command.Parameters.AddWithValue("@Oprcion", "U");
                    command.Parameters.AddWithValue("@Opcion", "1");
                    command.Parameters.AddWithValue("@IdRol", IdRol);
                    command.Parameters.AddWithValue("@Rol", textBoxRol.Text);
                    command.Parameters.AddWithValue("@Estado", checkBoxEstadoRol.Checked ? 1 : 0);

                    Conexion.EjecutarComando(command);

                    MessageBox.Show($"La informacion a sido actualizada correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Operacion = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar el rol en la tabla ROLES. {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }


        #endregion

        #region Eventos
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isNewRole)
                {
                    this.RegistrarRol();
                    this.Limpiar();
                    this.BloquearCampos();
                    CargarRoles(Conexion.ConnectionString);
                }
                else
                {
                    this.EditarRol();
                    this.CargarRoles(Conexion.ConnectionString);
                    this.BloquearCampos();
                    this.Limpiar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            this.HabilitarCampos();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            this.CargarRoles(Conexion.ConnectionString);
        }

        private void dataGridViewRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el clic ocurrió en una celda de datos (no en encabezados ni en una fila vacía)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtiene el valor de la celda de la columna "Rol"
                object rolValue = dataGridViewRoles.Rows[e.RowIndex].Cells["Rol"].Value;

                // Si el valor no es nulo, lo asigna al textBoxRol
                if (rolValue != null)
                {
                    textBoxRol.Text = rolValue.ToString();
                }

                // Obtiene el valor de la celda de la columna "Estado"
                object estadoValue = dataGridViewRoles.Rows[e.RowIndex].Cells["Estado"].Value;

                // Si el valor no es nulo, lo asigna al checkBoxEstadoRol
                if (estadoValue != null)
                {
                    checkBoxEstadoRol.Checked = (bool)estadoValue;
                }
                object IdRolValue = dataGridViewRoles.Rows[e.RowIndex].Cells["ID"].Value;

                // Si el valor no es nulo, lo asigna al checkBoxEstadoRol
                if (IdRolValue != null)
                {
                    IdRol = (int)IdRolValue;
                }
            }
        }
    }

        #endregion

}

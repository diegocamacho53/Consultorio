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
    public partial class FrmRegistrarUsuarios : Form
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


        private int IDValueGlobal = 0;
        #endregion

        #region Controlador
        public FrmRegistrarUsuarios()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos

        private void CargarUsuarios(string connectionString)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                // Crear un DataSet para almacenar los datos
                DataSet dataSet = new DataSet();

                // Crear una conexión y un comando para ejecutar el procedimiento almacenado
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("GERegistrarUsuariosSUDI", connection))
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
                MessageBox.Show($"Error al mostrar la tabla Usuarios. {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ActualizarUsuario()
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
                    command.Parameters.AddWithValue("@IdUsuarios", IDValueGlobal);
                    command.Parameters.AddWithValue("@Usuario", textUsuario.Text);
                    command.Parameters.AddWithValue("@IdRol", comboBoxRoles.Text);
                    command.Parameters.AddWithValue("@Activo", checkBoxEstadoUsuario.Checked ? 1 : 0);

                    Conexion.EjecutarComando(command);

                    MessageBox.Show($"La informacion a sido actualizada correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Operacion = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el rol en la tabla Pacientes. {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Operacion = false;
                return;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void LlenarComboBoxRoles()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT IdRoles, Rol FROM dbo.fn_GetRoles()";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable rolesTable = new DataTable();
                    adapter.Fill(rolesTable);

                    if (rolesTable.Rows.Count > 0)
                    {
                        DataRow row = rolesTable.NewRow();
                        row["IdRoles"] = DBNull.Value;
                        row["Rol"] = "-Seleccione un rol-";
                        rolesTable.Rows.InsertAt(row, 0);

                        comboBoxRoles.DataSource = rolesTable;
                        comboBoxRoles.DisplayMember = "Rol";
                        comboBoxRoles.ValueMember = "IdRoles";
                    }
                    else
                    {
                        MessageBox.Show("No se pudieron obtener los datos de los roles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al llenar el ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BloquearCampos()
        {
            textUsuario.ReadOnly = true;
            textBoxContraseña.ReadOnly = true;
            comboBoxRoles.Enabled = false;
            checkBoxEstadoUsuario.Enabled = false;
            comboBoxPreguntaSecreta.Enabled = false;
            textBoxRespuestaSeceta.ReadOnly = true;
        }

        private void HabilitarCampos()
        {
            textUsuario.ReadOnly = false;
            textBoxContraseña.ReadOnly = false;
            comboBoxRoles.Enabled = true;
            checkBoxEstadoUsuario.Enabled = true;
            comboBoxPreguntaSecreta.Enabled = true;
            textBoxRespuestaSeceta.ReadOnly = false;
        }

        private void Limpiar()
        {
            textUsuario.Clear();
            textBoxContraseña.Clear();
            if (comboBoxRoles.Items.Count > 0)
            {
                comboBoxRoles.SelectedIndex = 0; // Selecciona el primer ítem, asumiendo que es "-Seleccione un rol-"
            }

            // Establecer el CheckBox a falso
            checkBoxEstadoUsuario.Checked = false;

        }

        private void RegistrarUsuario()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                // Verificar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(textUsuario.Text) || string.IsNullOrWhiteSpace(textBoxContraseña.Text) || comboBoxRoles.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Operacion = false;
                    return; // Salir del método si hay campos vacíos
                }

                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GERegistrarUsuariosSUDI";
                    command.Parameters.AddWithValue("@Oprcion", "I");
                    command.Parameters.AddWithValue("@Opcion", "1");
                    command.Parameters.AddWithValue("@Usuario", textUsuario.Text);
                    command.Parameters.AddWithValue("@Contraseña", textBoxContraseña.Text);
                    command.Parameters.AddWithValue("@IdRol", comboBoxRoles.SelectedValue); // Usa SelectedValue para obtener el ID del rol
                    command.Parameters.AddWithValue("@Activo", checkBoxEstadoUsuario.Checked ? 1 : 0);

                    Conexion.EjecutarComando(command);

                    MessageBox.Show("La información ha sido guardada correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Operacion = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar el rol en la tabla usuarios. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Operacion = false;
                return;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        #endregion

        #region Eventos
        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            this.CargarUsuarios(Conexion.ConnectionString);
        }

        private void dataGridViewRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el clic ocurrió en una celda de datos (no en encabezados ni en una fila vacía)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtiene el valor de la celda de la columna "usuario"
                object usuarioValue = dataGridViewRoles.Rows[e.RowIndex].Cells["Usuario"].Value;

                // Si el valor no es nulo, lo asigna al textBoxRol
                if (usuarioValue != null)
                {
                    textUsuario.Text = usuarioValue.ToString();
                }

                // Obtiene el valor de la celda de la columna "usuario"
                object RolValue = dataGridViewRoles.Rows[e.RowIndex].Cells["Rol"].Value;

                // Si el valor no es nulo, lo asigna al textBoxRol
                if (RolValue != null)
                {
                    comboBoxRoles.Text = RolValue.ToString();
                }

                // Obtiene el valor de la celda de la columna "contraseña"
                //object contraseñaValue = dataGridViewRoles.Rows[e.RowIndex].Cells["Contraseña"].Value;

                //// Si el valor no es nulo, lo asigna al textBoxRol
                //if (contraseñaValue != null)
                //{
                //    textUsuario.Text = contraseñaValue.ToString();
                //}

                // Obtiene el valor de la celda de la columna "Estado"
                object estadoValue = dataGridViewRoles.Rows[e.RowIndex].Cells["Estado"].Value;

                // Si el valor no es nulo, lo asigna al checkBoxEstadoRol
                if (estadoValue != null)
                {
                    checkBoxEstadoUsuario.Checked = (bool)estadoValue;
                }
                object IDValue = dataGridViewRoles.Rows[e.RowIndex].Cells["ID"].Value;

                // Si el valor no es nulo, lo asigna al checkBoxEstadoRol
                if (IDValue != null)
                {
                    IDValue = (int)IDValue;
                    IDValue = IDValueGlobal;
                }
                
                isNewRole = false;
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isNewRole)
                {
                    this.RegistrarUsuario();
                    this.Limpiar();
                    this.BloquearCampos();
                    CargarUsuarios(Conexion.ConnectionString);
                }
                else
                {
                    this.ActualizarUsuario();
                    this.CargarUsuarios(Conexion.ConnectionString);
                    this.BloquearCampos();
                    this.Limpiar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmRegistrarUsuarios_Load(object sender, EventArgs e)
        {
            this.LlenarComboBoxRoles();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            this.HabilitarCampos();
        }        

        #endregion

    }
}

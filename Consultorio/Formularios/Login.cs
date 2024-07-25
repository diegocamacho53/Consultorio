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
    /// <summary>
    /// Formulario de inicio de sesión para autenticar usuarios.
    /// </summary>
    public partial class Login : Form
    {
        #region Variables

        /// <summary>
        /// Indica si se ha iniciado sesión correctamente.
        /// </summary>
        private bool sesionIniciada = false;

        /// <summary>
        /// Almacena el Id del usuario que ha iniciado sesión.
        /// </summary>
        private int idUsuario;


        #endregion

        #region Controlador

        /// <summary>
        /// Constructor de la clase Login.
        /// </summary>
        public Login()
        {
            InitializeComponent();
            txtUsuario.KeyDown += txtUsuario_KeyDown;
            txtContraseña.KeyDown += txtContraseña_KeyDown;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Método para iniciar sesión con las credenciales proporcionadas por el usuario.
        /// </summary>
        private void IniciarSesion()
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            using (SqlConnection connection = new SqlConnection(Conexion.ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM GEUsuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        // Credenciales correctas, obtener el IdUsuario
                        idUsuario = ObtenerIdUsuario(usuario);

                        // Mostrar formulario de PanelPrincipal
                        PanelPrincipal formPacientes = new PanelPrincipal(Conexion.ConnectionString, usuario, idUsuario);
                        formPacientes.IniciarCronometro(); // Método para iniciar el cronómetro
                        formPacientes.Show();
                        this.Hide(); // Ocultar el formulario de login
                        sesionIniciada = true;
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos. Por favor, intente de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Método para obtener el IdUsuario dado el nombre de usuario.
        /// </summary>
        /// <param name="usuario">El nombre del usuario.</param>
        /// <returns>El Id del usuario.</returns>
        private int ObtenerIdUsuario(string usuario)
        {
            int idUsuario = 0;
            using (SqlConnection connection = new SqlConnection(Conexion.ConnectionString))
            {
                string query = "SELECT IdUsuarios FROM GEUsuarios WHERE Usuario = @Usuario";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", usuario);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        idUsuario = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener IdUsuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return idUsuario;
        }
        #endregion

        #region Eventos

        /// <summary>
        /// Maneja el evento Click del botón "Login". Inicia sesión al llamar al método IniciarSesion().
        /// </summary>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        /// <summary>
        /// Maneja el evento CheckedChanged del checkBoxMostrarContraseña. Cambia la visibilidad de la contraseña en el campo de texto.
        /// </summary>
        private void checkBoxMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !checkBoxMostrarContraseña.Checked;
        }

        /// <summary>
        /// Maneja el evento KeyDown del botón "Login". Si la tecla presionada es Enter, llama al método IniciarSesion().
        /// </summary>
        private void buttonLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IniciarSesion();
            }
        }

        /// <summary>
        /// Maneja el evento KeyDown del campo de texto txtUsuario. Si la tecla presionada es Enter y no se ha iniciado sesión, llama al método IniciarSesion().
        /// </summary>
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    IniciarSesion();
            //}
            if (e.KeyCode == Keys.Enter)
            {
                if (!sesionIniciada)
                {
                    IniciarSesion();
                }
            }
        }

        /// <summary>
        /// Maneja el evento KeyDown del campo de texto txtContraseña. Si la tecla presionada es Enter y no se ha iniciado sesión, llama al método IniciarSesion().
        /// </summary>
        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    IniciarSesion();
            //}
            if (e.KeyCode == Keys.Enter)
            {
                if (!sesionIniciada)
                {
                    IniciarSesion();
                }
            }
        }


        /// <summary>
        /// Maneja el evento Click del botón "Cerrar Sesión". Cierra el formulario actual.
        /// </summary>
        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Maneja el evento Click del linkLabel "Olvidé mi contraseña". Abre el formulario FrmRecuperarContraseña para recuperar la contraseña del usuario.
        /// </summary>
        private void linkLabelOlvideMiContraseña_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim(); // Obtén el nombre de usuario y elimina espacios en blanco al inicio y al final

            // Verifica si el nombre de usuario está vacío
            if (string.IsNullOrEmpty(nombreUsuario))
            {
                // Aquí puedes mostrar un mensaje o realizar alguna acción indicando que el nombre de usuario no puede estar vacío
                MessageBox.Show("Debes ingresar tu nombre de usuario para recuperar la contraseña.");
                return; // Detiene la ejecución del método si el nombre de usuario está vacío
            }

            // Si el nombre de usuario no está vacío, abre el formulario FrmRecuperarContraseña
            FrmRecuperarContraseña frmRecuperarContraseña = new FrmRecuperarContraseña(nombreUsuario);
            frmRecuperarContraseña.ShowDialog();
        }
        #endregion


    }
}



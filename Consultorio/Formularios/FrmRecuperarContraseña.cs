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
    public partial class FrmRecuperarContraseña : Form
    {
        private string nombreUsuario;
        public FrmRecuperarContraseña(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            string preguntaSecreta = ObtenerPreguntaSecreta(nombreUsuario);
            textBoxUsuario.Text = nombreUsuario;
            if (string.IsNullOrEmpty(preguntaSecreta))
            {
                MessageBox.Show("El usuario no tiene una respuesta secreta configurada o no se pudo obtener.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                labelPreguntaSecreta.Text = preguntaSecreta;
            }
        }

        private void CambiarContraseña()
        {
            string respuestaSecretaIngresada = labelPreguntaSecreta.Text;
            string nuevaContraseña = textBoxNuevaContraseña.Text;
            string confirmarContraseña = textBoxConfirmarContraseña.Text;
            string respuestaSecretaAlmacenada = textBoxRespuestaSecreta.Text;

            // Validar que textBoxNuevaContraseña y textBoxConfirmarContraseña no estén vacíos
            if (string.IsNullOrWhiteSpace(nuevaContraseña) || string.IsNullOrWhiteSpace(confirmarContraseña))
            {
                MessageBox.Show("Debes ingresar la nueva contraseña y confirmarla.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Validar que textBoxRespuestaSecreta no esté vacío
            if (string.IsNullOrWhiteSpace(respuestaSecretaAlmacenada))
            {
                MessageBox.Show("Debes ingresar la respuesta secreta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (nuevaContraseña != confirmarContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden. Inténtalo de nuevo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Aquí deberías tener el nombre de usuario disponible en nombreUsuario (asegúrate de haberlo obtenido previamente)

            using (SqlConnection conexion = new SqlConnection(Conexion.ConnectionString))
            {
                try
                {
                    conexion.Open();

                    // Llamar al procedimiento almacenado para actualizar la contraseña
                    using (SqlCommand comandoActualizar = new SqlCommand("GERegistrarUsuariosSUDI", conexion))
                    {
                        comandoActualizar.CommandType = System.Data.CommandType.StoredProcedure;
                        comandoActualizar.Parameters.AddWithValue("@Oprcion", "U");
                        comandoActualizar.Parameters.AddWithValue("@Opcion", 2);
                        comandoActualizar.Parameters.AddWithValue("@Usuario", nombreUsuario);
                        comandoActualizar.Parameters.AddWithValue("@Contraseña", nuevaContraseña);
                        comandoActualizar.Parameters.AddWithValue("@RespuestaSecreta", respuestaSecretaAlmacenada);

                        Conexion.EjecutarComando(comandoActualizar);
                    }

                    MessageBox.Show("Contraseña actualizada con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la contraseña: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string ObtenerPreguntaSecreta(string nombreUsuario)
        {
            string preguntaSecreta = null;
            string consulta = @"
                SELECT PS.Pregunta 
                FROM GEUsuarios U
                INNER JOIN GEPreguntasSecretas PS ON U.IdPregunta = PS.IdPregunta
                WHERE U.Usuario = @Usuario";

            using (SqlConnection conexion = new SqlConnection(Conexion.ConnectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand command = new SqlCommand(consulta, conexion))
                    {
                        command.Parameters.AddWithValue("@Usuario", nombreUsuario);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                preguntaSecreta = reader["Pregunta"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener la pregunta secreta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return preguntaSecreta;
        }


        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            CambiarContraseña();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

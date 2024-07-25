using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio
{
    public class Conexion
    {
        private bool Operacion = false;
        private static string connectionString = "Data Source=Athan-Black\\MSSQLSERVER01;Initial Catalog=Consultorio;Integrated Security=True;TrustServerCertificate=true";

        public static string ConnectionString { get; } = "Data Source=Athan-Black\\MSSQLSERVER01;Initial Catalog=Consultorio;Integrated Security=True;TrustServerCertificate=true";

        public static void EjecutarComando(SqlCommand command)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(ConnectionString))
                {
                    cnx.Open();
                    command.Connection = cnx;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar el comando: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

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
    public partial class FrmFinanzasConsultorio : Form
    {
        public FrmFinanzasConsultorio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        #region Metodos

        private void CargarFinanzas(string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Cambiar el comando para ejecutar un SELECT directamente
                    using (SqlCommand command = new SqlCommand("SELECT * FROM TransaccionesFinancieras", connection))
                    {
                        command.CommandType = CommandType.Text; // Usar Text para comandos SQL directos

                        // Abrir la conexión
                        connection.Open();

                        SqlDataAdapter daTable = new SqlDataAdapter(command);
                        DataSet dsTabla = new DataSet();

                        daTable.Fill(dsTabla, "Resultado");

                        // Asignar la fuente de datos al DataGridView
                        dataGridViewFinanzas.DataSource = dsTabla.Tables["Resultado"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar la tabla de finanzas. {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        #endregion

        private void FrmFinanzasConsultorio_Load(object sender, EventArgs e)
        {
            CargarFinanzas(Conexion.ConnectionString);
        }


    }
}

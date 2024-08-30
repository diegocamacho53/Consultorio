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
    public partial class FrmFinanzasConsultorio : Form
    {
        #region Variables

        bool Operacion = true;

        #endregion

        #region Controlador
        public FrmFinanzasConsultorio()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos


        public void CargarFinanzas(string connectionString)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                // Crear un DataSet para almacenar los datos
                DataSet dataSet = new DataSet();

                // Crear una conexión y un comando para ejecutar el procedimiento almacenado
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("dbo.sp_ConsultarPorFecha", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Asignar las fechas seleccionadas a los parámetros
                    command.Parameters.AddWithValue("@FechaInicio", dateTimePickerFechaInicio.Value.Date);
                    command.Parameters.AddWithValue("@FechaFin", dateTimePickerFechaFinal.Value.Date);

                    // Abrir la conexión
                    connection.Open();

                    // Ejecutar el comando y llenar el DataSet con los resultados
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataSet);
                    }
                }

                // Limpiar las columnas existentes en el DataGridView
                dataGridViewFinanzas.Columns.Clear();

                // Asignar el DataSet al DataGridView
                dataGridViewFinanzas.DataSource = dataSet.Tables[0];

                // Calcular el total de ingresos
                decimal totalIngresos = 0;
                decimal totalEngresos = 0;

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    if (row["TipoTransaccion"].ToString() == "Ingreso") 
                    {
                        decimal montoA;
                        if (Decimal.TryParse(row["Monto"].ToString(), out montoA))
                        {
                            totalIngresos += montoA;
                        }
                    }
                }

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    if (row["TipoTransaccion"].ToString() == "Egreso")
                    {
                        decimal montoB;
                        if (Decimal.TryParse(row["Monto"].ToString(), out montoB))
                        {
                            totalEngresos += montoB;
                        }
                    }
                }             
                                
                labelIngresos.Text = totalIngresos.ToString("C2"); // Formato como moneda
                labelEgresos.Text = totalEngresos.ToString("C2");
                labelBalance.Text = (totalIngresos - totalEngresos).ToString("C2");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al consultar la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar la tabla de finanzas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void InsertarIngresosExtra()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxSaldo.Text) ||
                string.IsNullOrWhiteSpace(comboBoxMetodoPago.Text) ||
                string.IsNullOrWhiteSpace(textBoxEspecificacion.Text) ||
                !decimal.TryParse(textBoxSaldo.Text, out decimal monto) ||
                monto <= 0)
                {
                    MessageBox.Show("Por favor, llene todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "GEExtrasIngresos";
                        command.Parameters.AddWithValue("@Monto", textBoxSaldo.Text);
                        command.Parameters.AddWithValue("@FormaPago", comboBoxMetodoPago.SelectedItem?.ToString());
                        command.Parameters.AddWithValue("@Descripcion", textBoxEspecificacion.Text);


                        Conexion.EjecutarComando(command);


                        // Si no hay excepción, mostrar mensaje de confirmación
                        MessageBox.Show($"La información ha sido guardada correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Operacion = true;

                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Capturar errores específicos de SQL Server
                MessageBox.Show($"Error al insertar la cita en la tabla Finanzas. {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CargarTotalMonto(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT dbo.fn_TotalMontoTransacciones() AS TotalMonto", connection))
                {
                    command.CommandType = CommandType.Text; // Usar Text para comandos SQL directos

                    // Abrir la conexión
                    connection.Open();

                    // Ejecutar el comando y obtener el valor
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        labelIngresos.Text = $"$ {Convert.ToDecimal(result):N2}";
                    }
                    else
                    {
                        labelIngresos.Text = "$ 0.00"; // O un valor predeterminado si es necesario
                    }
                }
            }
        }

        private void CargarTotalPendiente(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT dbo.fn_TotalPendienteCitas() AS TotalPendiente", connection))
                {
                    command.CommandType = CommandType.Text; // Usar Text para comandos SQL directos

                    // Abrir la conexión
                    connection.Open();

                    // Ejecutar el comando y obtener el valor
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        labelPendientes.Text = $"$ {Convert.ToDecimal(result):N2}";
                    }
                    else
                    {
                        labelPendientes.Text = "$ 0.00"; // O un valor predeterminado si es necesario
                    }
                }
            }
        }

        private void CargarTotalEgreso(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT dbo.fn_TotalEgresos() AS TotalEgresos", connection))
                {
                    command.CommandType = CommandType.Text; // Usar Text para comandos SQL directos

                    // Abrir la conexión
                    connection.Open();

                    // Ejecutar el comando y obtener el valor
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        labelEgresos.Text = $"$ {Convert.ToDecimal(result):N2}";
                    }
                    else
                    {
                        labelEgresos.Text = "$ 0.00"; // O un valor predeterminado si es necesario
                    }
                }
            }
        }

        private void CargarTotalBalanceGeneral(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT dbo.fn_TotalPatrimonioNeto() AS TotalPatrimonioNeto", connection))
                {
                    command.CommandType = CommandType.Text; // Usar Text para comandos SQL directos

                    // Abrir la conexión
                    connection.Open();

                    // Ejecutar el comando y obtener el valor
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        labelBalance.Text = $"$ {Convert.ToDecimal(result):N2}";
                    }
                    else
                    {
                        labelBalance.Text = "$ 0.00"; // O un valor predeterminado si es necesario
                    }
                }
            }
        }

        #endregion

        #region Eventos

        private void FrmFinanzasConsultorio_Load(object sender, EventArgs e)
        {
            CargarFinanzas(Conexion.ConnectionString);
            //CargarTotalMonto(Conexion.ConnectionString);
            CargarTotalPendiente(Conexion.ConnectionString);
            //CargarTotalEgreso(Conexion.ConnectionString);
            //CargarTotalBalanceGeneral(Conexion.ConnectionString);

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            InsertarIngresosExtra();
        }

        private void buttonCargar_Click_1(object sender, EventArgs e)
        {
            CargarFinanzas(Conexion.ConnectionString);
            //CargarTotalMonto(Conexion.ConnectionString);
            CargarTotalPendiente(Conexion.ConnectionString);
            //CargarTotalEgreso(Conexion.ConnectionString);
            //CargarTotalBalanceGeneral(Conexion.ConnectionString);
        }
       
        #endregion



    }
}

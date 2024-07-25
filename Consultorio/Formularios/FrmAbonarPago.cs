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
    public partial class FrmAbonarPago : Form
    {

        private int idCita;

        // Propiedad para recibir idCitaSeleccionada
        public int IdCitaSeleccionada
        {
            get { return idCita; }
            set { idCita = value; }
        }
        public FrmAbonarPago()
        {
            InitializeComponent();
        }

        //private void AbonarPago()
        //{
        //    try
        //    {
        //        Cursor = Cursors.WaitCursor;

        //        using (SqlCommand command = new SqlCommand())
        //        {
        //            command.CommandType = CommandType.StoredProcedure;
        //            command.CommandText = "GECitasSUDI"; // Ajusta el nombre del procedimiento almacenado
        //            command.Parameters.AddWithValue("@Oprcion", "A"); // Define la opción para abonar
        //            command.Parameters.AddWithValue("@Opcion", 1); // Define la opción específica dentro del abono

        //            // Ajusta el nombre del parámetro y asegúrate de obtener el valor adecuadamente
        //            int pagoAbono = Convert.ToInt32(textBoxAbonarValor.Text);
        //            command.Parameters.AddWithValue("@Pago", pagoAbono);

        //            command.Parameters.AddWithValue("@IdCita", idCita); // Ajusta el valor del IdCita

        //            Conexion.EjecutarComando(command);

        //            MessageBox.Show($"¿Está seguro de querer abonar el valor?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al realizar el abono. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    finally
        //    {
        //        Cursor = Cursors.Default;
        //    }
        //}

        private void AbonarPago()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                // Obtener el valor del pago a abonar
                int pagoAbono = Convert.ToInt32(textBoxAbonarValor.Text);

                // Verificar si el pago es mayor que el valor pendiente
                int valorPendiente = ObtenerValorPendiente(idCita); // Método para obtener el valor pendiente

                if (pagoAbono > valorPendiente)
                {
                    MessageBox.Show("El monto del pago excede el valor pendiente de la cita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si el pago es mayor que el pendiente
                }

                // Confirmación antes de realizar el abono
                DialogResult resultado = MessageBox.Show($"¿Está seguro de querer abonar el valor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resultado == DialogResult.Yes)
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "GECitasSUDI"; // Nombre del procedimiento almacenado para abonos
                        command.Parameters.AddWithValue("@Oprcion", "A"); // Opción para abonar
                        command.Parameters.AddWithValue("@Opcion", 1); // Opción específica dentro del abono
                        command.Parameters.AddWithValue("@Pago", pagoAbono); // Monto del abono
                        command.Parameters.AddWithValue("@IdCita", idCita); // Id de la cita

                        Conexion.EjecutarComando(command);

                        MessageBox.Show("Abono realizado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Obtener referencia al formulario principal FrmCitas
                        FrmCitas principal = Application.OpenForms["FrmCitas"] as FrmCitas;
                        if (principal != null)
                        {
                            principal.CargarCitas(); // Método para recargar las citas en el formulario principal
                            principal.limpiarCamposConTabla(); // Método para limpiar los campos en el formulario principal
                        }

                        this.Close(); // Cerrar el formulario actual
                    }
                }
                else if (resultado == DialogResult.No)
                {
                    // Cerrar el formulario si la persona selecciona "No"
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                textBoxAbonarValor.Clear();
                MessageBox.Show($"Error al realizar el abono. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        // Método para obtener el valor pendiente de una cita específica
        private int ObtenerValorPendiente(int idCita)
        {
            int valorPendiente = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT Pendiente FROM GECitas WHERE IdCita = @IdCita";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCita", idCita);
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            valorPendiente = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el valor pendiente. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valorPendiente;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            AbonarPago();

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

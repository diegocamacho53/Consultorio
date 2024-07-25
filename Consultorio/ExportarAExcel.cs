using System;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
namespace Consultorio
{
    public static class ExportarAExcel
    {
        public static void ExportarDataGridViewAExcel(DataGridView dataGridView)
        {
            try
            {
                // Crear una instancia de XLWorkbook
                using (var workbook = new XLWorkbook())
                {
                    // Agregar una hoja al libro de trabajo
                    var worksheet = workbook.Worksheets.Add("Pacientes");

                    // Agregar encabezados de columna
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dataGridView.Columns[i].HeaderText;
                    }

                    // Agregar filas de datos
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j + 1).Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    // Mostrar un cuadro de diálogo para guardar el archivo
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                        saveFileDialog.FilterIndex = 1;
                        saveFileDialog.RestoreDirectory = true;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Exportación exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar a Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

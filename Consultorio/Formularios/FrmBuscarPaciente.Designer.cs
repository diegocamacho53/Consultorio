namespace Consultorio.Formularios
{
    partial class FrmBuscarPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            panel4 = new Panel();
            dataGridViewBusquedaPaciente = new DataGridView();
            panel2 = new Panel();
            buttonCargar = new Button();
            buttonDescargar = new Button();
            buttonBuscarPaciente = new Button();
            textBoxBusquedaPaciente = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBusquedaPaciente).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1153, 656);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(panel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1153, 656);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Super Busqueda";
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridViewBusquedaPaciente);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 86);
            panel4.Name = "panel4";
            panel4.Size = new Size(1147, 567);
            panel4.TabIndex = 2;
            // 
            // dataGridViewBusquedaPaciente
            // 
            dataGridViewBusquedaPaciente.AllowUserToAddRows = false;
            dataGridViewBusquedaPaciente.AllowUserToDeleteRows = false;
            dataGridViewBusquedaPaciente.AllowUserToOrderColumns = true;
            dataGridViewBusquedaPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBusquedaPaciente.Dock = DockStyle.Fill;
            dataGridViewBusquedaPaciente.Location = new Point(0, 0);
            dataGridViewBusquedaPaciente.Name = "dataGridViewBusquedaPaciente";
            dataGridViewBusquedaPaciente.ReadOnly = true;
            dataGridViewBusquedaPaciente.RowHeadersWidth = 51;
            dataGridViewBusquedaPaciente.Size = new Size(1147, 567);
            dataGridViewBusquedaPaciente.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonCargar);
            panel2.Controls.Add(buttonDescargar);
            panel2.Controls.Add(buttonBuscarPaciente);
            panel2.Controls.Add(textBoxBusquedaPaciente);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(1147, 63);
            panel2.TabIndex = 1;
            // 
            // buttonCargar
            // 
            buttonCargar.AutoSize = true;
            buttonCargar.Location = new Point(692, 15);
            buttonCargar.Name = "buttonCargar";
            buttonCargar.Size = new Size(94, 30);
            buttonCargar.TabIndex = 7;
            buttonCargar.Text = "Cargar";
            buttonCargar.UseVisualStyleBackColor = true;
            buttonCargar.Click += buttonCargar_Click;
            // 
            // buttonDescargar
            // 
            buttonDescargar.AutoSize = true;
            buttonDescargar.Location = new Point(830, 13);
            buttonDescargar.Name = "buttonDescargar";
            buttonDescargar.Size = new Size(94, 30);
            buttonDescargar.TabIndex = 6;
            buttonDescargar.Text = "Descargar";
            buttonDescargar.UseVisualStyleBackColor = true;
            buttonDescargar.Click += buttonDescargar_Click;
            // 
            // buttonBuscarPaciente
            // 
            buttonBuscarPaciente.Location = new Point(545, 15);
            buttonBuscarPaciente.Name = "buttonBuscarPaciente";
            buttonBuscarPaciente.Size = new Size(94, 29);
            buttonBuscarPaciente.TabIndex = 1;
            buttonBuscarPaciente.Text = "Buscar";
            buttonBuscarPaciente.UseVisualStyleBackColor = true;
            buttonBuscarPaciente.Click += buttonBuscarPaciente_Click;
            // 
            // textBoxBusquedaPaciente
            // 
            textBoxBusquedaPaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxBusquedaPaciente.Location = new Point(40, 15);
            textBoxBusquedaPaciente.Name = "textBoxBusquedaPaciente";
            textBoxBusquedaPaciente.Size = new Size(460, 27);
            textBoxBusquedaPaciente.TabIndex = 0;
            // 
            // FrmBuscarPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 656);
            Controls.Add(panel1);
            Name = "FrmBuscarPaciente";
            Text = "Busqueda";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBusquedaPaciente).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel4;
        private DataGridView dataGridViewBusquedaPaciente;
        private Panel panel2;
        private Button buttonCargar;
        private Button buttonDescargar;
        private Button buttonBuscarPaciente;
        private TextBox textBoxBusquedaPaciente;
    }
}
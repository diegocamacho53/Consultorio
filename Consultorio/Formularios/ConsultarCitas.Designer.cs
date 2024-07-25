namespace Consultorio.Formularios
{
    partial class ConsultarCitas
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
            panelAgendas = new Panel();
            panel1 = new Panel();
            buttonBuscarCitaNombre = new Button();
            button1 = new Button();
            buttonLimpiar = new Button();
            buttonMostrar = new Button();
            panelAgenda = new Panel();
            dataGridViewTablaAgenda = new DataGridView();
            panelFechas = new Panel();
            textBoxNombrePaciente = new TextBox();
            dateTimePickerFechaCita = new DateTimePicker();
            panelAgendas.SuspendLayout();
            panel1.SuspendLayout();
            panelAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTablaAgenda).BeginInit();
            panelFechas.SuspendLayout();
            SuspendLayout();
            // 
            // panelAgendas
            // 
            panelAgendas.Controls.Add(panel1);
            panelAgendas.Controls.Add(panelAgenda);
            panelAgendas.Controls.Add(panelFechas);
            panelAgendas.Dock = DockStyle.Fill;
            panelAgendas.Location = new Point(0, 0);
            panelAgendas.Name = "panelAgendas";
            panelAgendas.Size = new Size(800, 450);
            panelAgendas.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonLimpiar);
            panel1.Controls.Add(buttonMostrar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 386);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 64);
            panel1.TabIndex = 2;
            // 
            // buttonBuscarCitaNombre
            // 
            buttonBuscarCitaNombre.AutoSize = true;
            buttonBuscarCitaNombre.FlatAppearance.BorderSize = 0;
            buttonBuscarCitaNombre.FlatStyle = FlatStyle.System;
            buttonBuscarCitaNombre.Location = new Point(643, 20);
            buttonBuscarCitaNombre.Name = "buttonBuscarCitaNombre";
            buttonBuscarCitaNombre.Size = new Size(66, 29);
            buttonBuscarCitaNombre.TabIndex = 4;
            buttonBuscarCitaNombre.Text = "Buscar";
            buttonBuscarCitaNombre.UseVisualStyleBackColor = true;
            buttonBuscarCitaNombre.Click += buttonBuscarCitaNombre_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(172, 0);
            button1.Name = "button1";
            button1.Size = new Size(86, 64);
            button1.TabIndex = 3;
            button1.Text = "Descargar";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.AutoSize = true;
            buttonLimpiar.Dock = DockStyle.Left;
            buttonLimpiar.FlatAppearance.BorderSize = 0;
            buttonLimpiar.FlatStyle = FlatStyle.Flat;
            buttonLimpiar.Location = new Point(86, 0);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(86, 64);
            buttonLimpiar.TabIndex = 2;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // buttonMostrar
            // 
            buttonMostrar.AutoSize = true;
            buttonMostrar.Dock = DockStyle.Left;
            buttonMostrar.FlatAppearance.BorderSize = 0;
            buttonMostrar.FlatStyle = FlatStyle.Flat;
            buttonMostrar.Location = new Point(0, 0);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.Size = new Size(86, 64);
            buttonMostrar.TabIndex = 1;
            buttonMostrar.Text = "Cargar";
            buttonMostrar.UseVisualStyleBackColor = true;
            buttonMostrar.Click += buttonMostrar_Click;
            // 
            // panelAgenda
            // 
            panelAgenda.Controls.Add(dataGridViewTablaAgenda);
            panelAgenda.Dock = DockStyle.Fill;
            panelAgenda.Location = new Point(0, 62);
            panelAgenda.Name = "panelAgenda";
            panelAgenda.Size = new Size(800, 388);
            panelAgenda.TabIndex = 1;
            // 
            // dataGridViewTablaAgenda
            // 
            dataGridViewTablaAgenda.AllowUserToAddRows = false;
            dataGridViewTablaAgenda.AllowUserToDeleteRows = false;
            dataGridViewTablaAgenda.AllowUserToOrderColumns = true;
            dataGridViewTablaAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTablaAgenda.Dock = DockStyle.Fill;
            dataGridViewTablaAgenda.Location = new Point(0, 0);
            dataGridViewTablaAgenda.Name = "dataGridViewTablaAgenda";
            dataGridViewTablaAgenda.ReadOnly = true;
            dataGridViewTablaAgenda.RowHeadersWidth = 51;
            dataGridViewTablaAgenda.Size = new Size(800, 388);
            dataGridViewTablaAgenda.TabIndex = 1;
            // 
            // panelFechas
            // 
            panelFechas.Controls.Add(buttonBuscarCitaNombre);
            panelFechas.Controls.Add(textBoxNombrePaciente);
            panelFechas.Controls.Add(dateTimePickerFechaCita);
            panelFechas.Dock = DockStyle.Top;
            panelFechas.Location = new Point(0, 0);
            panelFechas.Name = "panelFechas";
            panelFechas.Size = new Size(800, 62);
            panelFechas.TabIndex = 0;
            // 
            // textBoxNombrePaciente
            // 
            textBoxNombrePaciente.Location = new Point(383, 20);
            textBoxNombrePaciente.Name = "textBoxNombrePaciente";
            textBoxNombrePaciente.Size = new Size(266, 27);
            textBoxNombrePaciente.TabIndex = 14;
            // 
            // dateTimePickerFechaCita
            // 
            dateTimePickerFechaCita.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaCita.Location = new Point(67, 20);
            dateTimePickerFechaCita.Name = "dateTimePickerFechaCita";
            dateTimePickerFechaCita.Size = new Size(192, 27);
            dateTimePickerFechaCita.TabIndex = 13;
            dateTimePickerFechaCita.Value = new DateTime(2024, 7, 4, 0, 0, 0, 0);
            // 
            // ConsultarCitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelAgendas);
            Name = "ConsultarCitas";
            Text = "ConsultarCitas";
            Load += ConsultarCitas_Load;
            panelAgendas.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelAgenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTablaAgenda).EndInit();
            panelFechas.ResumeLayout(false);
            panelFechas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAgendas;
        private Panel panel1;
        private Button button1;
        private Button buttonLimpiar;
        private Button buttonMostrar;
        private Panel panelAgenda;
        private DataGridView dataGridViewTablaAgenda;
        private Panel panelFechas;
        private DateTimePicker dateTimePickerFechaCita;
        private Button buttonBuscarCitaNombre;
        private TextBox textBoxNombrePaciente;
    }
}
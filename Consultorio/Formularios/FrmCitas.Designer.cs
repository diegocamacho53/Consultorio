namespace Consultorio.Formularios
{
    partial class FrmCitas
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
            panelRegistrarCitas = new Panel();
            groupBoxAgendarCita = new GroupBox();
            splitContainer1 = new SplitContainer();
            panelRegistroCitas = new Panel();
            comboBoxHorasCitas = new ComboBox();
            label6 = new Label();
            checkBoxEstado = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxValorTotal = new TextBox();
            textBoxPago = new TextBox();
            dateTimePickerFechaCita = new DateTimePicker();
            richTextBoxNotas = new RichTextBox();
            checkBox1 = new CheckBox();
            comboBoxPacientes = new ComboBox();
            panelBarraBotones = new Panel();
            buttonHabilitarCampos = new Button();
            buttonGuardar = new Button();
            buttonAbonar = new Button();
            buttonCargar = new Button();
            buttonLimpiar = new Button();
            panelVistaCita = new Panel();
            dataGridViewAgenda = new DataGridView();
            panelRegistrarCitas.SuspendLayout();
            groupBoxAgendarCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelRegistroCitas.SuspendLayout();
            panelBarraBotones.SuspendLayout();
            panelVistaCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgenda).BeginInit();
            SuspendLayout();
            // 
            // panelRegistrarCitas
            // 
            panelRegistrarCitas.Controls.Add(groupBoxAgendarCita);
            panelRegistrarCitas.Dock = DockStyle.Fill;
            panelRegistrarCitas.Location = new Point(0, 0);
            panelRegistrarCitas.Name = "panelRegistrarCitas";
            panelRegistrarCitas.Size = new Size(1304, 643);
            panelRegistrarCitas.TabIndex = 0;
            // 
            // groupBoxAgendarCita
            // 
            groupBoxAgendarCita.Controls.Add(splitContainer1);
            groupBoxAgendarCita.Dock = DockStyle.Fill;
            groupBoxAgendarCita.Location = new Point(0, 0);
            groupBoxAgendarCita.Name = "groupBoxAgendarCita";
            groupBoxAgendarCita.Size = new Size(1304, 643);
            groupBoxAgendarCita.TabIndex = 0;
            groupBoxAgendarCita.TabStop = false;
            groupBoxAgendarCita.Text = "Agendar";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 23);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panelRegistroCitas);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelVistaCita);
            splitContainer1.Size = new Size(1298, 617);
            splitContainer1.SplitterDistance = 626;
            splitContainer1.TabIndex = 1;
            // 
            // panelRegistroCitas
            // 
            panelRegistroCitas.Controls.Add(comboBoxHorasCitas);
            panelRegistroCitas.Controls.Add(label6);
            panelRegistroCitas.Controls.Add(checkBoxEstado);
            panelRegistroCitas.Controls.Add(label5);
            panelRegistroCitas.Controls.Add(label4);
            panelRegistroCitas.Controls.Add(label3);
            panelRegistroCitas.Controls.Add(label2);
            panelRegistroCitas.Controls.Add(label1);
            panelRegistroCitas.Controls.Add(textBoxValorTotal);
            panelRegistroCitas.Controls.Add(textBoxPago);
            panelRegistroCitas.Controls.Add(dateTimePickerFechaCita);
            panelRegistroCitas.Controls.Add(richTextBoxNotas);
            panelRegistroCitas.Controls.Add(checkBox1);
            panelRegistroCitas.Controls.Add(comboBoxPacientes);
            panelRegistroCitas.Controls.Add(panelBarraBotones);
            panelRegistroCitas.Dock = DockStyle.Fill;
            panelRegistroCitas.Location = new Point(0, 0);
            panelRegistroCitas.Name = "panelRegistroCitas";
            panelRegistroCitas.Size = new Size(626, 617);
            panelRegistroCitas.TabIndex = 0;
            // 
            // comboBoxHorasCitas
            // 
            comboBoxHorasCitas.FormattingEnabled = true;
            comboBoxHorasCitas.Location = new Point(253, 129);
            comboBoxHorasCitas.Name = "comboBoxHorasCitas";
            comboBoxHorasCitas.Size = new Size(241, 28);
            comboBoxHorasCitas.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 137);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 30;
            label6.Text = "Hora cita";
            // 
            // checkBoxEstado
            // 
            checkBoxEstado.AutoSize = true;
            checkBoxEstado.Location = new Point(106, 346);
            checkBoxEstado.Name = "checkBoxEstado";
            checkBoxEstado.Size = new Size(76, 24);
            checkBoxEstado.TabIndex = 28;
            checkBoxEstado.Text = "Estado";
            checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 308);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 27;
            label5.Text = "Notas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 246);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 26;
            label4.Text = "Pago";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 190);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 25;
            label3.Text = "Valor cita";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 87);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 24;
            label2.Text = "Fecha cita";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 37);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 23;
            label1.Text = "Paciente";
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.Location = new Point(253, 183);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.Size = new Size(241, 27);
            textBoxValorTotal.TabIndex = 22;
            textBoxValorTotal.KeyPress += textBoxValorTotal_KeyPress;
            // 
            // textBoxPago
            // 
            textBoxPago.Location = new Point(253, 243);
            textBoxPago.Name = "textBoxPago";
            textBoxPago.Size = new Size(241, 27);
            textBoxPago.TabIndex = 21;
            textBoxPago.KeyPress += textBoxPago_KeyPress;
            // 
            // dateTimePickerFechaCita
            // 
            dateTimePickerFechaCita.CustomFormat = "";
            dateTimePickerFechaCita.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaCita.Location = new Point(253, 80);
            dateTimePickerFechaCita.Name = "dateTimePickerFechaCita";
            dateTimePickerFechaCita.Size = new Size(241, 27);
            dateTimePickerFechaCita.TabIndex = 20;
            dateTimePickerFechaCita.Value = new DateTime(2024, 7, 4, 0, 0, 0, 0);
            dateTimePickerFechaCita.ValueChanged += dateTimePickerFechaCita_ValueChanged;
            // 
            // richTextBoxNotas
            // 
            richTextBoxNotas.Location = new Point(253, 308);
            richTextBoxNotas.MaxLength = 150;
            richTextBoxNotas.Name = "richTextBoxNotas";
            richTextBoxNotas.Size = new Size(305, 144);
            richTextBoxNotas.TabIndex = 19;
            richTextBoxNotas.Text = "";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(-112, 373);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBoxPacientes
            // 
            comboBoxPacientes.FormattingEnabled = true;
            comboBoxPacientes.Location = new Point(253, 29);
            comboBoxPacientes.Name = "comboBoxPacientes";
            comboBoxPacientes.Size = new Size(241, 28);
            comboBoxPacientes.TabIndex = 17;
            // 
            // panelBarraBotones
            // 
            panelBarraBotones.Controls.Add(buttonHabilitarCampos);
            panelBarraBotones.Controls.Add(buttonGuardar);
            panelBarraBotones.Controls.Add(buttonAbonar);
            panelBarraBotones.Controls.Add(buttonCargar);
            panelBarraBotones.Controls.Add(buttonLimpiar);
            panelBarraBotones.Dock = DockStyle.Bottom;
            panelBarraBotones.Location = new Point(0, 551);
            panelBarraBotones.Name = "panelBarraBotones";
            panelBarraBotones.Size = new Size(626, 66);
            panelBarraBotones.TabIndex = 1;
            // 
            // buttonHabilitarCampos
            // 
            buttonHabilitarCampos.Dock = DockStyle.Left;
            buttonHabilitarCampos.FlatAppearance.BorderSize = 0;
            buttonHabilitarCampos.FlatStyle = FlatStyle.Flat;
            buttonHabilitarCampos.Location = new Point(500, 0);
            buttonHabilitarCampos.Name = "buttonHabilitarCampos";
            buttonHabilitarCampos.Size = new Size(125, 66);
            buttonHabilitarCampos.TabIndex = 3;
            buttonHabilitarCampos.Text = "Habilitar";
            buttonHabilitarCampos.UseVisualStyleBackColor = true;
            buttonHabilitarCampos.Click += buttonHabilitarCampos_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.AutoSize = true;
            buttonGuardar.Dock = DockStyle.Left;
            buttonGuardar.FlatAppearance.BorderSize = 0;
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.Location = new Point(375, 0);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(125, 66);
            buttonGuardar.TabIndex = 0;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonAbonar
            // 
            buttonAbonar.Dock = DockStyle.Left;
            buttonAbonar.FlatAppearance.BorderSize = 0;
            buttonAbonar.FlatStyle = FlatStyle.Flat;
            buttonAbonar.Location = new Point(250, 0);
            buttonAbonar.Name = "buttonAbonar";
            buttonAbonar.Size = new Size(125, 66);
            buttonAbonar.TabIndex = 2;
            buttonAbonar.Text = "Abonar";
            buttonAbonar.UseVisualStyleBackColor = true;
            buttonAbonar.Click += buttonAbonar_Click;
            // 
            // buttonCargar
            // 
            buttonCargar.Dock = DockStyle.Left;
            buttonCargar.FlatAppearance.BorderSize = 0;
            buttonCargar.FlatStyle = FlatStyle.Flat;
            buttonCargar.Location = new Point(125, 0);
            buttonCargar.Name = "buttonCargar";
            buttonCargar.Size = new Size(125, 66);
            buttonCargar.TabIndex = 1;
            buttonCargar.Text = "Cargar";
            buttonCargar.UseVisualStyleBackColor = true;
            buttonCargar.Click += buttonCargar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Dock = DockStyle.Left;
            buttonLimpiar.FlatAppearance.BorderSize = 0;
            buttonLimpiar.FlatStyle = FlatStyle.Flat;
            buttonLimpiar.Location = new Point(0, 0);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(125, 66);
            buttonLimpiar.TabIndex = 4;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // panelVistaCita
            // 
            panelVistaCita.Controls.Add(dataGridViewAgenda);
            panelVistaCita.Dock = DockStyle.Fill;
            panelVistaCita.Location = new Point(0, 0);
            panelVistaCita.Name = "panelVistaCita";
            panelVistaCita.Size = new Size(668, 617);
            panelVistaCita.TabIndex = 0;
            // 
            // dataGridViewAgenda
            // 
            dataGridViewAgenda.AllowUserToAddRows = false;
            dataGridViewAgenda.AllowUserToDeleteRows = false;
            dataGridViewAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAgenda.Dock = DockStyle.Fill;
            dataGridViewAgenda.Location = new Point(0, 0);
            dataGridViewAgenda.Name = "dataGridViewAgenda";
            dataGridViewAgenda.ReadOnly = true;
            dataGridViewAgenda.RowHeadersWidth = 51;
            dataGridViewAgenda.Size = new Size(668, 617);
            dataGridViewAgenda.TabIndex = 0;
            dataGridViewAgenda.CellClick += dataGridViewAgenda_CellClick;
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1304, 643);
            Controls.Add(panelRegistrarCitas);
            Name = "FrmCitas";
            Text = "Citas";
            Load += FrmCitas_Load;
            panelRegistrarCitas.ResumeLayout(false);
            groupBoxAgendarCita.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelRegistroCitas.ResumeLayout(false);
            panelRegistroCitas.PerformLayout();
            panelBarraBotones.ResumeLayout(false);
            panelBarraBotones.PerformLayout();
            panelVistaCita.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgenda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRegistrarCitas;
        private GroupBox groupBoxAgendarCita;
        private SplitContainer splitContainer1;
        private Panel panelRegistroCitas;
        private Label label1;
        private TextBox textBoxValorTotal;
        private TextBox textBoxPago;
        private DateTimePicker dateTimePickerFechaCita;
        private RichTextBox richTextBoxNotas;
        private CheckBox checkBox1;
        private ComboBox comboBoxPacientes;
        private Panel panelBarraBotones;
        private Button buttonGuardar;
        private Panel panelVistaCita;
        private DataGridView dataGridViewAgenda;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox checkBoxEstado;
        private Label label6;
        private Button buttonCargar;
        private Button buttonAbonar;
        private Button buttonHabilitarCampos;
        private Button buttonLimpiar;
        private ComboBox comboBoxHorasCitas;
    }
}
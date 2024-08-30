namespace Consultorio.Formularios
{
    partial class FrmFinanzasConsultorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinanzasConsultorio));
            panelFinanzas = new Panel();
            tabControl1 = new TabControl();
            tabPageIngresos = new TabPage();
            label7 = new Label();
            comboBoxMetodoPago = new ComboBox();
            panel1 = new Panel();
            button2 = new Button();
            buttonGuardar = new Button();
            label6 = new Label();
            label5 = new Label();
            textBoxSaldo = new TextBox();
            textBoxEspecificacion = new TextBox();
            pictureBox1 = new PictureBox();
            tabPageEgresos = new TabPage();
            panel3 = new Panel();
            pictureBoxLogo = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            textBoxValor = new TextBox();
            panel4 = new Panel();
            button5 = new Button();
            button4 = new Button();
            tabPageGrafica = new TabPage();
            panel5 = new Panel();
            dateTimePickerFechaFinal = new DateTimePicker();
            dateTimePickerFechaInicio = new DateTimePicker();
            panel2 = new Panel();
            labelBalance = new Label();
            label12 = new Label();
            labelPendientes = new Label();
            labelEgresos = new Label();
            labelIngresos = new Label();
            buttonCargar = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            dataGridViewFinanzas = new DataGridView();
            panelFinanzas.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageIngresos.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPageEgresos.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel4.SuspendLayout();
            tabPageGrafica.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinanzas).BeginInit();
            SuspendLayout();
            // 
            // panelFinanzas
            // 
            panelFinanzas.Controls.Add(tabControl1);
            panelFinanzas.Dock = DockStyle.Fill;
            panelFinanzas.Location = new Point(0, 0);
            panelFinanzas.Name = "panelFinanzas";
            panelFinanzas.Size = new Size(981, 638);
            panelFinanzas.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageIngresos);
            tabControl1.Controls.Add(tabPageEgresos);
            tabControl1.Controls.Add(tabPageGrafica);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(981, 638);
            tabControl1.TabIndex = 2;
            // 
            // tabPageIngresos
            // 
            tabPageIngresos.Controls.Add(label7);
            tabPageIngresos.Controls.Add(comboBoxMetodoPago);
            tabPageIngresos.Controls.Add(panel1);
            tabPageIngresos.Controls.Add(label6);
            tabPageIngresos.Controls.Add(label5);
            tabPageIngresos.Controls.Add(textBoxSaldo);
            tabPageIngresos.Controls.Add(textBoxEspecificacion);
            tabPageIngresos.Controls.Add(pictureBox1);
            tabPageIngresos.Location = new Point(4, 29);
            tabPageIngresos.Name = "tabPageIngresos";
            tabPageIngresos.Padding = new Padding(3);
            tabPageIngresos.Size = new Size(973, 605);
            tabPageIngresos.TabIndex = 0;
            tabPageIngresos.Text = "Ingresos";
            tabPageIngresos.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 214);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 20;
            label7.Text = "Metodo de pago";
            // 
            // comboBoxMetodoPago
            // 
            comboBoxMetodoPago.FormattingEnabled = true;
            comboBoxMetodoPago.Items.AddRange(new object[] { "Transferencia", "Efectivo" });
            comboBoxMetodoPago.Location = new Point(189, 214);
            comboBoxMetodoPago.Name = "comboBoxMetodoPago";
            comboBoxMetodoPago.Size = new Size(151, 28);
            comboBoxMetodoPago.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(buttonGuardar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 560);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 42);
            panel1.TabIndex = 18;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(94, 0);
            button2.Name = "button2";
            button2.Size = new Size(94, 42);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Dock = DockStyle.Left;
            buttonGuardar.FlatAppearance.BorderSize = 0;
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.Location = new Point(0, 0);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 42);
            buttonGuardar.TabIndex = 0;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(100, 151);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 17;
            label6.Text = "Saldo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 79);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 16;
            label5.Text = "Especificacion";
            // 
            // textBoxSaldo
            // 
            textBoxSaldo.Location = new Point(189, 151);
            textBoxSaldo.Name = "textBoxSaldo";
            textBoxSaldo.Size = new Size(151, 27);
            textBoxSaldo.TabIndex = 15;
            // 
            // textBoxEspecificacion
            // 
            textBoxEspecificacion.Location = new Point(189, 76);
            textBoxEspecificacion.Name = "textBoxEspecificacion";
            textBoxEspecificacion.Size = new Size(151, 27);
            textBoxEspecificacion.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(458, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 599);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // tabPageEgresos
            // 
            tabPageEgresos.Controls.Add(panel3);
            tabPageEgresos.Location = new Point(4, 29);
            tabPageEgresos.Name = "tabPageEgresos";
            tabPageEgresos.Padding = new Padding(3);
            tabPageEgresos.Size = new Size(973, 605);
            tabPageEgresos.TabIndex = 1;
            tabPageEgresos.Text = "Egresos";
            tabPageEgresos.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBoxLogo);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBoxValor);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(967, 599);
            panel3.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Right;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(455, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(512, 559);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxLogo.TabIndex = 12;
            pictureBoxLogo.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 258);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 11;
            label4.Text = "Justificacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 196);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 10;
            label2.Text = "Metodo de pago";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 251);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Efectivo", "Transferencia" });
            comboBox2.Location = new Point(196, 73);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Efectivo", "Transferencia" });
            comboBox1.Location = new Point(196, 188);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 133);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 6;
            label3.Text = "Saldo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 73);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 4;
            label1.Text = "Motivo";
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(196, 126);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(151, 27);
            textBoxValor.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button4);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 559);
            panel4.Name = "panel4";
            panel4.Size = new Size(967, 40);
            panel4.TabIndex = 0;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Left;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(94, 0);
            button5.Name = "button5";
            button5.Size = new Size(94, 40);
            button5.TabIndex = 1;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Left;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(94, 40);
            button4.TabIndex = 0;
            button4.Text = "Guardar";
            button4.UseVisualStyleBackColor = true;
            // 
            // tabPageGrafica
            // 
            tabPageGrafica.Controls.Add(panel5);
            tabPageGrafica.Controls.Add(panel2);
            tabPageGrafica.Controls.Add(dataGridViewFinanzas);
            tabPageGrafica.Location = new Point(4, 29);
            tabPageGrafica.Name = "tabPageGrafica";
            tabPageGrafica.Size = new Size(973, 605);
            tabPageGrafica.TabIndex = 2;
            tabPageGrafica.Text = "Visualizar Finanzas";
            tabPageGrafica.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Info;
            panel5.Controls.Add(dateTimePickerFechaFinal);
            panel5.Controls.Add(dateTimePickerFechaInicio);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 524);
            panel5.Name = "panel5";
            panel5.Size = new Size(702, 81);
            panel5.TabIndex = 2;
            // 
            // dateTimePickerFechaFinal
            // 
            dateTimePickerFechaFinal.CustomFormat = "";
            dateTimePickerFechaFinal.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaFinal.Location = new Point(223, 30);
            dateTimePickerFechaFinal.Name = "dateTimePickerFechaFinal";
            dateTimePickerFechaFinal.Size = new Size(110, 27);
            dateTimePickerFechaFinal.TabIndex = 22;
            dateTimePickerFechaFinal.Value = new DateTime(2024, 7, 4, 0, 0, 0, 0);
            // 
            // dateTimePickerFechaInicio
            // 
            dateTimePickerFechaInicio.CustomFormat = "";
            dateTimePickerFechaInicio.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaInicio.Location = new Point(52, 30);
            dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            dateTimePickerFechaInicio.Size = new Size(110, 27);
            dateTimePickerFechaInicio.TabIndex = 21;
            dateTimePickerFechaInicio.Value = new DateTime(2024, 7, 4, 0, 0, 0, 0);
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(labelBalance);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(labelPendientes);
            panel2.Controls.Add(labelEgresos);
            panel2.Controls.Add(labelIngresos);
            panel2.Controls.Add(buttonCargar);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(702, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 605);
            panel2.TabIndex = 1;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelBalance.ForeColor = Color.Khaki;
            labelBalance.Location = new Point(27, 482);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(0, 20);
            labelBalance.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 417);
            label12.Name = "label12";
            label12.Size = new Size(116, 20);
            label12.TabIndex = 7;
            label12.Text = "Balance General";
            // 
            // labelPendientes
            // 
            labelPendientes.AutoSize = true;
            labelPendientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPendientes.ForeColor = Color.Khaki;
            labelPendientes.Location = new Point(27, 352);
            labelPendientes.Name = "labelPendientes";
            labelPendientes.Size = new Size(0, 20);
            labelPendientes.TabIndex = 6;
            // 
            // labelEgresos
            // 
            labelEgresos.AutoSize = true;
            labelEgresos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelEgresos.ForeColor = Color.Red;
            labelEgresos.Location = new Point(27, 222);
            labelEgresos.Name = "labelEgresos";
            labelEgresos.Size = new Size(0, 20);
            labelEgresos.TabIndex = 5;
            // 
            // labelIngresos
            // 
            labelIngresos.AutoSize = true;
            labelIngresos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelIngresos.ForeColor = Color.Lime;
            labelIngresos.Location = new Point(27, 92);
            labelIngresos.Name = "labelIngresos";
            labelIngresos.Size = new Size(0, 20);
            labelIngresos.TabIndex = 4;
            // 
            // buttonCargar
            // 
            buttonCargar.Dock = DockStyle.Bottom;
            buttonCargar.FlatAppearance.BorderSize = 0;
            buttonCargar.FlatStyle = FlatStyle.Flat;
            buttonCargar.Location = new Point(0, 554);
            buttonCargar.Name = "buttonCargar";
            buttonCargar.Size = new Size(271, 51);
            buttonCargar.TabIndex = 3;
            buttonCargar.Text = "Cargar";
            buttonCargar.UseVisualStyleBackColor = true;
            buttonCargar.Click += buttonCargar_Click_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 287);
            label10.Name = "label10";
            label10.Size = new Size(74, 20);
            label10.TabIndex = 2;
            label10.Text = "Pendiente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 157);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 1;
            label9.Text = "Egresos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 27);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 0;
            label8.Text = "Ingresos";
            // 
            // dataGridViewFinanzas
            // 
            dataGridViewFinanzas.AllowUserToAddRows = false;
            dataGridViewFinanzas.AllowUserToDeleteRows = false;
            dataGridViewFinanzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFinanzas.Dock = DockStyle.Fill;
            dataGridViewFinanzas.Location = new Point(0, 0);
            dataGridViewFinanzas.Name = "dataGridViewFinanzas";
            dataGridViewFinanzas.ReadOnly = true;
            dataGridViewFinanzas.RowHeadersWidth = 51;
            dataGridViewFinanzas.Size = new Size(973, 605);
            dataGridViewFinanzas.TabIndex = 0;
            // 
            // FrmFinanzasConsultorio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 638);
            Controls.Add(panelFinanzas);
            Name = "FrmFinanzasConsultorio";
            Text = "Finanzas";
            Load += FrmFinanzasConsultorio_Load;
            panelFinanzas.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageIngresos.ResumeLayout(false);
            tabPageIngresos.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPageEgresos.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel4.ResumeLayout(false);
            tabPageGrafica.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinanzas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFinanzas;
        private TabControl tabControl1;
        private TabPage tabPageIngresos;
        private TabPage tabPageEgresos;
        private TabPage tabPageGrafica;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pictureBoxLogo;
        private Label label4;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label1;
        private TextBox textBoxValor;
        private Panel panel4;
        private Button button5;
        private Button button4;
        private TextBox textBoxEspecificacion;
        private Label label6;
        private Label label5;
        private TextBox textBoxSaldo;
        private Panel panel1;
        private Button button2;
        private Button buttonGuardar;
        private Label label7;
        private ComboBox comboBoxMetodoPago;
        private DataGridView dataGridViewFinanzas;
        private Panel panel2;
        private Label labelPendientes;
        private Label labelEgresos;
        private Label labelIngresos;
        private Button buttonCargar;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label labelBalance;
        private Label label12;
        private Panel panel5;
        private DateTimePicker dateTimePickerFechaFinal;
        private DateTimePicker dateTimePickerFechaInicio;
    }
}
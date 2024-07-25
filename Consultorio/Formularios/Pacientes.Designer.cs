namespace Consultorio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlPacientes = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            groupBoxRegistrosPacientes = new GroupBox();
            panelRegistroPacientes = new Panel();
            panelBotonesPacientes = new Panel();
            buttonMostrar = new Button();
            buttonEditar = new Button();
            buttonLimpiar = new Button();
            buttonGuardar = new Button();
            checkBoxEstado = new CheckBox();
            label7 = new Label();
            textBoxApellido = new TextBox();
            label6 = new Label();
            dateTimePickerFechaNacimiento = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxAcudiente = new TextBox();
            textBoxEdad = new TextBox();
            textBoxCelular = new TextBox();
            textBoxNombre = new TextBox();
            groupBoxVista = new GroupBox();
            panel3 = new Panel();
            dataGridViewTablaPacientes = new DataGridView();
            tabControlPacientes.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxRegistrosPacientes.SuspendLayout();
            panelRegistroPacientes.SuspendLayout();
            panelBotonesPacientes.SuspendLayout();
            groupBoxVista.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTablaPacientes).BeginInit();
            SuspendLayout();
            // 
            // tabControlPacientes
            // 
            tabControlPacientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlPacientes.Controls.Add(tabPage1);
            tabControlPacientes.Location = new Point(0, 0);
            tabControlPacientes.Name = "tabControlPacientes";
            tabControlPacientes.SelectedIndex = 0;
            tabControlPacientes.Size = new Size(1153, 656);
            tabControlPacientes.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1145, 623);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro Pacientes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxRegistrosPacientes);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBoxVista);
            splitContainer1.Size = new Size(1139, 617);
            splitContainer1.SplitterDistance = 513;
            splitContainer1.TabIndex = 0;
            // 
            // groupBoxRegistrosPacientes
            // 
            groupBoxRegistrosPacientes.Controls.Add(panelRegistroPacientes);
            groupBoxRegistrosPacientes.Dock = DockStyle.Fill;
            groupBoxRegistrosPacientes.Location = new Point(0, 0);
            groupBoxRegistrosPacientes.Name = "groupBoxRegistrosPacientes";
            groupBoxRegistrosPacientes.Size = new Size(513, 617);
            groupBoxRegistrosPacientes.TabIndex = 0;
            groupBoxRegistrosPacientes.TabStop = false;
            groupBoxRegistrosPacientes.Text = "Registro";
            // 
            // panelRegistroPacientes
            // 
            panelRegistroPacientes.Controls.Add(panelBotonesPacientes);
            panelRegistroPacientes.Controls.Add(checkBoxEstado);
            panelRegistroPacientes.Controls.Add(label7);
            panelRegistroPacientes.Controls.Add(textBoxApellido);
            panelRegistroPacientes.Controls.Add(label6);
            panelRegistroPacientes.Controls.Add(dateTimePickerFechaNacimiento);
            panelRegistroPacientes.Controls.Add(label5);
            panelRegistroPacientes.Controls.Add(label4);
            panelRegistroPacientes.Controls.Add(label3);
            panelRegistroPacientes.Controls.Add(label2);
            panelRegistroPacientes.Controls.Add(label1);
            panelRegistroPacientes.Controls.Add(textBoxAcudiente);
            panelRegistroPacientes.Controls.Add(textBoxEdad);
            panelRegistroPacientes.Controls.Add(textBoxCelular);
            panelRegistroPacientes.Controls.Add(textBoxNombre);
            panelRegistroPacientes.Dock = DockStyle.Fill;
            panelRegistroPacientes.Location = new Point(3, 23);
            panelRegistroPacientes.Name = "panelRegistroPacientes";
            panelRegistroPacientes.Size = new Size(507, 591);
            panelRegistroPacientes.TabIndex = 1;
            // 
            // panelBotonesPacientes
            // 
            panelBotonesPacientes.Controls.Add(buttonMostrar);
            panelBotonesPacientes.Controls.Add(buttonEditar);
            panelBotonesPacientes.Controls.Add(buttonLimpiar);
            panelBotonesPacientes.Controls.Add(buttonGuardar);
            panelBotonesPacientes.Dock = DockStyle.Bottom;
            panelBotonesPacientes.Location = new Point(0, 546);
            panelBotonesPacientes.Name = "panelBotonesPacientes";
            panelBotonesPacientes.Size = new Size(507, 45);
            panelBotonesPacientes.TabIndex = 0;
            // 
            // buttonMostrar
            // 
            buttonMostrar.AutoSize = true;
            buttonMostrar.Dock = DockStyle.Left;
            buttonMostrar.FlatAppearance.BorderSize = 0;
            buttonMostrar.FlatStyle = FlatStyle.Flat;
            buttonMostrar.Location = new Point(378, 0);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.Size = new Size(126, 45);
            buttonMostrar.TabIndex = 0;
            buttonMostrar.Text = "Cargar";
            buttonMostrar.UseVisualStyleBackColor = true;
            buttonMostrar.Click += buttonMostrar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.AutoSize = true;
            buttonEditar.Dock = DockStyle.Left;
            buttonEditar.FlatAppearance.BorderSize = 0;
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Location = new Point(252, 0);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(126, 45);
            buttonEditar.TabIndex = 2;
            buttonEditar.Text = "Habilitar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click_1;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.AutoSize = true;
            buttonLimpiar.Dock = DockStyle.Left;
            buttonLimpiar.FlatAppearance.BorderSize = 0;
            buttonLimpiar.FlatStyle = FlatStyle.Flat;
            buttonLimpiar.Location = new Point(126, 0);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(126, 45);
            buttonLimpiar.TabIndex = 4;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.AutoSize = true;
            buttonGuardar.Dock = DockStyle.Left;
            buttonGuardar.FlatAppearance.BorderSize = 0;
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.Location = new Point(0, 0);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(126, 45);
            buttonGuardar.TabIndex = 3;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // checkBoxEstado
            // 
            checkBoxEstado.AutoSize = true;
            checkBoxEstado.Enabled = false;
            checkBoxEstado.Location = new Point(314, 295);
            checkBoxEstado.Name = "checkBoxEstado";
            checkBoxEstado.Size = new Size(76, 24);
            checkBoxEstado.TabIndex = 16;
            checkBoxEstado.Text = "Estado";
            checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 91);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 15;
            label7.Text = "Apellido";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(198, 87);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.ReadOnly = true;
            textBoxApellido.Size = new Size(192, 27);
            textBoxApellido.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 333);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 13;
            label6.Text = "Fecha Nacimiento";
            // 
            // dateTimePickerFechaNacimiento
            // 
            dateTimePickerFechaNacimiento.Enabled = false;
            dateTimePickerFechaNacimiento.Location = new Point(198, 336);
            dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            dateTimePickerFechaNacimiento.Size = new Size(192, 27);
            dateTimePickerFechaNacimiento.TabIndex = 12;
            dateTimePickerFechaNacimiento.ValueChanged += dateTimePickerFechaNacimiento_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 289);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 10;
            label5.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 254);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 9;
            label4.Text = "Acudiente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 192);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 8;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 138);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 7;
            label2.Text = "Celular";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 38);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // textBoxAcudiente
            // 
            textBoxAcudiente.Location = new Point(198, 250);
            textBoxAcudiente.Name = "textBoxAcudiente";
            textBoxAcudiente.ReadOnly = true;
            textBoxAcudiente.Size = new Size(192, 27);
            textBoxAcudiente.TabIndex = 3;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(198, 188);
            textBoxEdad.MaxLength = 3;
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.ReadOnly = true;
            textBoxEdad.Size = new Size(192, 27);
            textBoxEdad.TabIndex = 2;
            textBoxEdad.KeyPress += textBoxEdad_KeyPress;
            // 
            // textBoxCelular
            // 
            textBoxCelular.Location = new Point(198, 134);
            textBoxCelular.MaxLength = 10;
            textBoxCelular.Name = "textBoxCelular";
            textBoxCelular.ReadOnly = true;
            textBoxCelular.Size = new Size(192, 27);
            textBoxCelular.TabIndex = 1;
            textBoxCelular.KeyPress += textBoxCelular_KeyPress;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(198, 38);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.ReadOnly = true;
            textBoxNombre.Size = new Size(192, 27);
            textBoxNombre.TabIndex = 0;
            // 
            // groupBoxVista
            // 
            groupBoxVista.Controls.Add(panel3);
            groupBoxVista.Dock = DockStyle.Fill;
            groupBoxVista.Location = new Point(0, 0);
            groupBoxVista.Name = "groupBoxVista";
            groupBoxVista.Size = new Size(622, 617);
            groupBoxVista.TabIndex = 1;
            groupBoxVista.TabStop = false;
            groupBoxVista.Text = "Vista";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewTablaPacientes);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(616, 591);
            panel3.TabIndex = 1;
            // 
            // dataGridViewTablaPacientes
            // 
            dataGridViewTablaPacientes.AllowUserToAddRows = false;
            dataGridViewTablaPacientes.AllowUserToDeleteRows = false;
            dataGridViewTablaPacientes.AllowUserToOrderColumns = true;
            dataGridViewTablaPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTablaPacientes.Dock = DockStyle.Fill;
            dataGridViewTablaPacientes.Location = new Point(0, 0);
            dataGridViewTablaPacientes.Name = "dataGridViewTablaPacientes";
            dataGridViewTablaPacientes.ReadOnly = true;
            dataGridViewTablaPacientes.RowHeadersWidth = 51;
            dataGridViewTablaPacientes.Size = new Size(616, 591);
            dataGridViewTablaPacientes.TabIndex = 0;
            dataGridViewTablaPacientes.CellClick += dataGridViewTablaPacientes_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 656);
            Controls.Add(tabControlPacientes);
            Name = "Form1";
            Text = "Pacientes";
            tabControlPacientes.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxRegistrosPacientes.ResumeLayout(false);
            panelRegistroPacientes.ResumeLayout(false);
            panelRegistroPacientes.PerformLayout();
            panelBotonesPacientes.ResumeLayout(false);
            panelBotonesPacientes.PerformLayout();
            groupBoxVista.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTablaPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPacientes;
        private TabPage tabPage1;
        private SplitContainer splitContainer1;
        private GroupBox groupBoxRegistrosPacientes;
        private Panel panelRegistroPacientes;
        private Panel panelBotonesPacientes;
        private GroupBox groupBoxVista;
        private Panel panel3;
        private DataGridView dataGridViewTablaPacientes;
        private TextBox textBoxAcudiente;
        private TextBox textBoxEdad;
        private TextBox textBoxCelular;
        private TextBox textBoxNombre;
        private Button buttonEditar;
        private Button buttonMostrar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private DateTimePicker dateTimePickerFechaNacimiento;
        private Button buttonGuardar;
        private Label label7;
        private TextBox textBoxApellido;
        private CheckBox checkBoxEstado;
        private Button buttonLimpiar;
    }
}

namespace Consultorio.Formularios
{
    partial class FrmRegistrarUsuarios
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
            panelClientes = new Panel();
            tabControlRegistrarUsuarios = new TabControl();
            tabPageRegistrarUsuario = new TabPage();
            splitContainer1 = new SplitContainer();
            groupBoxRoles = new GroupBox();
            label5 = new Label();
            textBoxRespuestaSeceta = new TextBox();
            label4 = new Label();
            comboBoxPreguntaSecreta = new ComboBox();
            label3 = new Label();
            comboBoxRoles = new ComboBox();
            label2 = new Label();
            textBoxContraseña = new TextBox();
            checkBoxEstadoUsuario = new CheckBox();
            panelMenu = new Panel();
            buttonLimpiar = new Button();
            buttonEditar = new Button();
            buttonMostrar = new Button();
            buttonGuardar = new Button();
            label1 = new Label();
            textUsuario = new TextBox();
            groupBoxVistaRoles = new GroupBox();
            dataGridViewRoles = new DataGridView();
            tabPage1 = new TabPage();
            splitContainer2 = new SplitContainer();
            groupBoxPreguntaSecreta = new GroupBox();
            checkBoxEstadoPreguntas = new CheckBox();
            panel1 = new Panel();
            buttonLimpiarCampos = new Button();
            buttonHabilitarCampos = new Button();
            buttonCargarPreguntas = new Button();
            buttonGuardarPregunta = new Button();
            label10 = new Label();
            textBoxPreguntaSecreta = new TextBox();
            groupBox2 = new GroupBox();
            dataGridViewPreguntas = new DataGridView();
            panelClientes.SuspendLayout();
            tabControlRegistrarUsuarios.SuspendLayout();
            tabPageRegistrarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxRoles.SuspendLayout();
            panelMenu.SuspendLayout();
            groupBoxVistaRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoles).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBoxPreguntaSecreta.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPreguntas).BeginInit();
            SuspendLayout();
            // 
            // panelClientes
            // 
            panelClientes.Controls.Add(tabControlRegistrarUsuarios);
            panelClientes.Dock = DockStyle.Fill;
            panelClientes.Location = new Point(0, 0);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(1063, 595);
            panelClientes.TabIndex = 3;
            // 
            // tabControlRegistrarUsuarios
            // 
            tabControlRegistrarUsuarios.Controls.Add(tabPageRegistrarUsuario);
            tabControlRegistrarUsuarios.Controls.Add(tabPage1);
            tabControlRegistrarUsuarios.Dock = DockStyle.Fill;
            tabControlRegistrarUsuarios.Location = new Point(0, 0);
            tabControlRegistrarUsuarios.Name = "tabControlRegistrarUsuarios";
            tabControlRegistrarUsuarios.SelectedIndex = 0;
            tabControlRegistrarUsuarios.Size = new Size(1063, 595);
            tabControlRegistrarUsuarios.TabIndex = 0;
            // 
            // tabPageRegistrarUsuario
            // 
            tabPageRegistrarUsuario.Controls.Add(splitContainer1);
            tabPageRegistrarUsuario.Location = new Point(4, 29);
            tabPageRegistrarUsuario.Name = "tabPageRegistrarUsuario";
            tabPageRegistrarUsuario.Padding = new Padding(3);
            tabPageRegistrarUsuario.Size = new Size(1055, 562);
            tabPageRegistrarUsuario.TabIndex = 0;
            tabPageRegistrarUsuario.Text = "Registrar  usuarios";
            tabPageRegistrarUsuario.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxRoles);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBoxVistaRoles);
            splitContainer1.Size = new Size(1049, 556);
            splitContainer1.SplitterDistance = 527;
            splitContainer1.TabIndex = 0;
            // 
            // groupBoxRoles
            // 
            groupBoxRoles.Controls.Add(label5);
            groupBoxRoles.Controls.Add(textBoxRespuestaSeceta);
            groupBoxRoles.Controls.Add(label4);
            groupBoxRoles.Controls.Add(comboBoxPreguntaSecreta);
            groupBoxRoles.Controls.Add(label3);
            groupBoxRoles.Controls.Add(comboBoxRoles);
            groupBoxRoles.Controls.Add(label2);
            groupBoxRoles.Controls.Add(textBoxContraseña);
            groupBoxRoles.Controls.Add(checkBoxEstadoUsuario);
            groupBoxRoles.Controls.Add(panelMenu);
            groupBoxRoles.Controls.Add(label1);
            groupBoxRoles.Controls.Add(textUsuario);
            groupBoxRoles.Dock = DockStyle.Fill;
            groupBoxRoles.Location = new Point(0, 0);
            groupBoxRoles.Name = "groupBoxRoles";
            groupBoxRoles.Size = new Size(527, 556);
            groupBoxRoles.TabIndex = 2;
            groupBoxRoles.TabStop = false;
            groupBoxRoles.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 235);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 31;
            label5.Text = "Respuesta secreta";
            // 
            // textBoxRespuestaSeceta
            // 
            textBoxRespuestaSeceta.Location = new Point(185, 232);
            textBoxRespuestaSeceta.Name = "textBoxRespuestaSeceta";
            textBoxRespuestaSeceta.PasswordChar = '*';
            textBoxRespuestaSeceta.ReadOnly = true;
            textBoxRespuestaSeceta.Size = new Size(222, 27);
            textBoxRespuestaSeceta.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 173);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 29;
            label4.Text = "Pregunta secreta";
            // 
            // comboBoxPreguntaSecreta
            // 
            comboBoxPreguntaSecreta.Enabled = false;
            comboBoxPreguntaSecreta.FormattingEnabled = true;
            comboBoxPreguntaSecreta.Location = new Point(185, 170);
            comboBoxPreguntaSecreta.Name = "comboBoxPreguntaSecreta";
            comboBoxPreguntaSecreta.Size = new Size(222, 28);
            comboBoxPreguntaSecreta.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 289);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 27;
            label3.Text = "Rol";
            // 
            // comboBoxRoles
            // 
            comboBoxRoles.Enabled = false;
            comboBoxRoles.FormattingEnabled = true;
            comboBoxRoles.Location = new Point(185, 286);
            comboBoxRoles.Name = "comboBoxRoles";
            comboBoxRoles.Size = new Size(222, 28);
            comboBoxRoles.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 110);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 25;
            label2.Text = "Contraseña";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(185, 103);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.PasswordChar = '*';
            textBoxContraseña.ReadOnly = true;
            textBoxContraseña.Size = new Size(222, 27);
            textBoxContraseña.TabIndex = 24;
            // 
            // checkBoxEstadoUsuario
            // 
            checkBoxEstadoUsuario.AutoSize = true;
            checkBoxEstadoUsuario.Enabled = false;
            checkBoxEstadoUsuario.Location = new Point(185, 335);
            checkBoxEstadoUsuario.Name = "checkBoxEstadoUsuario";
            checkBoxEstadoUsuario.Size = new Size(76, 24);
            checkBoxEstadoUsuario.TabIndex = 23;
            checkBoxEstadoUsuario.Text = "Estado";
            checkBoxEstadoUsuario.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(buttonLimpiar);
            panelMenu.Controls.Add(buttonEditar);
            panelMenu.Controls.Add(buttonMostrar);
            panelMenu.Controls.Add(buttonGuardar);
            panelMenu.Dock = DockStyle.Bottom;
            panelMenu.Location = new Point(3, 487);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(521, 66);
            panelMenu.TabIndex = 14;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.AutoSize = true;
            buttonLimpiar.Dock = DockStyle.Left;
            buttonLimpiar.FlatAppearance.BorderSize = 0;
            buttonLimpiar.FlatStyle = FlatStyle.Flat;
            buttonLimpiar.Location = new Point(390, 0);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(130, 66);
            buttonLimpiar.TabIndex = 4;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            buttonEditar.AutoSize = true;
            buttonEditar.Dock = DockStyle.Left;
            buttonEditar.FlatAppearance.BorderSize = 0;
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Location = new Point(260, 0);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(130, 66);
            buttonEditar.TabIndex = 3;
            buttonEditar.Text = "Habilitar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonMostrar
            // 
            buttonMostrar.AutoSize = true;
            buttonMostrar.Dock = DockStyle.Left;
            buttonMostrar.FlatAppearance.BorderSize = 0;
            buttonMostrar.FlatStyle = FlatStyle.Flat;
            buttonMostrar.Location = new Point(130, 0);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.Size = new Size(130, 66);
            buttonMostrar.TabIndex = 2;
            buttonMostrar.Text = "Cargar";
            buttonMostrar.UseVisualStyleBackColor = true;
            buttonMostrar.Click += buttonMostrar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.AutoSize = true;
            buttonGuardar.Dock = DockStyle.Left;
            buttonGuardar.FlatAppearance.BorderSize = 0;
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.Location = new Point(0, 0);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(130, 66);
            buttonGuardar.TabIndex = 0;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 51);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 13;
            label1.Text = "Nombre usuario";
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(185, 44);
            textUsuario.Name = "textUsuario";
            textUsuario.ReadOnly = true;
            textUsuario.Size = new Size(222, 27);
            textUsuario.TabIndex = 7;
            // 
            // groupBoxVistaRoles
            // 
            groupBoxVistaRoles.Controls.Add(dataGridViewRoles);
            groupBoxVistaRoles.Dock = DockStyle.Fill;
            groupBoxVistaRoles.Location = new Point(0, 0);
            groupBoxVistaRoles.Name = "groupBoxVistaRoles";
            groupBoxVistaRoles.Size = new Size(518, 556);
            groupBoxVistaRoles.TabIndex = 1;
            groupBoxVistaRoles.TabStop = false;
            groupBoxVistaRoles.Text = "Vista";
            // 
            // dataGridViewRoles
            // 
            dataGridViewRoles.AllowUserToAddRows = false;
            dataGridViewRoles.AllowUserToDeleteRows = false;
            dataGridViewRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoles.Dock = DockStyle.Fill;
            dataGridViewRoles.Location = new Point(3, 23);
            dataGridViewRoles.Name = "dataGridViewRoles";
            dataGridViewRoles.ReadOnly = true;
            dataGridViewRoles.RowHeadersWidth = 51;
            dataGridViewRoles.Size = new Size(512, 530);
            dataGridViewRoles.TabIndex = 0;
            dataGridViewRoles.CellClick += dataGridViewRoles_CellClick;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1055, 562);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Pregunta Secreta";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBoxPreguntaSecreta);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(groupBox2);
            splitContainer2.Size = new Size(1049, 556);
            splitContainer2.SplitterDistance = 527;
            splitContainer2.TabIndex = 1;
            // 
            // groupBoxPreguntaSecreta
            // 
            groupBoxPreguntaSecreta.Controls.Add(checkBoxEstadoPreguntas);
            groupBoxPreguntaSecreta.Controls.Add(panel1);
            groupBoxPreguntaSecreta.Controls.Add(label10);
            groupBoxPreguntaSecreta.Controls.Add(textBoxPreguntaSecreta);
            groupBoxPreguntaSecreta.Dock = DockStyle.Fill;
            groupBoxPreguntaSecreta.Location = new Point(0, 0);
            groupBoxPreguntaSecreta.Name = "groupBoxPreguntaSecreta";
            groupBoxPreguntaSecreta.Size = new Size(527, 556);
            groupBoxPreguntaSecreta.TabIndex = 2;
            groupBoxPreguntaSecreta.TabStop = false;
            groupBoxPreguntaSecreta.UseCompatibleTextRendering = true;
            // 
            // checkBoxEstadoPreguntas
            // 
            checkBoxEstadoPreguntas.AutoSize = true;
            checkBoxEstadoPreguntas.Enabled = false;
            checkBoxEstadoPreguntas.Location = new Point(185, 92);
            checkBoxEstadoPreguntas.Name = "checkBoxEstadoPreguntas";
            checkBoxEstadoPreguntas.Size = new Size(76, 24);
            checkBoxEstadoPreguntas.TabIndex = 23;
            checkBoxEstadoPreguntas.Text = "Estado";
            checkBoxEstadoPreguntas.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonLimpiarCampos);
            panel1.Controls.Add(buttonHabilitarCampos);
            panel1.Controls.Add(buttonCargarPreguntas);
            panel1.Controls.Add(buttonGuardarPregunta);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 487);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 66);
            panel1.TabIndex = 14;
            // 
            // buttonLimpiarCampos
            // 
            buttonLimpiarCampos.AutoSize = true;
            buttonLimpiarCampos.Dock = DockStyle.Left;
            buttonLimpiarCampos.FlatAppearance.BorderSize = 0;
            buttonLimpiarCampos.FlatStyle = FlatStyle.Flat;
            buttonLimpiarCampos.Location = new Point(390, 0);
            buttonLimpiarCampos.Name = "buttonLimpiarCampos";
            buttonLimpiarCampos.Size = new Size(130, 66);
            buttonLimpiarCampos.TabIndex = 4;
            buttonLimpiarCampos.Text = "Limpiar";
            buttonLimpiarCampos.UseVisualStyleBackColor = true;
            buttonLimpiarCampos.Click += buttonLimpiarCampos_Click;
            // 
            // buttonHabilitarCampos
            // 
            buttonHabilitarCampos.AutoSize = true;
            buttonHabilitarCampos.Dock = DockStyle.Left;
            buttonHabilitarCampos.FlatAppearance.BorderSize = 0;
            buttonHabilitarCampos.FlatStyle = FlatStyle.Flat;
            buttonHabilitarCampos.Location = new Point(260, 0);
            buttonHabilitarCampos.Name = "buttonHabilitarCampos";
            buttonHabilitarCampos.Size = new Size(130, 66);
            buttonHabilitarCampos.TabIndex = 3;
            buttonHabilitarCampos.Text = "Habilitar";
            buttonHabilitarCampos.UseVisualStyleBackColor = true;
            buttonHabilitarCampos.Click += buttonHabilitarCampos_Click;
            // 
            // buttonCargarPreguntas
            // 
            buttonCargarPreguntas.AutoSize = true;
            buttonCargarPreguntas.Dock = DockStyle.Left;
            buttonCargarPreguntas.FlatAppearance.BorderSize = 0;
            buttonCargarPreguntas.FlatStyle = FlatStyle.Flat;
            buttonCargarPreguntas.Location = new Point(130, 0);
            buttonCargarPreguntas.Name = "buttonCargarPreguntas";
            buttonCargarPreguntas.Size = new Size(130, 66);
            buttonCargarPreguntas.TabIndex = 2;
            buttonCargarPreguntas.Text = "Cargar";
            buttonCargarPreguntas.UseVisualStyleBackColor = true;
            buttonCargarPreguntas.Click += buttonCargarPreguntas_Click;
            // 
            // buttonGuardarPregunta
            // 
            buttonGuardarPregunta.AutoSize = true;
            buttonGuardarPregunta.Dock = DockStyle.Left;
            buttonGuardarPregunta.FlatAppearance.BorderSize = 0;
            buttonGuardarPregunta.FlatStyle = FlatStyle.Flat;
            buttonGuardarPregunta.Location = new Point(0, 0);
            buttonGuardarPregunta.Name = "buttonGuardarPregunta";
            buttonGuardarPregunta.Size = new Size(130, 66);
            buttonGuardarPregunta.TabIndex = 0;
            buttonGuardarPregunta.Text = "Guardar";
            buttonGuardarPregunta.UseVisualStyleBackColor = true;
            buttonGuardarPregunta.Click += buttonGuardarPregunta_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(43, 51);
            label10.Name = "label10";
            label10.Size = new Size(119, 20);
            label10.TabIndex = 13;
            label10.Text = "Pregunta secreta";
            // 
            // textBoxPreguntaSecreta
            // 
            textBoxPreguntaSecreta.Location = new Point(185, 44);
            textBoxPreguntaSecreta.Name = "textBoxPreguntaSecreta";
            textBoxPreguntaSecreta.ReadOnly = true;
            textBoxPreguntaSecreta.Size = new Size(164, 27);
            textBoxPreguntaSecreta.TabIndex = 7;
            textBoxPreguntaSecreta.TextChanged += textBoxPreguntaSecreta_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewPreguntas);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(518, 556);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Vista";
            // 
            // dataGridViewPreguntas
            // 
            dataGridViewPreguntas.AllowUserToAddRows = false;
            dataGridViewPreguntas.AllowUserToDeleteRows = false;
            dataGridViewPreguntas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPreguntas.Dock = DockStyle.Fill;
            dataGridViewPreguntas.Location = new Point(3, 23);
            dataGridViewPreguntas.Name = "dataGridViewPreguntas";
            dataGridViewPreguntas.ReadOnly = true;
            dataGridViewPreguntas.RowHeadersWidth = 51;
            dataGridViewPreguntas.Size = new Size(512, 530);
            dataGridViewPreguntas.TabIndex = 0;
            dataGridViewPreguntas.CellClick += dataGridViewPreguntas_CellClick;
            // 
            // FrmRegistrarUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 595);
            Controls.Add(panelClientes);
            Name = "FrmRegistrarUsuarios";
            Text = "Registrar usuarios";
            Load += FrmRegistrarUsuarios_Load;
            panelClientes.ResumeLayout(false);
            tabControlRegistrarUsuarios.ResumeLayout(false);
            tabPageRegistrarUsuario.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxRoles.ResumeLayout(false);
            groupBoxRoles.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            groupBoxVistaRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoles).EndInit();
            tabPage1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBoxPreguntaSecreta.ResumeLayout(false);
            groupBoxPreguntaSecreta.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPreguntas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelClientes;
        private TabControl tabControlRegistrarUsuarios;
        private TabPage tabPageRegistrarUsuario;
        private SplitContainer splitContainer1;
        private GroupBox groupBoxRoles;
        private Label label3;
        private ComboBox comboBoxRoles;
        private Label label2;
        private TextBox textBoxContraseña;
        private CheckBox checkBoxEstadoUsuario;
        private Panel panelMenu;
        private Button buttonEditar;
        private Button buttonMostrar;
        private Button buttonGuardar;
        private Label label1;
        private TextBox textUsuario;
        private GroupBox groupBoxVistaRoles;
        private DataGridView dataGridViewRoles;
        private Button buttonLimpiar;
        private Label label5;
        private TextBox textBoxRespuestaSeceta;
        private Label label4;
        private ComboBox comboBoxPreguntaSecreta;
        private TabPage tabPage1;
        private SplitContainer splitContainer2;
        private GroupBox groupBoxPreguntaSecreta;
        private CheckBox checkBoxEstadoPreguntas;
        private Panel panel1;
        private Button buttonLimpiarCampos;
        private Button buttonHabilitarCampos;
        private Button buttonCargarPreguntas;
        private Button buttonGuardarPregunta;
        private Label label10;
        private TextBox textBoxPreguntaSecreta;
        private GroupBox groupBox2;
        private DataGridView dataGridViewPreguntas;
    }
}
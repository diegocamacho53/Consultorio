namespace Consultorio.Formularios
{
    partial class FrmRegistrarRoles
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
            tabControlRegistrarRol = new TabControl();
            tabPageRegistrarUsuario = new TabPage();
            splitContainer1 = new SplitContainer();
            groupBoxRoles = new GroupBox();
            checkBoxEstadoRol = new CheckBox();
            panelMenu = new Panel();
            buttonEditar = new Button();
            buttonMostrar = new Button();
            buttonGuardar = new Button();
            label1 = new Label();
            textBoxRol = new TextBox();
            groupBoxVistaRoles = new GroupBox();
            dataGridViewRoles = new DataGridView();
            panelClientes.SuspendLayout();
            tabControlRegistrarRol.SuspendLayout();
            tabPageRegistrarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxRoles.SuspendLayout();
            panelMenu.SuspendLayout();
            groupBoxVistaRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoles).BeginInit();
            SuspendLayout();
            // 
            // panelClientes
            // 
            panelClientes.Controls.Add(tabControlRegistrarRol);
            panelClientes.Dock = DockStyle.Fill;
            panelClientes.Location = new Point(0, 0);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(859, 467);
            panelClientes.TabIndex = 2;
            // 
            // tabControlRegistrarRol
            // 
            tabControlRegistrarRol.Controls.Add(tabPageRegistrarUsuario);
            tabControlRegistrarRol.Dock = DockStyle.Fill;
            tabControlRegistrarRol.Location = new Point(0, 0);
            tabControlRegistrarRol.Name = "tabControlRegistrarRol";
            tabControlRegistrarRol.SelectedIndex = 0;
            tabControlRegistrarRol.Size = new Size(859, 467);
            tabControlRegistrarRol.TabIndex = 0;
            // 
            // tabPageRegistrarUsuario
            // 
            tabPageRegistrarUsuario.Controls.Add(splitContainer1);
            tabPageRegistrarUsuario.Location = new Point(4, 29);
            tabPageRegistrarUsuario.Name = "tabPageRegistrarUsuario";
            tabPageRegistrarUsuario.Padding = new Padding(3);
            tabPageRegistrarUsuario.Size = new Size(851, 434);
            tabPageRegistrarUsuario.TabIndex = 0;
            tabPageRegistrarUsuario.Text = "Registrar  Roles";
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
            splitContainer1.Size = new Size(845, 428);
            splitContainer1.SplitterDistance = 360;
            splitContainer1.TabIndex = 0;
            // 
            // groupBoxRoles
            // 
            groupBoxRoles.Controls.Add(checkBoxEstadoRol);
            groupBoxRoles.Controls.Add(panelMenu);
            groupBoxRoles.Controls.Add(label1);
            groupBoxRoles.Controls.Add(textBoxRol);
            groupBoxRoles.Dock = DockStyle.Fill;
            groupBoxRoles.Location = new Point(0, 0);
            groupBoxRoles.Name = "groupBoxRoles";
            groupBoxRoles.Size = new Size(360, 428);
            groupBoxRoles.TabIndex = 2;
            groupBoxRoles.TabStop = false;
            groupBoxRoles.Text = "Registar Roles";
            groupBoxRoles.UseCompatibleTextRendering = true;
            // 
            // checkBoxEstadoRol
            // 
            checkBoxEstadoRol.AutoSize = true;
            checkBoxEstadoRol.Enabled = false;
            checkBoxEstadoRol.Location = new Point(161, 93);
            checkBoxEstadoRol.Name = "checkBoxEstadoRol";
            checkBoxEstadoRol.Size = new Size(76, 24);
            checkBoxEstadoRol.TabIndex = 23;
            checkBoxEstadoRol.Text = "Estado";
            checkBoxEstadoRol.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(buttonEditar);
            panelMenu.Controls.Add(buttonMostrar);
            panelMenu.Controls.Add(buttonGuardar);
            panelMenu.Dock = DockStyle.Bottom;
            panelMenu.Location = new Point(3, 349);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(354, 76);
            panelMenu.TabIndex = 14;
            // 
            // buttonEditar
            // 
            buttonEditar.AutoSize = true;
            buttonEditar.Dock = DockStyle.Left;
            buttonEditar.FlatAppearance.BorderSize = 0;
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Location = new Point(236, 0);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(118, 76);
            buttonEditar.TabIndex = 3;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonMostrar
            // 
            buttonMostrar.AutoSize = true;
            buttonMostrar.Dock = DockStyle.Left;
            buttonMostrar.FlatAppearance.BorderSize = 0;
            buttonMostrar.FlatStyle = FlatStyle.Flat;
            buttonMostrar.Location = new Point(118, 0);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.Size = new Size(118, 76);
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
            buttonGuardar.Size = new Size(118, 76);
            buttonGuardar.TabIndex = 0;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 43);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 13;
            label1.Text = "Nombre Rol";
            // 
            // textBoxRol
            // 
            textBoxRol.Location = new Point(161, 36);
            textBoxRol.Name = "textBoxRol";
            textBoxRol.ReadOnly = true;
            textBoxRol.Size = new Size(164, 27);
            textBoxRol.TabIndex = 7;
            // 
            // groupBoxVistaRoles
            // 
            groupBoxVistaRoles.Controls.Add(dataGridViewRoles);
            groupBoxVistaRoles.Dock = DockStyle.Fill;
            groupBoxVistaRoles.Location = new Point(0, 0);
            groupBoxVistaRoles.Name = "groupBoxVistaRoles";
            groupBoxVistaRoles.Size = new Size(481, 428);
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
            dataGridViewRoles.Size = new Size(475, 402);
            dataGridViewRoles.TabIndex = 0;
            dataGridViewRoles.CellClick += dataGridViewRoles_CellClick;
            // 
            // FrmRegistrarRoles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 467);
            Controls.Add(panelClientes);
            Name = "FrmRegistrarRoles";
            Text = "Registrar roles";
            panelClientes.ResumeLayout(false);
            tabControlRegistrarRol.ResumeLayout(false);
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panelClientes;
        private TabControl tabControlRegistrarRol;
        private TabPage tabPageRegistrarUsuario;
        private SplitContainer splitContainer1;
        private GroupBox groupBoxRoles;
        private CheckBox checkBoxEstadoRol;
        private Panel panelMenu;
        private Button buttonEditar;
        private Button buttonMostrar;
        private Button buttonGuardar;
        private Label label1;
        private TextBox textBoxRol;
        private GroupBox groupBoxVistaRoles;
        private DataGridView dataGridViewRoles;
    }
}
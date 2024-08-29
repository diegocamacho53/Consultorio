namespace Consultorio.Formularios
{
    partial class PanelPrincipal
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
            components = new System.ComponentModel.Container();
            panelMenuLateral = new Panel();
            labelTiempoTranscurrido = new Label();
            labelUsuario = new Label();
            panelSubMenuConfiguracion = new Panel();
            buttonRegistrarUsuario = new Button();
            buttonRegistrarRol = new Button();
            buttonImpresora = new Button();
            buttonConfiguracion = new Button();
            buttonCerrarSesion = new Button();
            panelSubMenuFinanzas = new Panel();
            button5 = new Button();
            buttonVerFinanzas = new Button();
            buttonFinanzas = new Button();
            panelSubMenuCitas = new Panel();
            buttonBuscarCita = new Button();
            buttonRegistrarCita = new Button();
            buttonCitas = new Button();
            panelSubMenuPacientes = new Panel();
            buttonBuscarPacientes = new Button();
            buttonRegistro = new Button();
            buttonPacientes = new Button();
            panelLogo = new Panel();
            panelHijo = new Panel();
            pictureBoxLogo = new PictureBox();
            timerCronormetroSesion = new System.Windows.Forms.Timer(components);
            panelMenuLateral.SuspendLayout();
            panelSubMenuConfiguracion.SuspendLayout();
            panelSubMenuFinanzas.SuspendLayout();
            panelSubMenuCitas.SuspendLayout();
            panelSubMenuPacientes.SuspendLayout();
            panelHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.AutoScroll = true;
            panelMenuLateral.BackColor = Color.FromArgb(11, 7, 17);
            panelMenuLateral.Controls.Add(labelTiempoTranscurrido);
            panelMenuLateral.Controls.Add(labelUsuario);
            panelMenuLateral.Controls.Add(panelSubMenuConfiguracion);
            panelMenuLateral.Controls.Add(buttonConfiguracion);
            panelMenuLateral.Controls.Add(buttonCerrarSesion);
            panelMenuLateral.Controls.Add(panelSubMenuFinanzas);
            panelMenuLateral.Controls.Add(buttonFinanzas);
            panelMenuLateral.Controls.Add(panelSubMenuCitas);
            panelMenuLateral.Controls.Add(buttonCitas);
            panelMenuLateral.Controls.Add(panelSubMenuPacientes);
            panelMenuLateral.Controls.Add(buttonPacientes);
            panelMenuLateral.Controls.Add(panelLogo);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(250, 656);
            panelMenuLateral.TabIndex = 0;
            // 
            // labelTiempoTranscurrido
            // 
            labelTiempoTranscurrido.AutoSize = true;
            labelTiempoTranscurrido.Dock = DockStyle.Bottom;
            labelTiempoTranscurrido.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTiempoTranscurrido.ForeColor = Color.LightGray;
            labelTiempoTranscurrido.Location = new Point(0, 659);
            labelTiempoTranscurrido.Name = "labelTiempoTranscurrido";
            labelTiempoTranscurrido.Size = new Size(0, 21);
            labelTiempoTranscurrido.TabIndex = 10;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Dock = DockStyle.Bottom;
            labelUsuario.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.ForeColor = Color.LightGray;
            labelUsuario.Location = new Point(0, 680);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(95, 27);
            labelUsuario.TabIndex = 9;
            labelUsuario.Text = "Usuario";
            // 
            // panelSubMenuConfiguracion
            // 
            panelSubMenuConfiguracion.BackColor = Color.FromArgb(35, 32, 39);
            panelSubMenuConfiguracion.Controls.Add(buttonRegistrarUsuario);
            panelSubMenuConfiguracion.Controls.Add(buttonRegistrarRol);
            panelSubMenuConfiguracion.Controls.Add(buttonImpresora);
            panelSubMenuConfiguracion.Dock = DockStyle.Top;
            panelSubMenuConfiguracion.Location = new Point(0, 539);
            panelSubMenuConfiguracion.Name = "panelSubMenuConfiguracion";
            panelSubMenuConfiguracion.Size = new Size(229, 120);
            panelSubMenuConfiguracion.TabIndex = 8;
            // 
            // buttonRegistrarUsuario
            // 
            buttonRegistrarUsuario.Dock = DockStyle.Top;
            buttonRegistrarUsuario.FlatAppearance.BorderSize = 0;
            buttonRegistrarUsuario.FlatStyle = FlatStyle.Flat;
            buttonRegistrarUsuario.ForeColor = Color.Gainsboro;
            buttonRegistrarUsuario.Location = new Point(0, 80);
            buttonRegistrarUsuario.Name = "buttonRegistrarUsuario";
            buttonRegistrarUsuario.Padding = new Padding(35, 0, 0, 0);
            buttonRegistrarUsuario.Size = new Size(229, 40);
            buttonRegistrarUsuario.TabIndex = 3;
            buttonRegistrarUsuario.Text = "Registrar usuario";
            buttonRegistrarUsuario.TextAlign = ContentAlignment.MiddleLeft;
            buttonRegistrarUsuario.UseVisualStyleBackColor = true;
            buttonRegistrarUsuario.Click += buttonRegistrarUsuario_Click;
            // 
            // buttonRegistrarRol
            // 
            buttonRegistrarRol.Dock = DockStyle.Top;
            buttonRegistrarRol.FlatAppearance.BorderSize = 0;
            buttonRegistrarRol.FlatStyle = FlatStyle.Flat;
            buttonRegistrarRol.ForeColor = Color.Gainsboro;
            buttonRegistrarRol.Location = new Point(0, 40);
            buttonRegistrarRol.Name = "buttonRegistrarRol";
            buttonRegistrarRol.Padding = new Padding(35, 0, 0, 0);
            buttonRegistrarRol.Size = new Size(229, 40);
            buttonRegistrarRol.TabIndex = 2;
            buttonRegistrarRol.Text = "RegistrarRol";
            buttonRegistrarRol.TextAlign = ContentAlignment.MiddleLeft;
            buttonRegistrarRol.UseVisualStyleBackColor = true;
            buttonRegistrarRol.Click += buttonRegistrarRol_Click;
            // 
            // buttonImpresora
            // 
            buttonImpresora.Dock = DockStyle.Top;
            buttonImpresora.FlatAppearance.BorderSize = 0;
            buttonImpresora.FlatStyle = FlatStyle.Flat;
            buttonImpresora.ForeColor = Color.Gainsboro;
            buttonImpresora.Location = new Point(0, 0);
            buttonImpresora.Name = "buttonImpresora";
            buttonImpresora.Padding = new Padding(35, 0, 0, 0);
            buttonImpresora.Size = new Size(229, 40);
            buttonImpresora.TabIndex = 1;
            buttonImpresora.Text = "Impresora";
            buttonImpresora.TextAlign = ContentAlignment.MiddleLeft;
            buttonImpresora.UseVisualStyleBackColor = true;
            // 
            // buttonConfiguracion
            // 
            buttonConfiguracion.Dock = DockStyle.Top;
            buttonConfiguracion.FlatAppearance.BorderSize = 0;
            buttonConfiguracion.FlatStyle = FlatStyle.Flat;
            buttonConfiguracion.ForeColor = Color.Gainsboro;
            buttonConfiguracion.Location = new Point(0, 494);
            buttonConfiguracion.Name = "buttonConfiguracion";
            buttonConfiguracion.Padding = new Padding(10, 0, 0, 0);
            buttonConfiguracion.Size = new Size(229, 45);
            buttonConfiguracion.TabIndex = 7;
            buttonConfiguracion.Text = "Configuracion";
            buttonConfiguracion.TextAlign = ContentAlignment.MiddleLeft;
            buttonConfiguracion.UseVisualStyleBackColor = true;
            buttonConfiguracion.Click += buttonConfiguracion_Click;
            // 
            // buttonCerrarSesion
            // 
            buttonCerrarSesion.Dock = DockStyle.Bottom;
            buttonCerrarSesion.FlatAppearance.BorderSize = 0;
            buttonCerrarSesion.FlatStyle = FlatStyle.Flat;
            buttonCerrarSesion.ForeColor = Color.Gainsboro;
            buttonCerrarSesion.Location = new Point(0, 707);
            buttonCerrarSesion.Name = "buttonCerrarSesion";
            buttonCerrarSesion.Size = new Size(229, 45);
            buttonCerrarSesion.TabIndex = 6;
            buttonCerrarSesion.Text = "Cerrar sesion";
            buttonCerrarSesion.UseVisualStyleBackColor = true;
            buttonCerrarSesion.Click += buttonCerrarSesion_Click;
            // 
            // panelSubMenuFinanzas
            // 
            panelSubMenuFinanzas.BackColor = Color.FromArgb(35, 32, 39);
            panelSubMenuFinanzas.Controls.Add(button5);
            panelSubMenuFinanzas.Controls.Add(buttonVerFinanzas);
            panelSubMenuFinanzas.Dock = DockStyle.Top;
            panelSubMenuFinanzas.Location = new Point(0, 416);
            panelSubMenuFinanzas.Name = "panelSubMenuFinanzas";
            panelSubMenuFinanzas.Size = new Size(229, 78);
            panelSubMenuFinanzas.TabIndex = 5;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Gainsboro;
            button5.Location = new Point(0, 40);
            button5.Name = "button5";
            button5.Padding = new Padding(35, 0, 0, 0);
            button5.Size = new Size(229, 40);
            button5.TabIndex = 2;
            button5.Text = "Buscar paciente";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // buttonVerFinanzas
            // 
            buttonVerFinanzas.Dock = DockStyle.Top;
            buttonVerFinanzas.FlatAppearance.BorderSize = 0;
            buttonVerFinanzas.FlatStyle = FlatStyle.Flat;
            buttonVerFinanzas.ForeColor = Color.Gainsboro;
            buttonVerFinanzas.Location = new Point(0, 0);
            buttonVerFinanzas.Name = "buttonVerFinanzas";
            buttonVerFinanzas.Padding = new Padding(35, 0, 0, 0);
            buttonVerFinanzas.Size = new Size(229, 40);
            buttonVerFinanzas.TabIndex = 1;
            buttonVerFinanzas.Text = "Ver Finanzas";
            buttonVerFinanzas.TextAlign = ContentAlignment.MiddleLeft;
            buttonVerFinanzas.UseVisualStyleBackColor = true;
            buttonVerFinanzas.Click += buttonVerFinanzas_Click;
            // 
            // buttonFinanzas
            // 
            buttonFinanzas.Dock = DockStyle.Top;
            buttonFinanzas.FlatAppearance.BorderSize = 0;
            buttonFinanzas.FlatStyle = FlatStyle.Flat;
            buttonFinanzas.ForeColor = Color.Gainsboro;
            buttonFinanzas.Location = new Point(0, 371);
            buttonFinanzas.Name = "buttonFinanzas";
            buttonFinanzas.Padding = new Padding(10, 0, 0, 0);
            buttonFinanzas.Size = new Size(229, 45);
            buttonFinanzas.TabIndex = 4;
            buttonFinanzas.Text = "Finanzas";
            buttonFinanzas.TextAlign = ContentAlignment.MiddleLeft;
            buttonFinanzas.UseVisualStyleBackColor = true;
            buttonFinanzas.Click += buttonFinanzas_Click;
            // 
            // panelSubMenuCitas
            // 
            panelSubMenuCitas.BackColor = Color.FromArgb(35, 32, 39);
            panelSubMenuCitas.Controls.Add(buttonBuscarCita);
            panelSubMenuCitas.Controls.Add(buttonRegistrarCita);
            panelSubMenuCitas.Dock = DockStyle.Top;
            panelSubMenuCitas.Location = new Point(0, 293);
            panelSubMenuCitas.Name = "panelSubMenuCitas";
            panelSubMenuCitas.Size = new Size(229, 78);
            panelSubMenuCitas.TabIndex = 3;
            // 
            // buttonBuscarCita
            // 
            buttonBuscarCita.Dock = DockStyle.Top;
            buttonBuscarCita.FlatAppearance.BorderSize = 0;
            buttonBuscarCita.FlatStyle = FlatStyle.Flat;
            buttonBuscarCita.ForeColor = Color.Gainsboro;
            buttonBuscarCita.Location = new Point(0, 40);
            buttonBuscarCita.Name = "buttonBuscarCita";
            buttonBuscarCita.Padding = new Padding(35, 0, 0, 0);
            buttonBuscarCita.Size = new Size(229, 40);
            buttonBuscarCita.TabIndex = 2;
            buttonBuscarCita.Text = "Buscar Citas";
            buttonBuscarCita.TextAlign = ContentAlignment.MiddleLeft;
            buttonBuscarCita.UseVisualStyleBackColor = true;
            buttonBuscarCita.Click += buttonBuscarCita_Click;
            // 
            // buttonRegistrarCita
            // 
            buttonRegistrarCita.Dock = DockStyle.Top;
            buttonRegistrarCita.FlatAppearance.BorderSize = 0;
            buttonRegistrarCita.FlatStyle = FlatStyle.Flat;
            buttonRegistrarCita.ForeColor = Color.Gainsboro;
            buttonRegistrarCita.Location = new Point(0, 0);
            buttonRegistrarCita.Name = "buttonRegistrarCita";
            buttonRegistrarCita.Padding = new Padding(35, 0, 0, 0);
            buttonRegistrarCita.Size = new Size(229, 40);
            buttonRegistrarCita.TabIndex = 1;
            buttonRegistrarCita.Text = "Registrar Cita";
            buttonRegistrarCita.TextAlign = ContentAlignment.MiddleLeft;
            buttonRegistrarCita.UseVisualStyleBackColor = true;
            buttonRegistrarCita.Click += button3_Click;
            // 
            // buttonCitas
            // 
            buttonCitas.Dock = DockStyle.Top;
            buttonCitas.FlatAppearance.BorderSize = 0;
            buttonCitas.FlatStyle = FlatStyle.Flat;
            buttonCitas.ForeColor = Color.Gainsboro;
            buttonCitas.Location = new Point(0, 248);
            buttonCitas.Name = "buttonCitas";
            buttonCitas.Padding = new Padding(10, 0, 0, 0);
            buttonCitas.Size = new Size(229, 45);
            buttonCitas.TabIndex = 2;
            buttonCitas.Text = "Citas";
            buttonCitas.TextAlign = ContentAlignment.MiddleLeft;
            buttonCitas.UseVisualStyleBackColor = true;
            buttonCitas.Click += buttonCitas_Click;
            // 
            // panelSubMenuPacientes
            // 
            panelSubMenuPacientes.BackColor = Color.FromArgb(35, 32, 39);
            panelSubMenuPacientes.Controls.Add(buttonBuscarPacientes);
            panelSubMenuPacientes.Controls.Add(buttonRegistro);
            panelSubMenuPacientes.Dock = DockStyle.Top;
            panelSubMenuPacientes.Location = new Point(0, 170);
            panelSubMenuPacientes.Name = "panelSubMenuPacientes";
            panelSubMenuPacientes.Size = new Size(229, 78);
            panelSubMenuPacientes.TabIndex = 1;
            // 
            // buttonBuscarPacientes
            // 
            buttonBuscarPacientes.Dock = DockStyle.Top;
            buttonBuscarPacientes.FlatAppearance.BorderSize = 0;
            buttonBuscarPacientes.FlatStyle = FlatStyle.Flat;
            buttonBuscarPacientes.ForeColor = Color.Gainsboro;
            buttonBuscarPacientes.Location = new Point(0, 40);
            buttonBuscarPacientes.Name = "buttonBuscarPacientes";
            buttonBuscarPacientes.Padding = new Padding(35, 0, 0, 0);
            buttonBuscarPacientes.Size = new Size(229, 40);
            buttonBuscarPacientes.TabIndex = 2;
            buttonBuscarPacientes.Text = "Buscar paciente";
            buttonBuscarPacientes.TextAlign = ContentAlignment.MiddleLeft;
            buttonBuscarPacientes.UseVisualStyleBackColor = true;
            buttonBuscarPacientes.Click += buttonBuscarPacientes_Click;
            // 
            // buttonRegistro
            // 
            buttonRegistro.Dock = DockStyle.Top;
            buttonRegistro.FlatAppearance.BorderSize = 0;
            buttonRegistro.FlatStyle = FlatStyle.Flat;
            buttonRegistro.ForeColor = Color.Gainsboro;
            buttonRegistro.Location = new Point(0, 0);
            buttonRegistro.Name = "buttonRegistro";
            buttonRegistro.Padding = new Padding(35, 0, 0, 0);
            buttonRegistro.Size = new Size(229, 40);
            buttonRegistro.TabIndex = 1;
            buttonRegistro.Text = "Registro";
            buttonRegistro.TextAlign = ContentAlignment.MiddleLeft;
            buttonRegistro.UseVisualStyleBackColor = true;
            buttonRegistro.Click += buttonRegistro_Click;
            // 
            // buttonPacientes
            // 
            buttonPacientes.Dock = DockStyle.Top;
            buttonPacientes.FlatAppearance.BorderSize = 0;
            buttonPacientes.FlatStyle = FlatStyle.Flat;
            buttonPacientes.ForeColor = Color.Gainsboro;
            buttonPacientes.Location = new Point(0, 125);
            buttonPacientes.Name = "buttonPacientes";
            buttonPacientes.Padding = new Padding(10, 0, 0, 0);
            buttonPacientes.Size = new Size(229, 45);
            buttonPacientes.TabIndex = 1;
            buttonPacientes.Text = "Pacientes";
            buttonPacientes.TextAlign = ContentAlignment.MiddleLeft;
            buttonPacientes.UseVisualStyleBackColor = true;
            buttonPacientes.Click += buttonPacientes_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(229, 125);
            panelLogo.TabIndex = 1;
            // 
            // panelHijo
            // 
            panelHijo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelHijo.BackColor = Color.Transparent;
            panelHijo.Controls.Add(pictureBoxLogo);
            panelHijo.Location = new Point(250, 0);
            panelHijo.Name = "panelHijo";
            panelHijo.Size = new Size(903, 656);
            panelHijo.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxLogo.Image = Properties.Resources.images;
            pictureBoxLogo.Location = new Point(319, 195);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(266, 190);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // timerCronormetroSesion
            // 
            timerCronormetroSesion.Tick += timerCronormetroSesion_Tick;
            // 
            // PanelPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 656);
            Controls.Add(panelHijo);
            Controls.Add(panelMenuLateral);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(950, 600);
            Name = "PanelPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += PanelPrincipal_Load;
            panelMenuLateral.ResumeLayout(false);
            panelMenuLateral.PerformLayout();
            panelSubMenuConfiguracion.ResumeLayout(false);
            panelSubMenuFinanzas.ResumeLayout(false);
            panelSubMenuCitas.ResumeLayout(false);
            panelSubMenuPacientes.ResumeLayout(false);
            panelHijo.ResumeLayout(false);
            panelHijo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuLateral;
        private Panel panelSubMenuPacientes;
        private Button buttonPacientes;
        private Panel panelLogo;
        private Button buttonBuscarPacientes;
        private Button buttonRegistro;
        private Button buttonCitas;
        private Panel panelSubMenuFinanzas;
        private Button button5;
        private Button buttonVerFinanzas;
        private Button buttonFinanzas;
        private Panel panelSubMenuCitas;
        private Button buttonBuscarCita;
        private Button buttonRegistrarCita;
        private Button buttonCerrarSesion;
        private Panel panelSubMenuConfiguracion;
        private Button buttonRegistrarRol;
        private Button buttonImpresora;
        private Button buttonConfiguracion;
        private Panel panelHijo;
        private PictureBox pictureBoxLogo;
        private Button buttonRegistrarUsuario;
        private System.Windows.Forms.Timer timerCronormetroSesion;
        private Label labelTiempoTranscurrido;
        private Label labelUsuario;
    }
}
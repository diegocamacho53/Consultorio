namespace Consultorio.Formularios
{
    partial class Login
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
            panelLogin = new Panel();
            linkLabelOlvideMiContraseña = new LinkLabel();
            buttonCerrarSesion = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            checkBoxMostrarContraseña = new CheckBox();
            buttonLogin = new Button();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelLogin.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(15, 15, 15);
            panelLogin.Controls.Add(linkLabelOlvideMiContraseña);
            panelLogin.Controls.Add(buttonCerrarSesion);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(checkBoxMostrarContraseña);
            panelLogin.Controls.Add(buttonLogin);
            panelLogin.Controls.Add(txtContraseña);
            panelLogin.Controls.Add(txtUsuario);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(250, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(780, 371);
            panelLogin.TabIndex = 0;
            // 
            // linkLabelOlvideMiContraseña
            // 
            linkLabelOlvideMiContraseña.AutoSize = true;
            linkLabelOlvideMiContraseña.LinkColor = Color.Gainsboro;
            linkLabelOlvideMiContraseña.Location = new Point(312, 334);
            linkLabelOlvideMiContraseña.Name = "linkLabelOlvideMiContraseña";
            linkLabelOlvideMiContraseña.Size = new Size(178, 20);
            linkLabelOlvideMiContraseña.TabIndex = 8;
            linkLabelOlvideMiContraseña.TabStop = true;
            linkLabelOlvideMiContraseña.Text = "¿Olvidaste tu contraseña?";
            linkLabelOlvideMiContraseña.Click += linkLabelOlvideMiContraseña_Click;
            // 
            // buttonCerrarSesion
            // 
            buttonCerrarSesion.BackColor = Color.FromArgb(40, 40, 40);
            buttonCerrarSesion.FlatAppearance.BorderSize = 0;
            buttonCerrarSesion.FlatStyle = FlatStyle.Flat;
            buttonCerrarSesion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCerrarSesion.Location = new Point(714, 0);
            buttonCerrarSesion.Name = "buttonCerrarSesion";
            buttonCerrarSesion.Size = new Size(66, 29);
            buttonCerrarSesion.TabIndex = 7;
            buttonCerrarSesion.Text = "X";
            buttonCerrarSesion.UseVisualStyleBackColor = false;
            buttonCerrarSesion.Click += buttonCerrarSesion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(355, 23);
            label3.Name = "label3";
            label3.Size = new Size(96, 37);
            label3.TabIndex = 6;
            label3.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(74, 184);
            label2.Name = "label2";
            label2.Size = new Size(627, 20);
            label2.TabIndex = 5;
            label2.Text = "_______________________________________________________________________________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(74, 115);
            label1.Name = "label1";
            label1.Size = new Size(627, 20);
            label1.TabIndex = 4;
            label1.Text = "_______________________________________________________________________________________________________";
            // 
            // checkBoxMostrarContraseña
            // 
            checkBoxMostrarContraseña.AutoSize = true;
            checkBoxMostrarContraseña.BackColor = Color.FromArgb(15, 15, 15);
            checkBoxMostrarContraseña.ForeColor = Color.DarkGray;
            checkBoxMostrarContraseña.Location = new Point(543, 230);
            checkBoxMostrarContraseña.Name = "checkBoxMostrarContraseña";
            checkBoxMostrarContraseña.Size = new Size(158, 24);
            checkBoxMostrarContraseña.TabIndex = 3;
            checkBoxMostrarContraseña.Text = "Mostrar contraseña";
            checkBoxMostrarContraseña.UseVisualStyleBackColor = false;
            checkBoxMostrarContraseña.CheckedChanged += checkBoxMostrarContraseña_CheckedChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.AutoSize = true;
            buttonLogin.BackColor = Color.FromArgb(40, 40, 40);
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            buttonLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.LightGray;
            buttonLogin.Location = new Point(197, 269);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(408, 40);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Iniciar sesion";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            buttonLogin.KeyDown += buttonLogin_KeyDown;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(15, 15, 15);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = Color.LightGray;
            txtContraseña.Location = new Point(77, 161);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "Contraseña";
            txtContraseña.Size = new Size(621, 25);
            txtContraseña.TabIndex = 1;
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.KeyDown += txtContraseña_KeyDown;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.LightGray;
            txtUsuario.Location = new Point(77, 87);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(621, 25);
            txtUsuario.TabIndex = 0;
            txtUsuario.KeyDown += txtUsuario_KeyDown;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(0, 122, 204);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Left;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 371);
            panelLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_inicio_sesión_50;
            pictureBox1.Location = new Point(59, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 371);
            Controls.Add(panelLogin);
            Controls.Add(panelLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Button buttonLogin;
        private CheckBox checkBoxMostrarContraseña;
        private Panel panelLogo;
        private Label label2;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private Button buttonCerrarSesion;
        private LinkLabel linkLabelOlvideMiContraseña;
    }
}
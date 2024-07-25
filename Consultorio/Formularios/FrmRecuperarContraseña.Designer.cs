namespace Consultorio.Formularios
{
    partial class FrmRecuperarContraseña
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
            panelRecuperarContraseña = new Panel();
            textBoxUsuario = new TextBox();
            textBoxRespuestaSecreta = new TextBox();
            labelPreguntaSecreta = new Label();
            textBoxConfirmarContraseña = new TextBox();
            buttonCancelar = new Button();
            buttonAceptar = new Button();
            textBoxNuevaContraseña = new TextBox();
            panelRecuperarContraseña.SuspendLayout();
            SuspendLayout();
            // 
            // panelRecuperarContraseña
            // 
            panelRecuperarContraseña.Controls.Add(textBoxUsuario);
            panelRecuperarContraseña.Controls.Add(textBoxRespuestaSecreta);
            panelRecuperarContraseña.Controls.Add(labelPreguntaSecreta);
            panelRecuperarContraseña.Controls.Add(textBoxConfirmarContraseña);
            panelRecuperarContraseña.Controls.Add(buttonCancelar);
            panelRecuperarContraseña.Controls.Add(buttonAceptar);
            panelRecuperarContraseña.Controls.Add(textBoxNuevaContraseña);
            panelRecuperarContraseña.Dock = DockStyle.Fill;
            panelRecuperarContraseña.Location = new Point(0, 0);
            panelRecuperarContraseña.Name = "panelRecuperarContraseña";
            panelRecuperarContraseña.Size = new Size(455, 426);
            panelRecuperarContraseña.TabIndex = 0;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(122, 161);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Ingrese su usuario";
            textBoxUsuario.Size = new Size(190, 27);
            textBoxUsuario.TabIndex = 6;
            textBoxUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxRespuestaSecreta
            // 
            textBoxRespuestaSecreta.Location = new Point(109, 107);
            textBoxRespuestaSecreta.Name = "textBoxRespuestaSecreta";
            textBoxRespuestaSecreta.PlaceholderText = "Ingrese su respuesta secreta";
            textBoxRespuestaSecreta.Size = new Size(217, 27);
            textBoxRespuestaSecreta.TabIndex = 5;
            textBoxRespuestaSecreta.TextAlign = HorizontalAlignment.Center;
            // 
            // labelPreguntaSecreta
            // 
            labelPreguntaSecreta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelPreguntaSecreta.AutoSize = true;
            labelPreguntaSecreta.Location = new Point(47, 35);
            labelPreguntaSecreta.Name = "labelPreguntaSecreta";
            labelPreguntaSecreta.Size = new Size(119, 20);
            labelPreguntaSecreta.TabIndex = 4;
            labelPreguntaSecreta.Text = "Pregunta secreta";
            // 
            // textBoxConfirmarContraseña
            // 
            textBoxConfirmarContraseña.Location = new Point(122, 256);
            textBoxConfirmarContraseña.Name = "textBoxConfirmarContraseña";
            textBoxConfirmarContraseña.PasswordChar = '*';
            textBoxConfirmarContraseña.PlaceholderText = "Confirmar contraseña";
            textBoxConfirmarContraseña.Size = new Size(190, 27);
            textBoxConfirmarContraseña.TabIndex = 3;
            textBoxConfirmarContraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonCancelar
            // 
            buttonCancelar.AutoSize = true;
            buttonCancelar.Location = new Point(253, 336);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 30);
            buttonCancelar.TabIndex = 2;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAceptar
            // 
            buttonAceptar.AutoSize = true;
            buttonAceptar.Location = new Point(95, 336);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(94, 30);
            buttonAceptar.TabIndex = 1;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // textBoxNuevaContraseña
            // 
            textBoxNuevaContraseña.Location = new Point(122, 206);
            textBoxNuevaContraseña.Name = "textBoxNuevaContraseña";
            textBoxNuevaContraseña.PasswordChar = '*';
            textBoxNuevaContraseña.PlaceholderText = "Contraseña";
            textBoxNuevaContraseña.Size = new Size(190, 27);
            textBoxNuevaContraseña.TabIndex = 0;
            textBoxNuevaContraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmRecuperarContraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 426);
            Controls.Add(panelRecuperarContraseña);
            Name = "FrmRecuperarContraseña";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recuperar contraseña";
            panelRecuperarContraseña.ResumeLayout(false);
            panelRecuperarContraseña.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRecuperarContraseña;
        private TextBox textBoxRespuestaSecreta;
        private Label labelPreguntaSecreta;
        private TextBox textBoxConfirmarContraseña;
        private Button buttonCancelar;
        private Button buttonAceptar;
        private TextBox textBoxNuevaContraseña;
        private TextBox textBoxUsuario;
    }
}
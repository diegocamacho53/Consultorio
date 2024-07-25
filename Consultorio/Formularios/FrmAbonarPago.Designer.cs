namespace Consultorio.Formularios
{
    partial class FrmAbonarPago
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
            panelAbonarPago = new Panel();
            buttonCancelar = new Button();
            buttonAceptar = new Button();
            textBoxAbonarValor = new TextBox();
            panelAbonarPago.SuspendLayout();
            SuspendLayout();
            // 
            // panelAbonarPago
            // 
            panelAbonarPago.Controls.Add(buttonCancelar);
            panelAbonarPago.Controls.Add(buttonAceptar);
            panelAbonarPago.Controls.Add(textBoxAbonarValor);
            panelAbonarPago.Dock = DockStyle.Fill;
            panelAbonarPago.Location = new Point(0, 0);
            panelAbonarPago.Name = "panelAbonarPago";
            panelAbonarPago.Size = new Size(510, 255);
            panelAbonarPago.TabIndex = 0;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCancelar.Location = new Point(301, 155);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 2;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAceptar.Location = new Point(101, 155);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(94, 29);
            buttonAceptar.TabIndex = 1;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // textBoxAbonarValor
            // 
            textBoxAbonarValor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAbonarValor.Location = new Point(101, 70);
            textBoxAbonarValor.Name = "textBoxAbonarValor";
            textBoxAbonarValor.Size = new Size(294, 27);
            textBoxAbonarValor.TabIndex = 0;
            // 
            // FrmAbonarPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 255);
            Controls.Add(panelAbonarPago);
            Name = "FrmAbonarPago";
            Text = "Abonar pago";
            panelAbonarPago.ResumeLayout(false);
            panelAbonarPago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAbonarPago;
        private Button buttonCancelar;
        private Button buttonAceptar;
        private TextBox textBoxAbonarValor;
    }
}
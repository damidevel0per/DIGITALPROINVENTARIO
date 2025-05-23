namespace CapaDePresentacion
{
    partial class DatosProducto
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
            imagenURL = new PictureBox();
            lblNombreProducto = new Label();
            txtDetalleProducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)imagenURL).BeginInit();
            SuspendLayout();
            // 
            // imagenURL
            // 
            imagenURL.BackColor = Color.FromArgb(21, 27, 41);
            imagenURL.BackgroundImageLayout = ImageLayout.Stretch;
            imagenURL.Image = Properties.Resources.imagendefault;
            imagenURL.InitialImage = Properties.Resources.imagendefault;
            imagenURL.Location = new Point(52, 126);
            imagenURL.Name = "imagenURL";
            imagenURL.Size = new Size(450, 450);
            imagenURL.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenURL.TabIndex = 27;
            imagenURL.TabStop = false;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.BackColor = Color.FromArgb(21, 27, 41);
            lblNombreProducto.Font = new Font("Stretch Pro", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreProducto.ForeColor = Color.FromArgb(216, 184, 217);
            lblNombreProducto.Location = new Point(52, 40);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(165, 50);
            lblNombreProducto.TabIndex = 28;
            lblNombreProducto.Text = "label1";
            lblNombreProducto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDetalleProducto
            // 
            txtDetalleProducto.BackColor = Color.FromArgb(21, 27, 41);
            txtDetalleProducto.BorderStyle = BorderStyle.None;
            txtDetalleProducto.Font = new Font("Swis721 Blk BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDetalleProducto.ForeColor = Color.FromArgb(216, 184, 217);
            txtDetalleProducto.Location = new Point(572, 126);
            txtDetalleProducto.Multiline = true;
            txtDetalleProducto.Name = "txtDetalleProducto";
            txtDetalleProducto.ReadOnly = true;
            txtDetalleProducto.Size = new Size(639, 450);
            txtDetalleProducto.TabIndex = 29;
            txtDetalleProducto.TabStop = false;
            // 
            // DatosProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(94, 97, 118);
            ClientSize = new Size(1264, 635);
            Controls.Add(txtDetalleProducto);
            Controls.Add(lblNombreProducto);
            Controls.Add(imagenURL);
            Name = "DatosProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos del producto";
            ((System.ComponentModel.ISupportInitialize)imagenURL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox imagenURL;
        public Label lblNombreProducto;
        public TextBox txtDetalleProducto;
    }
}
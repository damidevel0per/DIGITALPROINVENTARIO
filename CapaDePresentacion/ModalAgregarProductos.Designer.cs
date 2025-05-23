namespace CapaDePresentacion
{
    partial class ModalAgregarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalAgregarProductos));
            txtStock = new TextBox();
            label6 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            txtMarca = new TextBox();
            label4 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            panel1 = new Panel();
            txtURLIMAGEN = new TextBox();
            label7 = new Label();
            imagenURL = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenURL).BeginInit();
            SuspendLayout();
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            txtStock.ForeColor = Color.FromArgb(21, 27, 41);
            txtStock.Location = new Point(220, 319);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(160, 26);
            txtStock.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stretch Pro", 11.2499981F);
            label6.ForeColor = Color.FromArgb(216, 184, 217);
            label6.Location = new Point(142, 323);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 20;
            label6.Text = "Stock";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            txtPrecio.ForeColor = Color.FromArgb(21, 27, 41);
            txtPrecio.Location = new Point(220, 269);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 26);
            txtPrecio.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stretch Pro", 11.2499981F);
            label5.ForeColor = Color.FromArgb(216, 184, 217);
            label5.Location = new Point(132, 273);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 18;
            label5.Text = "Precio";
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            txtMarca.ForeColor = Color.FromArgb(21, 27, 41);
            txtMarca.Location = new Point(220, 219);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(265, 26);
            txtMarca.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stretch Pro", 11.2499981F);
            label4.ForeColor = Color.FromArgb(216, 184, 217);
            label4.Location = new Point(136, 223);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 16;
            label4.Text = "Marca";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            txtDescripcion.ForeColor = Color.FromArgb(21, 27, 41);
            txtDescripcion.Location = new Point(220, 164);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(470, 26);
            txtDescripcion.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stretch Pro", 11.2499981F);
            label3.ForeColor = Color.FromArgb(216, 184, 217);
            label3.Location = new Point(72, 168);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 14;
            label3.Text = "Descripcion";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            txtNombre.ForeColor = Color.FromArgb(21, 27, 41);
            txtNombre.Location = new Point(220, 111);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(360, 26);
            txtNombre.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stretch Pro", 11.2499981F);
            label2.ForeColor = Color.FromArgb(216, 184, 217);
            label2.Location = new Point(115, 115);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 12;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stretch Pro", 20.2499962F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(216, 184, 217);
            label1.Location = new Point(132, 45);
            label1.Name = "label1";
            label1.Size = new Size(491, 37);
            label1.TabIndex = 22;
            label1.Text = "Daaatos del producto";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(21, 27, 41);
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Font = new Font("Stretch Pro", 14.25F);
            btnAceptar.ForeColor = Color.FromArgb(216, 184, 217);
            btnAceptar.Image = (Image)resources.GetObject("btnAceptar.Image");
            btnAceptar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAceptar.Location = new Point(30, 486);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Padding = new Padding(20, 0, 0, 0);
            btnAceptar.Size = new Size(361, 64);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(21, 27, 41);
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Stretch Pro", 14.25F);
            btnCancelar.ForeColor = Color.FromArgb(216, 184, 217);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(429, 486);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(20, 0, 0, 0);
            btnCancelar.Size = new Size(361, 64);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 27, 41);
            panel1.Controls.Add(txtURLIMAGEN);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtStock);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(txtMarca);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(30, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 442);
            panel1.TabIndex = 25;
            // 
            // txtURLIMAGEN
            // 
            txtURLIMAGEN.Location = new Point(220, 369);
            txtURLIMAGEN.Name = "txtURLIMAGEN";
            txtURLIMAGEN.Size = new Size(380, 23);
            txtURLIMAGEN.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stretch Pro", 11.2499981F);
            label7.ForeColor = Color.FromArgb(216, 184, 217);
            label7.Location = new Point(72, 372);
            label7.Name = "label7";
            label7.Size = new Size(139, 20);
            label7.TabIndex = 23;
            label7.Text = "URL imagen";
            // 
            // imagenURL
            // 
            imagenURL.BackColor = Color.FromArgb(21, 27, 41);
            imagenURL.BackgroundImageLayout = ImageLayout.Stretch;
            imagenURL.Image = Properties.Resources.imagendefault;
            imagenURL.InitialImage = Properties.Resources.imagendefault;
            imagenURL.Location = new Point(872, 56);
            imagenURL.Name = "imagenURL";
            imagenURL.Size = new Size(450, 450);
            imagenURL.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenURL.TabIndex = 26;
            imagenURL.TabStop = false;
            // 
            // ModalAgregarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(94, 97, 118);
            ClientSize = new Size(1375, 576);
            Controls.Add(imagenURL);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "ModalAgregarProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario producto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagenURL).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAceptar;
        private Button btnCancelar;
        public TextBox txtStock;
        public TextBox txtPrecio;
        public TextBox txtMarca;
        public TextBox txtDescripcion;
        public TextBox txtNombre;
        private Panel panel1;
        private Label label7;
        public PictureBox imagenURL;
        public TextBox txtURLIMAGEN;
        private PictureBox pictureBox1;
    }
}
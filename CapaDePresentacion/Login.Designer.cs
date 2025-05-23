namespace CapaDePresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            Usuario = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(52, 204);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 122);
            panel1.TabIndex = 0;
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.BackColor = Color.FromArgb(21, 27, 41);
            Usuario.Font = new Font("Stretch Pro", 12F);
            Usuario.ForeColor = Color.FromArgb(94, 97, 118);
            Usuario.Location = new Point(44, 297);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(100, 22);
            Usuario.TabIndex = 1;
            Usuario.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(21, 27, 41);
            label2.Font = new Font("Stretch Pro", 12F);
            label2.ForeColor = Color.FromArgb(94, 97, 118);
            label2.Location = new Point(69, 352);
            label2.Name = "label2";
            label2.Size = new Size(75, 22);
            label2.TabIndex = 2;
            label2.Text = "Clave";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Stretch Pro", 12F);
            txtUsuario.Location = new Point(150, 294);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(211, 29);
            txtUsuario.TabIndex = 3;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Stretch Pro", 12F);
            txtClave.Location = new Point(150, 349);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(211, 29);
            txtClave.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(94, 97, 118);
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Stretch Pro", 12F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(44, 452);
            button1.Name = "button1";
            button1.Size = new Size(340, 43);
            button1.TabIndex = 5;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(21, 27, 41);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(Usuario);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtClave);
            panel2.Controls.Add(txtUsuario);
            panel2.Location = new Point(568, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(435, 545);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(126, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(176, 153);
            panel3.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(94, 97, 118);
            ClientSize = new Size(999, 542);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = Color.Coral;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesión";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Usuario;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Panel panel2;
        public Button button1;
        private Panel panel3;
    }
}
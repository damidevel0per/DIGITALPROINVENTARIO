namespace CapaDePresentacion
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnRegistrarProducto = new Button();
            button1 = new Button();
            btnEditarProducto = new Button();
            panel1 = new Panel();
            btnEliminarProducto = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            btnSalir = new Button();
            button2 = new Button();
            panelContenedor = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(21, 27, 41);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(21, 27, 41);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(216, 184, 217);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(21, 27, 41);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(216, 184, 217);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(21, 27, 41);
            dataGridView1.Location = new Point(20, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(216, 184, 217);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(21, 27, 41);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(94, 97, 118);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(216, 184, 217);
            dataGridViewCellStyle4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(21, 27, 41);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(94, 97, 118);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1255, 429);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stretch Pro", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(426, 33);
            label1.Name = "label1";
            label1.Size = new Size(429, 37);
            label1.TabIndex = 1;
            label1.Text = "SSSTOCK ACTUAL";
            // 
            // btnRegistrarProducto
            // 
            btnRegistrarProducto.BackColor = Color.FromArgb(216, 184, 217);
            btnRegistrarProducto.FlatStyle = FlatStyle.Popup;
            btnRegistrarProducto.Font = new Font("Stretch Pro", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarProducto.ForeColor = Color.Black;
            btnRegistrarProducto.Image = (Image)resources.GetObject("btnRegistrarProducto.Image");
            btnRegistrarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarProducto.Location = new Point(1324, 368);
            btnRegistrarProducto.Name = "btnRegistrarProducto";
            btnRegistrarProducto.Padding = new Padding(20, 0, 0, 0);
            btnRegistrarProducto.RightToLeft = RightToLeft.No;
            btnRegistrarProducto.Size = new Size(364, 81);
            btnRegistrarProducto.TabIndex = 2;
            btnRegistrarProducto.Text = "Registrar producto";
            btnRegistrarProducto.UseVisualStyleBackColor = false;
            btnRegistrarProducto.Click += btnRegistrarProducto_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(21, 27, 41);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Stretch Pro", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(216, 184, 217);
            button1.Location = new Point(20, 544);
            button1.Name = "button1";
            button1.Size = new Size(1255, 48);
            button1.TabIndex = 3;
            button1.Text = "Listar productos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.BackColor = Color.FromArgb(216, 184, 217);
            btnEditarProducto.FlatStyle = FlatStyle.Popup;
            btnEditarProducto.Font = new Font("Stretch Pro", 12F);
            btnEditarProducto.Image = (Image)resources.GetObject("btnEditarProducto.Image");
            btnEditarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarProducto.Location = new Point(1324, 455);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Padding = new Padding(20, 0, 0, 0);
            btnEditarProducto.Size = new Size(364, 81);
            btnEditarProducto.TabIndex = 4;
            btnEditarProducto.Text = "Editar producto";
            btnEditarProducto.UseVisualStyleBackColor = false;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(94, 97, 118);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(1295, 611);
            panel1.TabIndex = 5;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.FromArgb(216, 184, 217);
            btnEliminarProducto.FlatStyle = FlatStyle.Popup;
            btnEliminarProducto.Font = new Font("Stretch Pro", 12F);
            btnEliminarProducto.Image = (Image)resources.GetObject("btnEliminarProducto.Image");
            btnEliminarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarProducto.Location = new Point(1324, 542);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Padding = new Padding(20, 0, 0, 0);
            btnEliminarProducto.Size = new Size(364, 81);
            btnEliminarProducto.TabIndex = 6;
            btnEliminarProducto.Text = "Eliminar producto";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(94, 97, 118);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(17, 58);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 0, 10, 10);
            panel2.Size = new Size(321, 90);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(94, 97, 118);
            panel3.Controls.Add(btnSalir);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(1324, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(364, 262);
            panel3.TabIndex = 8;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(21, 27, 41);
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Stretch Pro", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.FromArgb(216, 184, 217);
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(17, 199);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(20, 0, 0, 0);
            btnSalir.RightToLeft = RightToLeft.No;
            btnSalir.Size = new Size(331, 42);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(216, 184, 217);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Stretch Pro", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1324, 281);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(364, 81);
            button2.TabIndex = 9;
            button2.Text = "Mostrar datos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(panel1);
            panelContenedor.Controls.Add(button2);
            panelContenedor.Controls.Add(btnRegistrarProducto);
            panelContenedor.Controls.Add(panel3);
            panelContenedor.Controls.Add(btnEditarProducto);
            panelContenedor.Controls.Add(btnEliminarProducto);
            panelContenedor.Location = new Point(12, 12);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1701, 639);
            panelContenedor.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 27, 41);
            ClientSize = new Size(1726, 690);
            Controls.Add(panelContenedor);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Digital Pro Inventario";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panelContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnRegistrarProducto;
        private Button button1;
        private Button btnEditarProducto;
        private Panel panel1;
        private Button btnEliminarProducto;
        private Panel panel2;
        private Panel panel3;
        private Button btnSalir;
        private Button button2;
        private Panel panelContenedor;
    }
}

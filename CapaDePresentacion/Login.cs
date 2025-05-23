using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        CN_Usuarios objetoLogin = new CN_Usuarios();

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.ToString();

            string clave = txtClave.Text.ToString();
            txtUsuario.Text = "";
            txtClave.Text = "";
            if (objetoLogin.LoginUsuario(usuario, clave))
            {
                MessageBox.Show("Inicio de sesión exitoso!");
                this.DialogResult = DialogResult.OK;

            }
            else { MessageBox.Show("Credenciales incorrectas"); }
        }
    }
}

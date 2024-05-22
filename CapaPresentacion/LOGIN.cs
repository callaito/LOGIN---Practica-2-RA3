using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            if (textUsuario.Text == "Usuario")
            {
                textUsuario.Text = "";
                textUsuario.ForeColor = Color.Goldenrod;
            }
        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if (textUsuario.Text == "")
            {
                textUsuario.Text = "Usuario";
                textUsuario.ForeColor = Color.DimGray;

            }
        }

        private void textContraseña_Enter(object sender, EventArgs e)
        {
            if (textContraseña.Text == "Contraseña")
            {
                textContraseña.Text = "";
                textContraseña.ForeColor = Color.LightGray;
                textContraseña.UseSystemPasswordChar = true;
            }
        }

        private void textContraseña_Leave(object sender, EventArgs e)
        {
            if (textContraseña.Text == "")
            {
                textContraseña.Text = "Contraseña";
                textContraseña.ForeColor = Color.DimGray;
                textContraseña.UseSystemPasswordChar = false;
            }
        }

        private void BTNInicia_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text != "Usuario")
            {
                if (textContraseña.Text != "Contraseña")
                {
                     Usuario = new User();
                    var validLogin = Usuario.LoginUser(textUsuario.Text, textContraseña.Text);
                    if (validLogin)
                    {
                        MENUPRINCIPAL MENUPRINCIPAL = new MENUPRINCIPAL();
                        MENUPRINCIPAL.Show();
                        this.Hide();

                    }
                    else
                    {
                        msError("Usuario o contraseña incorrecta ");
                        textContraseña.Clear();
                        textUsuario.Focus();

                    }
                }

                else msError("please enter passoword");
            }
            else msError("please enter username ");
        }

        private void msError(string msg)
        {
            lblErrorMensaje.Text = "" + msg;
            lblErrorMensaje.Visible = true;
        }
    }
}

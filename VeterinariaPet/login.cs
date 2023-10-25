using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaPet
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            // Configura la propiedad PasswordChar para el txtboxpassword
            txtbox_pass.PasswordChar = '*'; // Puedes usar otro carácter si lo prefieres
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void txtbox_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtboxx_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            {
                // Verifica los datos de usuario y contraseña (reemplaza esto con tu lógica de verificación).
                string usuario = txtbox_usuario.Text;
                string contrasena = txtbox_pass.Text;

                if (usuario == "admin" && contrasena == "123")
                {
                    // Los datos son correctos, así que puedes abrir el formulario principal.
                    Form11 formulario = new Form11();
                    formulario.Show();

                    // Opcionalmente, puedes ocultar el formulario de inicio de sesión si ya no es necesario.
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtalo de nuevo.");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

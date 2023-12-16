using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Hall
{
    public partial class frmlogin : Form // Clase del formulario de inicio de sesión (login)
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void cancelarbtn_Click(object sender, EventArgs e) // Manejador del evento de clic en el botón de cancelar
        {
            this.Dispose();
        }

        private void loginbtn_Click(object sender, EventArgs e) // Manejador del evento de clic en el botón de inicio de sesión
        {
            // Verificar si el nombre de usuario y la contraseña son correc
            if (usuariotxt.Text == "michael" && maskedcon.Text == "123456")
            {
                DialogResult = DialogResult.OK; // Establecer DialogResult en OK
                Close(); // cierre del formulario de inicio de sesion

            }
            
            else
            {// Mostrar mensajes de error según la situación
                if (usuariotxt.Text != "michael" && maskedcon.Text != "123456")
                {
                    MessageBox.Show("El usuario y la contraseña son incorrectas");
                }
                else if (usuariotxt.Text != "michael")
                {
                    MessageBox.Show("El usuario es incorrecto");
                }
                else if (maskedcon.Text != "123456")
                {
                    MessageBox.Show("La contraseña es incorrecta");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

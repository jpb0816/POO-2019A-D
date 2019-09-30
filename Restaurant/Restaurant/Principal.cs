using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            string user = UserTextBox.Text;
            string password = PasswordTexBox.Text;

            User usuario = GetUsuario();

            if (user==usuario.UserName&&password==usuario.Password)
            {
                MessageBox.Show("Hola Bienvenido "+usuario.Name);
            }
            else
            {
                MessageBox.Show("Contraseña o Username Invalido");
            }
        }

        public User GetUsuario()
        {
            User u = new User();
            u.Id = 1;
            u.Name = "Juan Hernandez";
            u.UserName = "Admin";
            u.Password = "del1al6";

            return u;
        }
    }
}

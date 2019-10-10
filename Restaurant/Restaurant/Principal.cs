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
        User u;
        
        public Principal()
        {
             u=GetUsuario();


            InitializeComponent();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            string user = UserTextBox.Text;
            string password = PasswordTexBox.Text;

            DashBoard d = new DashBoard(u);

            if (user==u.UserName&&password==u.Password)
            {
                d.Show();
               
            }
            else
            {
                
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

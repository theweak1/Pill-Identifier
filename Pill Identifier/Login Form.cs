using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pill_Identifier
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            
            if (userName_value.Text != "user" && password_value.Text != "password")
            {
                MessageBox.Show("username or password is incorrect...");
            }
            else
            {
                this.Hide();
                menuForm Menu = new menuForm();
                Menu.ShowDialog();
               
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            userName_value.Clear();
            password_value.Clear();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register NewUser = new Register();
            NewUser.ShowDialog();
        }
    }
}
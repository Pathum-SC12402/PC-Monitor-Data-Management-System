using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            passwordInput.PasswordChar = '•';
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameInput.Text == "admin" && passwordInput.Text == "admin123")
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else if(usernameInput.Text == "")
            {
                MessageBox.Show("Please Enter Username.");
            }
            else if(passwordInput.Text == "")
            {
                MessageBox.Show("Please Enter Password.");
            }
            else
            {
                MessageBox.Show("Please Enter Correct information");
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameInput.Text = "";
            passwordInput.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalNotes
{
    public partial class Login : Form
    {
        List<User> users = Repository.getUsers();

        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = LogUsernameBox.Text;
            string password = LogPasswordBox.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                var popup = MessageBox.Show("Username or password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var user in users)
            {
                if (user.Name == username)
                {
                    if (user.Password == password)
                    {
                        MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK);
                        GoToMainForm();
                    }
                    else
                    {
                        MessageBox.Show("Password is incorrect!", "Login Failed", MessageBoxButtons.OK);
                    }
                    return;
                }
            }

            var result = MessageBox.Show("User not found. Do you want to register?", "Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                GoToRegisterForm();
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            GoToRegisterForm();
        }

        private void GoToRegisterForm()
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            LogUsernameBox.Text = "";
            LogPasswordBox.Text = "";
            this.Show();
        }

        private void GoToMainForm()
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            LogUsernameBox.Text = "";
            LogPasswordBox.Text = "";
            this.Show();
        }
    }
}

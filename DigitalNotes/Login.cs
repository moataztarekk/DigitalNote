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
        List<User> users = Repositry.getUsers();
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = LogUsernameBox.Text;
            string password = LogPasswordBox.Text;
            bool findUser = false;
            foreach (var user in users)
            {
                if (user.Name == username)
                {
                    if (user.Password == password)
                    {
                        MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK);
                        Form1 form = new Form1();
                        form.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Password is incorrect!", "Login Failed", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            var result = MessageBox.Show("User not found. Do you want to register?", "Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Register register = new Register();
                register.Show();
                this.Hide();
            }

        }

    }
}

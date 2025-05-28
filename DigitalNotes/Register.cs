using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalNotes
{
    public partial class Register : Form
    {
        List<User> users = Repositry.getUsers();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void openLoginForm()
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }
        private void registerBtn_Click(object sender, EventArgs e)
        {
            string username = regUsernameBox.Text;
            string password = regPasswordBox.Text;

            foreach (var myuser in users)
            {
                if(myuser.Name == username)
                {
                    var result = MessageBox.Show("User is already registered. Do you want to login?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                       openLoginForm();
                        return;
                    }
                }
                    
            }
            User user = new User() { Name = username, Password = password };
            MessageBox.Show("You entered: " + username);
            MessageBox.Show("You entered: " + password);
            Repositry.addUser(user);
            openLoginForm();
            
        }

        private void regUsernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using DigitalNotes.Data;
using DigitalNotes.Models;
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
        public DigitalNoteDbContext db { get; set; }

        public Register()
        {
            this.db = new DigitalNoteDbContext();
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string username = regUsernameBox.Text;
            string password = regPasswordBox.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                var popup = MessageBox.Show("Username or password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var myuser in db.Users)
            {
                if (myuser.UserName == username)
                {
                    var result = MessageBox.Show("User is already registered. Do you want to login?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    return;
                }
            }

            User user = new User() { UserName = username, Password = password };
            MessageBox.Show("You entered: " + username);
            MessageBox.Show("You entered: " + password);
            db.Add(user);
            db.SaveChanges();
            this.Close();
        }
    }
}

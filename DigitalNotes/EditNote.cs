using DigitalNotes.Data;
using DigitalNotes.Models;
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
    public partial class EditNote : Form
    {
        Note NoteToEdit;

        public EditNote(Note note)
        {
            InitializeComponent();

            this.NoteToEdit = note;
            this.TitleTextBox.Text = this.NoteToEdit.Title;
            this.categorySelectorv11.LoadCategories();

            //this.categorySelectorv11.CategorySelected = this.NoteToEdit.Category;
            this.ReminderEnable.Checked = true ? this.NoteToEdit.ReminderDate != null : false;
            this.dateTimePicker1.Enabled = this.ReminderEnable.Checked;
        }

        private void ReminderEnable_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Enabled = this.ReminderEnable.Checked;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (this.TitleTextBox.Text == "")
            {
                var popup = MessageBox.Show("Title cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //this.NoteToEdit.Title = this.TitleTextBox.Text;
            //this.NoteToEdit.Category = categorySelectorv11.CategorySelected;
            //if (!Repository.Categories.Contains(categorySelectorv11.CategorySelected))
            //    Repository.addCategory(categorySelectorv11.CategorySelected);

            if (this.ReminderEnable.Checked == true)
            {
                this.NoteToEdit.ReminderDate = this.dateTimePicker1.Value;
            }
            else
            {
                this.NoteToEdit.ReminderDate = null;
            }

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditNote_Load(object sender, EventArgs e)
        {

        }
    }
}

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
using DigitalNotes.Data;

namespace DigitalNotes
{
    public partial class EditNote : Form
    {

        DigitalNoteDbContext db = new DigitalNoteDbContext();
        int? noteId = null; 
        Category category = null;
        int? CategoryId = null;
        Note NoteToEdit;

        public EditNote(int noteId)
        {
            InitializeComponent();

            this.noteId = noteId;
            NoteToEdit = db.Notes.SingleOrDefault(n => n.NoteId == noteId);
            this.TitleTextBox.Text = this.NoteToEdit.Title;
            this.categorySelectorv11.LoadCategories();
            if (NoteToEdit.Category != null) 
            {
                this.categorySelectorv11.CategorySelected = this.NoteToEdit.Category.Name;
            }
            else 
            {
                this.categorySelectorv11.CategorySelected = "";
            }
            
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

            this.NoteToEdit.Title = this.TitleTextBox.Text;
            category = db.Categories.SingleOrDefault(c => c.Name == categorySelectorv11.CategorySelected);

            if (category == null) 
            {
                category = new Category() { Name = categorySelectorv11.CategorySelected };
                db.Categories.Add(category);
                db.SaveChanges();
            }
            
            this.NoteToEdit.CategoryId = category.CategoryId;



            if (this.ReminderEnable.Checked == true)
            {
                this.NoteToEdit.ReminderDate = this.dateTimePicker1.Value;
            }
            else
            {
                this.NoteToEdit.ReminderDate = null;
            }
            db.SaveChanges();
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

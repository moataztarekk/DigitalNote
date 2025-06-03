using DigitalNotes.Data;
using DigitalNotes.Models;

namespace DigitalNotes
{
    public partial class AddNote : Form
    {
        public DigitalNoteDbContext db { get; set; }
        public AddNote()
        {
            this.db = new DigitalNoteDbContext();
            InitializeComponent();
            addNoteCategorySelector.LoadCategories();
            this.dateTimePicker1.MinDate = DateTime.Today;
            this.dateTimePicker1.Enabled = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string title = this.TitleTextBox.Text;
            string? categoryName = this.addNoteCategorySelector.CategorySelected;
            DateTime? reminderDate = this.dateTimePicker1.Value;
            Category category = null;
            int? CategoryId = null;
            if (title.Length == 0)
            {
                var popup = MessageBox.Show("Title cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (categoryName.Length == 0)
            {
                
            }
            else
            {
                //foreach (var c in db.Categories)
                //{
                //    if (c.Name == categoryName)
                //    {
                //        CategoryId=c.CategoryId;
                //    }
                //}
                if (db.Categories.SingleOrDefault(c => c.Name == categoryName)==null)
                { 
                    category=new Category() { Name=categoryName};
                    db.Categories.Add(category);


                }
                category = new Category();

            }

            if (!this.ReminderEnable.Checked)
            {
                reminderDate = null;
            }
            

            Note newNote = new Note() { Title = title, Category = db.Categories, CreationDate = DateTime.Now, ReminderDate = reminderDate };

            this.db.Add(newNote);
            if (!Repository.Categories.Contains(category) && category != null)
                Repository.addCategory(category);
            this.Close();
        }

        private void ReminderEnable_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Enabled = this.ReminderEnable.Checked;
        }

        private void AddNote_Load(object sender, EventArgs e)
        {

        }

        private void categorySelectorv11_Load(object sender, EventArgs e)
        {

        }
    }
}

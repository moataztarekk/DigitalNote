namespace DigitalNotes
{
    public partial class AddNote : Form
    {
        public AddNote()
        {
            InitializeComponent();
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
            string? category = this.CategoryTextBox.Text;
            DateTime? reminderDate = this.dateTimePicker1.Value;

            if (title.Length == 0)
            {
                var popup = MessageBox.Show("Title cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (category.Length == 0)
            {
                category = null;
            }

            if (!this.ReminderEnable.Checked)
            {
                reminderDate = null;
            }

            Note newNote = new Note() { NoteId = Repository.notes[Repository.notes.Count-1].NoteId + 1, Title = title, Category = category, CreationDate = DateTime.Now, ReminderDate = reminderDate };

            Repository.addNote(newNote);
            this.Close();
        }

        private void ReminderEnable_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Enabled = this.ReminderEnable.Checked;
        }
    }
}

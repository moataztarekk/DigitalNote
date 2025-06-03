using System.ComponentModel;
using System.Windows.Forms;

namespace DigitalNotes
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            this.NotesDataGrid.ContextMenuStrip = this.NotesContextMenu;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            BindingList<Note> notes = Repository.getNotes();

            // Populate the data grid
            this.NotesDataGrid.DataSource = notes;

            // Manage visible columns
            this.NotesDataGrid.Columns["Content"].Visible = false;
            this.NotesDataGrid.Columns["UserId"].Visible = false;
        }


        // Double clicking a row opens its correponding note.
        private void NotesDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // If the table header is double clicked; do nothing
            if (e.RowIndex == -1)
            {
                return;
            }
            int noteId = (int)this.NotesDataGrid.Rows[e.RowIndex].Cells["NoteId"].Value;

            // Open selected note here
            var popup = MessageBox.Show($"Note: {noteId} opened", "Note Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NewNoteBtn_Click(object sender, EventArgs e)
        {
            var addNoteDialog = new AddNote();
            addNoteDialog.ShowDialog();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            var confirmLogoutBox = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmLogoutBox == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void NotesDataGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = this.NotesDataGrid.HitTest(e.X, e.Y);
                if (hitTest.RowIndex >= 0)
                {
                    this.NotesDataGrid.ClearSelection();
                    this.NotesDataGrid.Rows[hitTest.RowIndex].Selected = true;
                }
            }
        }

        private void NotesContextMenu_Click(object sender, EventArgs e)
        {

        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = this.NotesDataGrid.SelectedRows[0];

            int noteId = (int)selectedRow.Cells["NoteId"].Value;

            var noteToEdit = Repository.notes.FirstOrDefault(n => n.NoteId == noteId);
            if (noteToEdit != null)
            {
                var editorForm = new EditNote(noteToEdit);
                editorForm.ShowDialog();
                this.Refresh();
            }
        }

        private void deleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this note?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var selectedRow = this.NotesDataGrid.SelectedRows[0];
                int noteId = (int)selectedRow.Cells["NoteId"].Value;

                var noteToDelete = Repository.notes.FirstOrDefault(n => n.NoteId == noteId);
                if (noteToDelete != null)
                {
                    Repository.notes.Remove(noteToDelete);
                }
            }
        }

        private void NotesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadNoteBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog Loadfile = new OpenFileDialog();
            Loadfile.Filter= "RTF files (*.rtf)|*.rtf";
            if (Loadfile.ShowDialog() == DialogResult.OK)
            {
                string filepath = Loadfile.FileName;
                string rtfcontent;

                using (StreamReader reader = new StreamReader(filepath))
                {
                    rtfcontent = reader.ReadToEnd();
                }

                Note newnote = new Note()
                {
                    NoteId = Repository.getNotes().Count + 1,
                    Title = Path.GetFileNameWithoutExtension(filepath),
                    Category = "un-catogrized",
                    CreationDate = DateTime.Now,
                    UserId = 1,
                    Content = rtfcontent
                };

                Repository.addNote(newnote);
                MessageBox.Show("Note has been loaded scuessfully!!");


            }


        }
    }
}

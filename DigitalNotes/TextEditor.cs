namespace WFDemo
{
    public partial class TextEditor : Form
    {
        private string currentFilePath = "";
        private Stack<string> undoStack = new Stack<string>();
        private Stack<string> redoStack = new Stack<string>();
        private bool isInternalChange = false;
        private bool isTextChanged=false;

        public TextEditor()
        {
            InitializeComponent();
            this.richTextBoxNote.TextChanged += new EventHandler(this.richTextBoxNote_TextChanged);
            this.Load += new EventHandler(this.TextEditor_Load);
        }
        private void TextEditor_Load(object sender, EventArgs e)
        {
            undoStack.Clear();
            redoStack.Clear();
            undoStack.Push(richTextBoxNote.Rtf);
        }
        private void richTextBoxNote_TextChanged(object sender, EventArgs e)
        {
            if (!isInternalChange)
            {
                string currentState = richTextBoxNote.Rtf;
                if (undoStack.Count == 0 || undoStack.Peek() != currentState)
                {
                    undoStack.Push(currentState);
                    redoStack.Clear();
                }

                isTextChanged = true;
            }
        }
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openDialog.FileName).ToLower() == ".rtf")
                    richTextBoxNote.LoadFile(openDialog.FileName, RichTextBoxStreamType.RichText);
                else
                    richTextBoxNote.LoadFile(openDialog.FileName, RichTextBoxStreamType.PlainText);

                currentFilePath = openDialog.FileName;
                isTextChanged = false;

                undoStack.Clear();
                redoStack.Clear();
                undoStack.Push(richTextBoxNote.Rtf);
            }
        }
        private void BtnBold_Click(object sender, EventArgs e)
        {
            if (richTextBoxNote.SelectionFont != null)
            {
                Font currentFont = richTextBoxNote.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Bold; // toggle bold
                richTextBoxNote.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }
        private void BtnItalic_Click(object sender, EventArgs e)
        {
            if (richTextBoxNote.SelectionFont != null)
            {
                Font currentFont = richTextBoxNote.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Italic;
                richTextBoxNote.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }
        private void BtnUnderline_Click(object sender, EventArgs e)
        {
            if (richTextBoxNote.SelectionFont != null)
            {
                Font currentFont = richTextBoxNote.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Underline;
                richTextBoxNote.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }
        private void BtnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBoxNote.SelectionFont = fontDialog.Font;
            }
        }
        private void BtnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBoxNote.SelectionColor = colorDialog.Color;
            }
        }
        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (richTextBoxNote.SelectedText.Length > 0)
            {
                richTextBoxNote.Copy();
            }
            else
            {
                MessageBox.Show("Please select text to copy.");
            }
        }
        private void BtnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                isInternalChange = true;
                richTextBoxNote.SelectedText = Clipboard.GetText();
                isInternalChange = false;
                TakeSnapshot();
            }
            else
            {
                MessageBox.Show("Clipboard does not contain text.");
            }
        }
        private void BtnCut_Click(object sender, EventArgs e)
        {
            if (richTextBoxNote.SelectedText.Length > 0)
            {
                richTextBoxNote.Cut();
                TakeSnapshot();
            }
            else
            {
                MessageBox.Show("Please select text to cut.");
            }
        }
        private void BtnUndo_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 1)
            {
                isInternalChange = true;

                string currentState = undoStack.Pop();
                redoStack.Push(currentState);
                string previousState = undoStack.Peek();
                richTextBoxNote.Rtf = previousState;

                isInternalChange = false;
            }
            else
            {
                MessageBox.Show("Nothing to undo.");
            }
        }
        private void BtnRedo_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                isInternalChange = true;
                string nextState = redoStack.Pop();
                undoStack.Push(nextState);
                richTextBoxNote.Rtf = nextState;
                isInternalChange = false;
            }
            else
            {
                MessageBox.Show("Nothing to redo.");
            }
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSearch.Text))
            {

                int originalSelectionStart = richTextBoxNote.SelectionStart;
                int originalSelectionLength = richTextBoxNote.SelectionLength;

                richTextBoxNote.SelectAll();
                richTextBoxNote.SelectionBackColor = richTextBoxNote.BackColor;
                richTextBoxNote.Select(originalSelectionStart, originalSelectionLength);
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = TxtSearch.Text;
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }


            int originalSelectionStart = richTextBoxNote.SelectionStart;
            int originalSelectionLength = richTextBoxNote.SelectionLength;


            richTextBoxNote.SelectAll();
            richTextBoxNote.SelectionBackColor = richTextBoxNote.BackColor;
            richTextBoxNote.DeselectAll();

            int index = 0;
            int matchCount = 0;

            while ((index = richTextBoxNote.Text.IndexOf(searchTerm, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                richTextBoxNote.Select(index, searchTerm.Length);
                richTextBoxNote.SelectionBackColor = Color.Yellow;
                index += searchTerm.Length;
                matchCount++;
            }


            richTextBoxNote.Select(originalSelectionStart, originalSelectionLength);

            if (matchCount == 0)
            {
                MessageBox.Show("Text not found.");
            }

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                SaveContent(currentFilePath);
            }
            else
            {
                BtnSaveAs_Click(sender, e);
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = saveDialog.FileName;
                SaveContent(currentFilePath);
            }
        }
        private void SaveContent(string path)
        {
            if (Path.GetExtension(path).ToLower() == ".rtf")
                richTextBoxNote.SaveFile(path, RichTextBoxStreamType.RichText);
            else
                File.WriteAllText(path, richTextBoxNote.Text);

            isTextChanged = false;
            MessageBox.Show("File saved successfully.");
        }
        private void TakeSnapshot()
        {
            string currentState = richTextBoxNote.Rtf;
            if (undoStack.Count == 0 || undoStack.Peek() != currentState)
            {
                undoStack.Push(currentState);
                redoStack.Clear();
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }


}

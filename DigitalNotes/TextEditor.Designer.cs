namespace WFDemo
{
    partial class TextEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanelTop = new FlowLayoutPanel();
            BtnOpen = new Button();
            BtnBold = new Button();
            BtnItalic = new Button();
            BtnUnderline = new Button();
            BtnFont = new Button();
            BtnColor = new Button();
            BtnCopy = new Button();
            BtnPaste = new Button();
            BtnCut = new Button();
            BtnUndo = new Button();
            BtnRedo = new Button();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            BtnSave = new Button();
            BtnSaveAs = new Button();
            BtnClose = new Button();
            richTextBoxNote = new RichTextBox();
            flowLayoutPanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanelTop.Controls.Add(BtnOpen);
            flowLayoutPanelTop.Controls.Add(BtnBold);
            flowLayoutPanelTop.Controls.Add(BtnItalic);
            flowLayoutPanelTop.Controls.Add(BtnUnderline);
            flowLayoutPanelTop.Controls.Add(BtnFont);
            flowLayoutPanelTop.Controls.Add(BtnColor);
            flowLayoutPanelTop.Controls.Add(BtnCopy);
            flowLayoutPanelTop.Controls.Add(BtnPaste);
            flowLayoutPanelTop.Controls.Add(BtnCut);
            flowLayoutPanelTop.Controls.Add(BtnUndo);
            flowLayoutPanelTop.Controls.Add(BtnRedo);
            flowLayoutPanelTop.Controls.Add(TxtSearch);
            flowLayoutPanelTop.Controls.Add(BtnSearch);
            flowLayoutPanelTop.Controls.Add(BtnSave);
            flowLayoutPanelTop.Controls.Add(BtnSaveAs);
            flowLayoutPanelTop.Controls.Add(BtnClose);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Size = new Size(925, 45);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // BtnOpen
            // 
            BtnOpen.Image = DigitalNotes.Properties.Resources.icons8_open_file_32;
            BtnOpen.Location = new Point(3, 3);
            BtnOpen.Name = "BtnOpen";
            BtnOpen.Size = new Size(46, 37);
            BtnOpen.TabIndex = 2;
            BtnOpen.UseVisualStyleBackColor = true;
            BtnOpen.Click += BtnOpen_Click;
            // 
            // BtnBold
            // 
            BtnBold.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBold.Image = DigitalNotes.Properties.Resources.icons8_bold_16;
            BtnBold.Location = new Point(55, 3);
            BtnBold.Name = "BtnBold";
            BtnBold.Size = new Size(46, 37);
            BtnBold.TabIndex = 0;
            BtnBold.UseVisualStyleBackColor = true;
            BtnBold.Click += BtnBold_Click;
            // 
            // BtnItalic
            // 
            BtnItalic.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnItalic.Image = DigitalNotes.Properties.Resources.icons8_italic_16;
            BtnItalic.Location = new Point(107, 3);
            BtnItalic.Name = "BtnItalic";
            BtnItalic.Size = new Size(46, 37);
            BtnItalic.TabIndex = 1;
            BtnItalic.UseVisualStyleBackColor = true;
            BtnItalic.Click += BtnItalic_Click;
            // 
            // BtnUnderline
            // 
            BtnUnderline.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            BtnUnderline.Image = DigitalNotes.Properties.Resources.icons8_underline_16;
            BtnUnderline.Location = new Point(159, 3);
            BtnUnderline.Name = "BtnUnderline";
            BtnUnderline.Size = new Size(46, 37);
            BtnUnderline.TabIndex = 2;
            BtnUnderline.UseVisualStyleBackColor = true;
            BtnUnderline.Click += BtnUnderline_Click;
            // 
            // BtnFont
            // 
            BtnFont.Image = DigitalNotes.Properties.Resources.icons8_font_16;
            BtnFont.Location = new Point(211, 3);
            BtnFont.Name = "BtnFont";
            BtnFont.Size = new Size(46, 37);
            BtnFont.TabIndex = 2;
            BtnFont.UseVisualStyleBackColor = true;
            BtnFont.Click += BtnFont_Click;
            // 
            // BtnColor
            // 
            BtnColor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnColor.Image = DigitalNotes.Properties.Resources.icons8_color_mode_32;
            BtnColor.Location = new Point(263, 3);
            BtnColor.Name = "BtnColor";
            BtnColor.Size = new Size(46, 37);
            BtnColor.TabIndex = 3;
            BtnColor.UseVisualStyleBackColor = true;
            BtnColor.Click += BtnColor_Click;
            // 
            // BtnCopy
            // 
            BtnCopy.Image = DigitalNotes.Properties.Resources.icons8_copy_windows_11_color_32;
            BtnCopy.Location = new Point(315, 3);
            BtnCopy.Name = "BtnCopy";
            BtnCopy.Size = new Size(39, 37);
            BtnCopy.TabIndex = 2;
            BtnCopy.UseVisualStyleBackColor = true;
            BtnCopy.Click += BtnCopy_Click;
            // 
            // BtnPaste
            // 
            BtnPaste.Image = DigitalNotes.Properties.Resources.icons8_paste_shortcut_32;
            BtnPaste.Location = new Point(360, 3);
            BtnPaste.Name = "BtnPaste";
            BtnPaste.Size = new Size(46, 37);
            BtnPaste.TabIndex = 3;
            BtnPaste.UseVisualStyleBackColor = true;
            BtnPaste.Click += BtnPaste_Click;
            // 
            // BtnCut
            // 
            BtnCut.Image = DigitalNotes.Properties.Resources.icons8_cut_32;
            BtnCut.Location = new Point(412, 3);
            BtnCut.Name = "BtnCut";
            BtnCut.Size = new Size(46, 37);
            BtnCut.TabIndex = 4;
            BtnCut.UseVisualStyleBackColor = true;
            BtnCut.Click += BtnCut_Click;
            // 
            // BtnUndo
            // 
            BtnUndo.Image = DigitalNotes.Properties.Resources.icons8_undo_32;
            BtnUndo.Location = new Point(464, 3);
            BtnUndo.Name = "BtnUndo";
            BtnUndo.Size = new Size(46, 37);
            BtnUndo.TabIndex = 2;
            BtnUndo.UseVisualStyleBackColor = true;
            BtnUndo.Click += BtnUndo_Click;
            // 
            // BtnRedo
            // 
            BtnRedo.Image = DigitalNotes.Properties.Resources.icons8_redo_32;
            BtnRedo.Location = new Point(516, 3);
            BtnRedo.Name = "BtnRedo";
            BtnRedo.Size = new Size(46, 37);
            BtnRedo.TabIndex = 3;
            BtnRedo.UseVisualStyleBackColor = true;
            BtnRedo.Click += BtnRedo_Click;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(568, 3);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(140, 27);
            TxtSearch.TabIndex = 4;
            TxtSearch.TextAlign = HorizontalAlignment.Center;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = DigitalNotes.Properties.Resources.icons8_search_16;
            BtnSearch.Location = new Point(714, 3);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(46, 27);
            BtnSearch.TabIndex = 4;
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // BtnSave
            // 
            BtnSave.Image = DigitalNotes.Properties.Resources.icons8_save_32;
            BtnSave.Location = new Point(766, 3);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(46, 37);
            BtnSave.TabIndex = 1;
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnSaveAs
            // 
            BtnSaveAs.Image = DigitalNotes.Properties.Resources.icons8_save_as_32;
            BtnSaveAs.Location = new Point(818, 3);
            BtnSaveAs.Name = "BtnSaveAs";
            BtnSaveAs.Size = new Size(46, 37);
            BtnSaveAs.TabIndex = 2;
            BtnSaveAs.UseVisualStyleBackColor = true;
            BtnSaveAs.Click += BtnSaveAs_Click;
            // 
            // BtnClose
            // 
            BtnClose.Image = DigitalNotes.Properties.Resources.icons8_close_32;
            BtnClose.Location = new Point(870, 3);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(46, 37);
            BtnClose.TabIndex = 1;
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // richTextBoxNote
            // 
            richTextBoxNote.BackColor = Color.White;
            richTextBoxNote.Dock = DockStyle.Fill;
            richTextBoxNote.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxNote.Location = new Point(0, 45);
            richTextBoxNote.Name = "richTextBoxNote";
            richTextBoxNote.Size = new Size(925, 391);
            richTextBoxNote.TabIndex = 1;
            richTextBoxNote.Text = "";
            richTextBoxNote.TextChanged += richTextBoxNote_TextChanged;
            // 
            // TextEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 436);
            ControlBox = false;
            Controls.Add(richTextBoxNote);
            Controls.Add(flowLayoutPanelTop);
            MaximizeBox = false;
            Name = "TextEditor";
            Text = "Text Editor";
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button BtnBold;
        private Button BtnItalic;
        private Button BtnUnderline;
        private TextBox TxtSearch;
        private Button BtnSearch;
        private Button BtnSave;
        private Button BtnSaveAs;
        private Button BtnClose;
        private RichTextBox richTextBoxNote;
        private Button BtnFont;
        private Button BtnColor;
        private Button BtnOpen;
        private Button BtnCopy;
        private Button BtnPaste;
        private Button BtnCut;
        private Button BtnUndo;
        private Button BtnRedo;
    }
}

namespace DigitalNotes
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            NewNoteBtn = new Button();
            LoadNoteBtn = new Button();
            NotificationsBtn = new Button();
            LogoutBtn = new Button();
            NotesDataGrid = new DataGridView();
            NotesContextMenu = new ContextMenuStrip(components);
            editNoteToolStripMenuItem = new ToolStripMenuItem();
            deleteNoteToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)NotesDataGrid).BeginInit();
            NotesContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // NewNoteBtn
            // 
            NewNoteBtn.Location = new Point(21, 12);
            NewNoteBtn.Name = "NewNoteBtn";
            NewNoteBtn.Size = new Size(104, 23);
            NewNoteBtn.TabIndex = 0;
            NewNoteBtn.Text = "New Note";
            NewNoteBtn.UseVisualStyleBackColor = true;
            NewNoteBtn.Click += NewNoteBtn_Click;
            // 
            // LoadNoteBtn
            // 
            LoadNoteBtn.Location = new Point(21, 41);
            LoadNoteBtn.Name = "LoadNoteBtn";
            LoadNoteBtn.Size = new Size(104, 23);
            LoadNoteBtn.TabIndex = 1;
            LoadNoteBtn.Text = "Load Note";
            LoadNoteBtn.UseVisualStyleBackColor = true;
            // 
            // NotificationsBtn
            // 
            NotificationsBtn.Location = new Point(21, 70);
            NotificationsBtn.Name = "NotificationsBtn";
            NotificationsBtn.Size = new Size(104, 23);
            NotificationsBtn.TabIndex = 2;
            NotificationsBtn.Text = "Notifications";
            NotificationsBtn.UseVisualStyleBackColor = true;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Location = new Point(21, 415);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(104, 23);
            LogoutBtn.TabIndex = 3;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // NotesDataGrid
            // 
            NotesDataGrid.AllowUserToAddRows = false;
            NotesDataGrid.AllowUserToOrderColumns = true;
            NotesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NotesDataGrid.Dock = DockStyle.Right;
            NotesDataGrid.Location = new Point(153, 0);
            NotesDataGrid.Name = "NotesDataGrid";
            NotesDataGrid.ReadOnly = true;
            NotesDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            NotesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            NotesDataGrid.Size = new Size(647, 450);
            NotesDataGrid.TabIndex = 4;
            NotesDataGrid.CellDoubleClick += NotesDataGrid_CellDoubleClick;
            NotesDataGrid.MouseDown += NotesDataGrid_MouseDown;
            // 
            // NotesContextMenu
            // 
            NotesContextMenu.Items.AddRange(new ToolStripItem[] { editNoteToolStripMenuItem, deleteNoteToolStripMenuItem });
            NotesContextMenu.Name = "contextMenuStrip1";
            NotesContextMenu.Size = new Size(137, 48);
            NotesContextMenu.Click += NotesContextMenu_Click;
            // 
            // editNoteToolStripMenuItem
            // 
            editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            editNoteToolStripMenuItem.Size = new Size(136, 22);
            editNoteToolStripMenuItem.Text = "Edit Note";
            editNoteToolStripMenuItem.Click += editNoteToolStripMenuItem_Click;
            // 
            // deleteNoteToolStripMenuItem
            // 
            deleteNoteToolStripMenuItem.Name = "deleteNoteToolStripMenuItem";
            deleteNoteToolStripMenuItem.Size = new Size(136, 22);
            deleteNoteToolStripMenuItem.Text = "Delete Note";
            deleteNoteToolStripMenuItem.Click += deleteNoteToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NotesDataGrid);
            Controls.Add(LogoutBtn);
            Controls.Add(NotificationsBtn);
            Controls.Add(LoadNoteBtn);
            Controls.Add(NewNoteBtn);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)NotesDataGrid).EndInit();
            NotesContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button NewNoteBtn;
        private Button LoadNoteBtn;
        private Button NotificationsBtn;
        private Button LogoutBtn;
        private DataGridView NotesDataGrid;
        private ContextMenuStrip NotesContextMenu;
        private ToolStripMenuItem editNoteToolStripMenuItem;
        private ToolStripMenuItem deleteNoteToolStripMenuItem;
    }
}
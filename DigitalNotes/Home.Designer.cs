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
            NewNoteBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewNoteBtn.Location = new Point(67, 16);
            NewNoteBtn.Margin = new Padding(3, 4, 3, 4);
            NewNoteBtn.Name = "NewNoteBtn";
            NewNoteBtn.Size = new Size(119, 31);
            NewNoteBtn.TabIndex = 0;
            NewNoteBtn.Text = "New Note";
            NewNoteBtn.UseVisualStyleBackColor = true;
            NewNoteBtn.Click += NewNoteBtn_Click;
            // 
            // LoadNoteBtn
            // 
            LoadNoteBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoadNoteBtn.Location = new Point(67, 55);
            LoadNoteBtn.Margin = new Padding(3, 4, 3, 4);
            LoadNoteBtn.Name = "LoadNoteBtn";
            LoadNoteBtn.Size = new Size(119, 31);
            LoadNoteBtn.TabIndex = 1;
            LoadNoteBtn.Text = "Load Note";
            LoadNoteBtn.UseVisualStyleBackColor = true;
            LoadNoteBtn.Click += LoadNoteBtn_Click;
            // 
            // NotificationsBtn
            // 
            NotificationsBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NotificationsBtn.Location = new Point(67, 94);
            NotificationsBtn.Margin = new Padding(3, 4, 3, 4);
            NotificationsBtn.Name = "NotificationsBtn";
            NotificationsBtn.Size = new Size(119, 31);
            NotificationsBtn.TabIndex = 2;
            NotificationsBtn.Text = "Notifications";
            NotificationsBtn.UseVisualStyleBackColor = true;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoutBtn.Location = new Point(67, 556);
            LogoutBtn.Margin = new Padding(3, 4, 3, 4);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(119, 31);
            LogoutBtn.TabIndex = 3;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // NotesDataGrid
            // 
            NotesDataGrid.AllowUserToAddRows = false;
            NotesDataGrid.AllowUserToOrderColumns = true;
            NotesDataGrid.BackgroundColor = Color.White;
            NotesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NotesDataGrid.Dock = DockStyle.Right;
            NotesDataGrid.Location = new Point(249, 0);
            NotesDataGrid.Margin = new Padding(3, 4, 3, 4);
            NotesDataGrid.Name = "NotesDataGrid";
            NotesDataGrid.ReadOnly = true;
            NotesDataGrid.RowHeadersWidth = 51;
            NotesDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            NotesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            NotesDataGrid.Size = new Size(672, 600);
            NotesDataGrid.TabIndex = 4;
            NotesDataGrid.CellContentClick += NotesDataGrid_CellContentClick;
            NotesDataGrid.CellDoubleClick += NotesDataGrid_CellDoubleClick;
            NotesDataGrid.MouseDown += NotesDataGrid_MouseDown;
            // 
            // NotesContextMenu
            // 
            NotesContextMenu.ImageScalingSize = new Size(20, 20);
            NotesContextMenu.Items.AddRange(new ToolStripItem[] { editNoteToolStripMenuItem, deleteNoteToolStripMenuItem });
            NotesContextMenu.Name = "contextMenuStrip1";
            NotesContextMenu.Size = new Size(160, 52);
            NotesContextMenu.Click += NotesContextMenu_Click;
            // 
            // editNoteToolStripMenuItem
            // 
            editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            editNoteToolStripMenuItem.Size = new Size(159, 24);
            editNoteToolStripMenuItem.Text = "Edit Note";
            editNoteToolStripMenuItem.Click += editNoteToolStripMenuItem_Click;
            // 
            // deleteNoteToolStripMenuItem
            // 
            deleteNoteToolStripMenuItem.Name = "deleteNoteToolStripMenuItem";
            deleteNoteToolStripMenuItem.Size = new Size(159, 24);
            deleteNoteToolStripMenuItem.Text = "Delete Note";
            deleteNoteToolStripMenuItem.Click += deleteNoteToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(921, 600);
            Controls.Add(NotesDataGrid);
            Controls.Add(LogoutBtn);
            Controls.Add(NotificationsBtn);
            Controls.Add(LoadNoteBtn);
            Controls.Add(NewNoteBtn);
            Margin = new Padding(3, 4, 3, 4);
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
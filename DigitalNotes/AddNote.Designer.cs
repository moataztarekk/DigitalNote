namespace DigitalNotes
{
    partial class AddNote
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
            ConfirmButton = new Button();
            TitleLabel = new Label();
            TitleTextBox = new TextBox();
            CategoryLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            ReminderDateLabel = new Label();
            CancelButton = new Button();
            ReminderEnable = new CheckBox();
            addNoteCategorySelector = new CategorySelectorv1();
            SuspendLayout();
            // 
            // ConfirmButton
            // 
            ConfirmButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmButton.Location = new Point(150, 269);
            ConfirmButton.Margin = new Padding(3, 4, 3, 4);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(108, 40);
            ConfirmButton.TabIndex = 0;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.BackColor = Color.FromArgb(64, 64, 64);
            TitleLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(47, 30);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(54, 24);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Title";
            TitleLabel.Click += TitleLabel_Click;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(177, 28);
            TitleTextBox.Margin = new Padding(3, 4, 3, 4);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(228, 26);
            TitleTextBox.TabIndex = 2;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryLabel.ForeColor = Color.White;
            CategoryLabel.Location = new Point(47, 105);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(101, 24);
            CategoryLabel.TabIndex = 3;
            CategoryLabel.Text = "Category";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(250, 201);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.MinDate = new DateTime(2025, 5, 31, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(155, 26);
            dateTimePicker1.TabIndex = 5;
            // 
            // ReminderDateLabel
            // 
            ReminderDateLabel.AutoSize = true;
            ReminderDateLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReminderDateLabel.ForeColor = Color.White;
            ReminderDateLabel.Location = new Point(47, 203);
            ReminderDateLabel.Name = "ReminderDateLabel";
            ReminderDateLabel.Size = new Size(109, 24);
            ReminderDateLabel.TabIndex = 6;
            ReminderDateLabel.Text = "Reminder";
            ReminderDateLabel.Click += ReminderDateLabel_Click;
            // 
            // CancelButton
            // 
            CancelButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.Location = new Point(297, 269);
            CancelButton.Margin = new Padding(3, 4, 3, 4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(108, 40);
            CancelButton.TabIndex = 7;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ReminderEnable
            // 
            ReminderEnable.AutoSize = true;
            ReminderEnable.Location = new Point(177, 210);
            ReminderEnable.Margin = new Padding(3, 4, 3, 4);
            ReminderEnable.Name = "ReminderEnable";
            ReminderEnable.Size = new Size(18, 17);
            ReminderEnable.TabIndex = 8;
            ReminderEnable.UseVisualStyleBackColor = true;
            ReminderEnable.CheckedChanged += ReminderEnable_CheckedChanged;
            // 
            // addNoteCategorySelector
            // 
            addNoteCategorySelector.CategorySelected = "";
            addNoteCategorySelector.Location = new Point(140, 79);
            addNoteCategorySelector.Name = "addNoteCategorySelector";
            addNoteCategorySelector.Size = new Size(438, 111);
            addNoteCategorySelector.TabIndex = 9;
            addNoteCategorySelector.Load += categorySelectorv11_Load;
            // 
            // AddNote
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(441, 337);
            Controls.Add(addNoteCategorySelector);
            Controls.Add(ReminderEnable);
            Controls.Add(CancelButton);
            Controls.Add(ReminderDateLabel);
            Controls.Add(dateTimePicker1);
            Controls.Add(CategoryLabel);
            Controls.Add(TitleTextBox);
            Controls.Add(TitleLabel);
            Controls.Add(ConfirmButton);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(64, 64, 64);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddNote";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddNote";
            Load += AddNote_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConfirmButton;
        private Label TitleLabel;
        private TextBox TitleTextBox;
        private Label CategoryLabel;
        private DateTimePicker dateTimePicker1;
        private Label ReminderDateLabel;
        private Button CancelButton;
        private CheckBox ReminderEnable;
        private CategorySelectorv1 addNoteCategorySelector;
    }
}
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
            CategoryTextBox = new TextBox();
            CategoryLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            ReminderDateLabel = new Label();
            CancelButton = new Button();
            ReminderEnable = new CheckBox();
            SuspendLayout();
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(155, 198);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(75, 23);
            ConfirmButton.TabIndex = 0;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(74, 28);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(29, 15);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Title";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(155, 24);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(200, 23);
            TitleTextBox.TabIndex = 2;
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.Location = new Point(155, 82);
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.Size = new Size(200, 23);
            CategoryTextBox.TabIndex = 4;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(48, 86);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(55, 15);
            CategoryLabel.TabIndex = 3;
            CategoryLabel.Text = "Category";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(219, 144);
            dateTimePicker1.MinDate = new DateTime(2025, 5, 31, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(136, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // ReminderDateLabel
            // 
            ReminderDateLabel.AutoSize = true;
            ReminderDateLabel.Location = new Point(45, 148);
            ReminderDateLabel.Name = "ReminderDateLabel";
            ReminderDateLabel.Size = new Size(58, 15);
            ReminderDateLabel.TabIndex = 6;
            ReminderDateLabel.Text = "Reminder";
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(280, 198);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 7;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ReminderEnable
            // 
            ReminderEnable.AutoSize = true;
            ReminderEnable.Location = new Point(155, 148);
            ReminderEnable.Name = "ReminderEnable";
            ReminderEnable.Size = new Size(15, 14);
            ReminderEnable.TabIndex = 8;
            ReminderEnable.UseVisualStyleBackColor = true;
            ReminderEnable.CheckedChanged += ReminderEnable_CheckedChanged;
            // 
            // AddNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 253);
            Controls.Add(ReminderEnable);
            Controls.Add(CancelButton);
            Controls.Add(ReminderDateLabel);
            Controls.Add(dateTimePicker1);
            Controls.Add(CategoryTextBox);
            Controls.Add(CategoryLabel);
            Controls.Add(TitleTextBox);
            Controls.Add(TitleLabel);
            Controls.Add(ConfirmButton);
            Name = "AddNote";
            Text = "AddNote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConfirmButton;
        private Label TitleLabel;
        private TextBox TitleTextBox;
        private TextBox CategoryTextBox;
        private Label CategoryLabel;
        private DateTimePicker dateTimePicker1;
        private Label ReminderDateLabel;
        private Button CancelButton;
        private CheckBox ReminderEnable;
    }
}
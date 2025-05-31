namespace DigitalNotes
{
    partial class EditNote
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
            ReminderEnable = new CheckBox();
            CancelButton = new Button();
            ReminderDateLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            CategoryTextBox = new TextBox();
            CategoryLabel = new Label();
            TitleTextBox = new TextBox();
            TitleLabel = new Label();
            ConfirmButton = new Button();
            SuspendLayout();
            // 
            // ReminderEnable
            // 
            ReminderEnable.AutoSize = true;
            ReminderEnable.Location = new Point(178, 169);
            ReminderEnable.Name = "ReminderEnable";
            ReminderEnable.Size = new Size(15, 14);
            ReminderEnable.TabIndex = 17;
            ReminderEnable.UseVisualStyleBackColor = true;
            ReminderEnable.CheckedChanged += ReminderEnable_CheckedChanged;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(303, 219);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ReminderDateLabel
            // 
            ReminderDateLabel.AutoSize = true;
            ReminderDateLabel.Location = new Point(68, 169);
            ReminderDateLabel.Name = "ReminderDateLabel";
            ReminderDateLabel.Size = new Size(58, 15);
            ReminderDateLabel.TabIndex = 15;
            ReminderDateLabel.Text = "Reminder";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(242, 165);
            dateTimePicker1.MinDate = new DateTime(2025, 5, 31, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(136, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.Location = new Point(178, 103);
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.Size = new Size(200, 23);
            CategoryTextBox.TabIndex = 13;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(71, 107);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(55, 15);
            CategoryLabel.TabIndex = 12;
            CategoryLabel.Text = "Category";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(178, 45);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(200, 23);
            TitleTextBox.TabIndex = 11;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(97, 49);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(29, 15);
            TitleLabel.TabIndex = 10;
            TitleLabel.Text = "Title";
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(178, 219);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(75, 23);
            ConfirmButton.TabIndex = 9;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // EditNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 287);
            Controls.Add(ReminderEnable);
            Controls.Add(CancelButton);
            Controls.Add(ReminderDateLabel);
            Controls.Add(dateTimePicker1);
            Controls.Add(CategoryTextBox);
            Controls.Add(CategoryLabel);
            Controls.Add(TitleTextBox);
            Controls.Add(TitleLabel);
            Controls.Add(ConfirmButton);
            Name = "EditNote";
            Text = "EditNote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ReminderEnable;
        private Button CancelButton;
        private Label ReminderDateLabel;
        private DateTimePicker dateTimePicker1;
        private TextBox CategoryTextBox;
        private Label CategoryLabel;
        private TextBox TitleTextBox;
        private Label TitleLabel;
        private Button ConfirmButton;
    }
}
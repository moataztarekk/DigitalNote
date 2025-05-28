namespace DigitalNotes
{
    partial class Login
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
            LoginBtn = new Button();
            LogUsernameBox = new TextBox();
            LogPasswordBox = new TextBox();
            LogUsernameLbl = new Label();
            LogPasswordLbl = new Label();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.Info;
            LoginBtn.Location = new Point(202, 273);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(153, 52);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // LogUsernameBox
            // 
            LogUsernameBox.Location = new Point(202, 90);
            LogUsernameBox.Name = "LogUsernameBox";
            LogUsernameBox.Size = new Size(259, 27);
            LogUsernameBox.TabIndex = 1;
            // 
            // LogPasswordBox
            // 
            LogPasswordBox.Location = new Point(202, 167);
            LogPasswordBox.Name = "LogPasswordBox";
            LogPasswordBox.Size = new Size(259, 27);
            LogPasswordBox.TabIndex = 2;
            // 
            // LogUsernameLbl
            // 
            LogUsernameLbl.AutoSize = true;
            LogUsernameLbl.Location = new Point(67, 90);
            LogUsernameLbl.Name = "LogUsernameLbl";
            LogUsernameLbl.Size = new Size(75, 20);
            LogUsernameLbl.TabIndex = 3;
            LogUsernameLbl.Text = "Username";
            // 
            // LogPasswordLbl
            // 
            LogPasswordLbl.AutoSize = true;
            LogPasswordLbl.Location = new Point(67, 170);
            LogPasswordLbl.Name = "LogPasswordLbl";
            LogPasswordLbl.Size = new Size(70, 20);
            LogPasswordLbl.TabIndex = 4;
            LogPasswordLbl.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(547, 393);
            Controls.Add(LogPasswordLbl);
            Controls.Add(LogUsernameLbl);
            Controls.Add(LogPasswordBox);
            Controls.Add(LogUsernameBox);
            Controls.Add(LoginBtn);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginBtn;
        private TextBox LogUsernameBox;
        private TextBox LogPasswordBox;
        private Label LogUsernameLbl;
        private Label LogPasswordLbl;
    }
}
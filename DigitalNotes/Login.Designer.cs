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
            RegisterBtn = new Button();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.Info;
<<<<<<< HEAD
            LoginBtn.Location = new Point(177, 177);
=======
            LoginBtn.Location = new Point(177, 145);
>>>>>>> 63a0501cdf81bc8a3ea53c84a5d9fad084c88654
            LoginBtn.Margin = new Padding(3, 2, 3, 2);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(134, 39);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // LogUsernameBox
            // 
<<<<<<< HEAD
            LogUsernameBox.Location = new Point(177, 68);
=======
            LogUsernameBox.Location = new Point(177, 46);
>>>>>>> 63a0501cdf81bc8a3ea53c84a5d9fad084c88654
            LogUsernameBox.Margin = new Padding(3, 2, 3, 2);
            LogUsernameBox.Name = "LogUsernameBox";
            LogUsernameBox.Size = new Size(227, 23);
            LogUsernameBox.TabIndex = 1;
            // 
            // LogPasswordBox
            // 
<<<<<<< HEAD
            LogPasswordBox.Location = new Point(177, 125);
=======
            LogPasswordBox.Location = new Point(177, 103);
>>>>>>> 63a0501cdf81bc8a3ea53c84a5d9fad084c88654
            LogPasswordBox.Margin = new Padding(3, 2, 3, 2);
            LogPasswordBox.Name = "LogPasswordBox";
            LogPasswordBox.Size = new Size(227, 23);
            LogPasswordBox.TabIndex = 2;
            // 
            // LogUsernameLbl
            // 
            LogUsernameLbl.AutoSize = true;
<<<<<<< HEAD
            LogUsernameLbl.Location = new Point(59, 68);
=======
            LogUsernameLbl.Location = new Point(56, 50);
>>>>>>> 63a0501cdf81bc8a3ea53c84a5d9fad084c88654
            LogUsernameLbl.Name = "LogUsernameLbl";
            LogUsernameLbl.Size = new Size(60, 15);
            LogUsernameLbl.TabIndex = 3;
            LogUsernameLbl.Text = "Username";
            // 
            // LogPasswordLbl
            // 
            LogPasswordLbl.AutoSize = true;
<<<<<<< HEAD
            LogPasswordLbl.Location = new Point(59, 128);
=======
            LogPasswordLbl.Location = new Point(59, 107);
>>>>>>> 63a0501cdf81bc8a3ea53c84a5d9fad084c88654
            LogPasswordLbl.Name = "LogPasswordLbl";
            LogPasswordLbl.Size = new Size(57, 15);
            LogPasswordLbl.TabIndex = 4;
            LogPasswordLbl.Text = "Password";
            // 
            // RegisterBtn
            // 
<<<<<<< HEAD
            RegisterBtn.BackColor = SystemColors.ButtonHighlight;
            RegisterBtn.Location = new Point(177, 234);
=======
            RegisterBtn.Location = new Point(177, 210);
>>>>>>> 63a0501cdf81bc8a3ea53c84a5d9fad084c88654
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(134, 39);
            RegisterBtn.TabIndex = 5;
            RegisterBtn.Text = "Register";
<<<<<<< HEAD
            RegisterBtn.UseVisualStyleBackColor = false;
=======
            RegisterBtn.UseVisualStyleBackColor = true;
>>>>>>> 63a0501cdf81bc8a3ea53c84a5d9fad084c88654
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
<<<<<<< HEAD
            ClientSize = new Size(479, 295);
=======
            ClientSize = new Size(484, 261);
>>>>>>> 63a0501cdf81bc8a3ea53c84a5d9fad084c88654
            Controls.Add(RegisterBtn);
            Controls.Add(LogPasswordLbl);
            Controls.Add(LogUsernameLbl);
            Controls.Add(LogPasswordBox);
            Controls.Add(LogUsernameBox);
            Controls.Add(LoginBtn);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button RegisterBtn;
    }
}
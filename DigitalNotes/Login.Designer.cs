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
            LoginBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(112, 274);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(135, 52);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // LogUsernameBox
            // 
            LogUsernameBox.Location = new Point(202, 91);
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
            LogUsernameLbl.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogUsernameLbl.ForeColor = Color.White;
            LogUsernameLbl.Location = new Point(67, 91);
            LogUsernameLbl.Name = "LogUsernameLbl";
            LogUsernameLbl.Size = new Size(112, 24);
            LogUsernameLbl.TabIndex = 3;
            LogUsernameLbl.Text = "Username";
            // 
            // LogPasswordLbl
            // 
            LogPasswordLbl.AutoSize = true;
            LogPasswordLbl.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogPasswordLbl.ForeColor = Color.White;
            LogPasswordLbl.Location = new Point(67, 171);
            LogPasswordLbl.Name = "LogPasswordLbl";
            LogPasswordLbl.Size = new Size(107, 24);
            LogPasswordLbl.TabIndex = 4;
            LogPasswordLbl.Text = "Password";
            LogPasswordLbl.Click += LogPasswordLbl_Click;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = SystemColors.ButtonHighlight;
            RegisterBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterBtn.Location = new Point(314, 274);
            RegisterBtn.Margin = new Padding(3, 4, 3, 4);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(135, 52);
            RegisterBtn.TabIndex = 5;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(547, 393);
            Controls.Add(RegisterBtn);
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
        private Button RegisterBtn;
    }
}
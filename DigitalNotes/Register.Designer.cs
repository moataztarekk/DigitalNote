namespace DigitalNotes
{
    partial class Register
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
            regUsernameLbl = new Label();
            regPasswordLbl = new Label();
            regUsernameBox = new TextBox();
            regPasswordBox = new TextBox();
            registerBtn = new Button();
            SuspendLayout();
            // 
            // regUsernameLbl
            // 
            regUsernameLbl.AutoSize = true;
            regUsernameLbl.Location = new Point(69, 93);
            regUsernameLbl.Name = "regUsernameLbl";
            regUsernameLbl.Size = new Size(75, 20);
            regUsernameLbl.TabIndex = 0;
            regUsernameLbl.Text = "Username";
            // 
            // regPasswordLbl
            // 
            regPasswordLbl.AutoSize = true;
            regPasswordLbl.Location = new Point(69, 179);
            regPasswordLbl.Name = "regPasswordLbl";
            regPasswordLbl.Size = new Size(70, 20);
            regPasswordLbl.TabIndex = 1;
            regPasswordLbl.Text = "Password";
            // 
            // regUsernameBox
            // 
            regUsernameBox.Location = new Point(187, 93);
            regUsernameBox.Name = "regUsernameBox";
            regUsernameBox.Size = new Size(270, 27);
            regUsernameBox.TabIndex = 2;
            regUsernameBox.TextChanged += regUsernameBox_TextChanged;
            // 
            // regPasswordBox
            // 
            regPasswordBox.Location = new Point(187, 179);
            regPasswordBox.Name = "regPasswordBox";
            regPasswordBox.Size = new Size(270, 27);
            regPasswordBox.TabIndex = 3;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = SystemColors.Info;
            registerBtn.Location = new Point(187, 285);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(157, 48);
            registerBtn.TabIndex = 4;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(534, 412);
            Controls.Add(registerBtn);
            Controls.Add(regPasswordBox);
            Controls.Add(regUsernameBox);
            Controls.Add(regPasswordLbl);
            Controls.Add(regUsernameLbl);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label regUsernameLbl;
        private Label regPasswordLbl;
        private TextBox regUsernameBox;
        private TextBox regPasswordBox;
        private Button registerBtn;
    }
}
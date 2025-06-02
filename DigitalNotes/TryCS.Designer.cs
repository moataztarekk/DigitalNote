namespace DigitalNotes
{
    partial class TryCS
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
            categorySelectorv11 = new CategorySelectorv1();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // categorySelectorv11
            // 
            categorySelectorv11.CategorySelected = "";
            categorySelectorv11.Location = new Point(143, 92);
            categorySelectorv11.Name = "categorySelectorv11";
            categorySelectorv11.Size = new Size(345, 111);
            categorySelectorv11.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 131);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Category";
            // 
            // button1
            // 
            button1.Location = new Point(198, 233);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TryCS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 335);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(categorySelectorv11);
            Name = "TryCS";
            Text = "TryCS";
            Load += TryCS_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CategorySelectorv1 categorySelectorv11;
        private Label label1;
        private Button button1;
    }
}
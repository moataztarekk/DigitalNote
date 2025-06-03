namespace DigitalNotes
{
    partial class CategorySelectorv1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CBCategorySelector = new ComboBox();
            SuspendLayout();
            // 
            // CBCategorySelector
            // 
            CBCategorySelector.FormattingEnabled = true;
            CBCategorySelector.Location = new Point(38, 34);
            CBCategorySelector.Name = "CBCategorySelector";
            CBCategorySelector.Size = new Size(228, 28);
            CBCategorySelector.TabIndex = 0;
            //CBCategorySelector.SelectedIndexChanged += CBCategorySelector_SelectedIndexChanged;
            // 
            // CategorySelectorv1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CBCategorySelector);
            Name = "CategorySelectorv1";
            Size = new Size(350, 89);
            //Load += CategorySelectorv1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CBCategorySelector;
    }
}

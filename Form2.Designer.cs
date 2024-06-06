namespace WinFormsApp1
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelDirectoryName;
        private Label labelLastModified;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelDirectoryName = new Label();
            labelLastModified = new Label();
            SuspendLayout();
            // 
            // labelDirectoryName
            // 
            labelDirectoryName.AutoSize = true;
            labelDirectoryName.Location = new Point(12, 9);
            labelDirectoryName.Name = "labelDirectoryName";
            labelDirectoryName.Size = new Size(147, 25);
            labelDirectoryName.TabIndex = 0;
            labelDirectoryName.Text = "Название папки:";
            // 
            // labelLastModified
            // 
            labelLastModified.AutoSize = true;
            labelLastModified.Location = new Point(12, 50);
            labelLastModified.Name = "labelLastModified";
            labelLastModified.Size = new Size(264, 25);
            labelLastModified.TabIndex = 1;
            labelLastModified.Text = "Дата последней модификации:";
            labelLastModified.Click += labelLastModified_Click;
            // 
            // Form2
            // 
            ClientSize = new Size(597, 97);
            Controls.Add(labelLastModified);
            Controls.Add(labelDirectoryName);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
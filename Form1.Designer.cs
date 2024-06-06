namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            folderPathTextBox = new TextBox();
            listBoxDirectories = new ListBox();
            dataGridViewFiles = new DataGridView();
            FileName = new DataGridViewTextBoxColumn();
            LastModified = new DataGridViewTextBoxColumn();
            FileSize = new DataGridViewTextBoxColumn();
            processFilesButton = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFiles).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1878, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(78, 29);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(630, 576);
            button1.Name = "button1";
            button1.Size = new Size(163, 50);
            button1.TabIndex = 1;
            button1.Text = "Выбрать папку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // folderPathTextBox
            // 
            folderPathTextBox.BackColor = Color.DimGray;
            folderPathTextBox.Location = new Point(570, 505);
            folderPathTextBox.Multiline = true;
            folderPathTextBox.Name = "folderPathTextBox";
            folderPathTextBox.ReadOnly = true;
            folderPathTextBox.Size = new Size(266, 56);
            folderPathTextBox.TabIndex = 2;
            folderPathTextBox.TextChanged += textBox1_TextChanged;
            // 
            // listBoxDirectories
            // 
            listBoxDirectories.BackColor = Color.Gray;
            listBoxDirectories.FormattingEnabled = true;
            listBoxDirectories.ItemHeight = 25;
            listBoxDirectories.Location = new Point(570, 207);
            listBoxDirectories.Name = "listBoxDirectories";
            listBoxDirectories.Size = new Size(269, 279);
            listBoxDirectories.TabIndex = 3;
            listBoxDirectories.DoubleClick += listBox1_SelectedIndexChanged;
            // 
            // dataGridViewFiles
            // 
            dataGridViewFiles.BackgroundColor = Color.DarkGray;
            dataGridViewFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFiles.Columns.AddRange(new DataGridViewColumn[] { FileName, LastModified, FileSize });
            dataGridViewFiles.Location = new Point(868, 207);
            dataGridViewFiles.Name = "dataGridViewFiles";
            dataGridViewFiles.RowHeadersWidth = 62;
            dataGridViewFiles.Size = new Size(669, 354);
            dataGridViewFiles.TabIndex = 4;
            dataGridViewFiles.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FileName
            // 
            FileName.HeaderText = "Имя файла";
            FileName.MinimumWidth = 8;
            FileName.Name = "FileName";
            FileName.Width = 150;
            // 
            // LastModified
            // 
            LastModified.HeaderText = "Дата последней модификации";
            LastModified.MinimumWidth = 8;
            LastModified.Name = "LastModified";
            LastModified.Width = 150;
            // 
            // FileSize
            // 
            FileSize.HeaderText = "Размер в байтах";
            FileSize.MinimumWidth = 8;
            FileSize.Name = "FileSize";
            FileSize.Width = 150;
            // 
            // processFilesButton
            // 
            processFilesButton.BackgroundImage = Properties.Resources.Routing_Lab___1_;
            processFilesButton.Location = new Point(1170, 576);
            processFilesButton.Name = "processFilesButton";
            processFilesButton.Size = new Size(112, 50);
            processFilesButton.TabIndex = 5;
            processFilesButton.Text = "Обработка";
            processFilesButton.UseVisualStyleBackColor = true;
            processFilesButton.Visible = false;
            processFilesButton.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1878, 894);
            Controls.Add(processFilesButton);
            Controls.Add(dataGridViewFiles);
            Controls.Add(listBoxDirectories);
            Controls.Add(folderPathTextBox);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveCaptionText;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button button1;
        private TextBox folderPathTextBox;
        private ListBox listBoxDirectories;
        private DataGridView dataGridViewFiles;
        private Button processFilesButton;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn LastModified;
        private DataGridViewTextBoxColumn FileSize;
    }
}

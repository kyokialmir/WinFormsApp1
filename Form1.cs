namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;



        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Кашкаров Альмир\nEmail: kyokialmir@auca.kg", "About");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    folderPathTextBox.Text = selectedPath;
                    LoadDirectories(selectedPath);
                    LoadFiles(selectedPath);
                    processFilesButton.Visible = true;
                }
            }
        }
        private void LoadDirectories(string path)
        {
            listBoxDirectories.Items.Clear();
            var directories = Directory.GetDirectories(path);
            foreach (var dir in directories)
            {
                listBoxDirectories.Items.Add(new DirectoryInfo(dir).Name);
            }
        }

        private void LoadFiles(string path)
        {
            dataGridViewFiles.Rows.Clear();
            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                dataGridViewFiles.Rows.Add(fileInfo.Name, fileInfo.LastWriteTime, fileInfo.Length);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDirectories.SelectedItem != null)
            {
                string selectedDirectory = Path.Combine(folderPathTextBox.Text, listBoxDirectories.SelectedItem.ToString());
                var directoryInfo = new DirectoryInfo(selectedDirectory);
                var infoForm = new Form2(directoryInfo);
                infoForm.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fileName = dataGridViewFiles.Rows[e.RowIndex].Cells[0].Value.ToString();
                var filePath = Path.Combine(folderPathTextBox.Text, fileName);

                var result = MessageBox.Show($"Продублировать файл {fileName}?", "Дублирование файла", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var newFilePath = Path.Combine(folderPathTextBox.Text, Path.GetFileNameWithoutExtension(fileName) + "_copy" + Path.GetExtension(fileName));
                    File.Copy(filePath, newFilePath);
                    LoadFiles(folderPathTextBox.Text);
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var files = Directory.GetFiles(folderPathTextBox.Text);
            var random = new Random();
            var fileDelays = new List<(string FileName, int Delay)>();

            foreach (var file in files)
            {
                int delay = random.Next(1, files.Length + 1);
                fileDelays.Add((Path.GetFileName(file), delay));
            }

         
            fileDelays = fileDelays.OrderBy(fd => fd.Delay).ToList();


            if (!dataGridViewFiles.Columns.Contains("Задержка"))
            {
                var delayColumn = new DataGridViewTextBoxColumn
                {
                    Name = "Задержка",
                    HeaderText = "Задержка (с)"
                };
                dataGridViewFiles.Columns.Add(delayColumn);
            }

            foreach (var fileDelay in fileDelays)
            {
                string fileName = fileDelay.FileName;
                int delay = fileDelay.Delay;

                await Task.Delay(delay * 1000);

                foreach (DataGridViewRow row in dataGridViewFiles.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == fileName)
                    {
                        row.Cells["Задержка"].Value = delay;
                        break;
                    }
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

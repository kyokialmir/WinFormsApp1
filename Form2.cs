using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2(DirectoryInfo directoryInfo)
        {
            InitializeComponent();
            labelDirectoryName.Text = $"Название папки: {directoryInfo.Name}";
            labelLastModified.Text = $"Дата последней модификации: {directoryInfo.LastWriteTime}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void labelLastModified_Click(object sender, EventArgs e)
        {

        }
    }
}

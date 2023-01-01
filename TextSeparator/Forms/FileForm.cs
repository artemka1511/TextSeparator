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
using TextSeparator.Forms;

namespace TextSeparator
{
    public partial class FileForm : Form
    {
        public FileForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void SeparateButton_Click(object sender, EventArgs e)
        {
            if (PathLabel.Text == string.Empty)
            {
                MessageBox.Show("You need to select a file!");
                return;
            }

            string textFromFile = ReadFile(PathLabel.Text);

            Hide();
            ResultForm resultForm = new ResultForm();
            resultForm.Show();

            string[] result = textFromFile.Split(new string[1] { SeparatorTextBox.Text }, StringSplitOptions.None);

            foreach (var item in result)
                resultForm.ResultTextBox.SelectedText = item + Environment.NewLine + Environment.NewLine;
        }

        private void BrowseFileButton_Click(object sender, EventArgs e)
        {
            PathLabel.Text = string.Empty;

            var dialog = new OpenFileDialog();
            dialog.ShowDialog();

            CheckFile(dialog.FileName);  
        }

        private void CheckFile(string path)
        {
            string extension = System.IO.Path.GetExtension(path);

            if (extension != ".txt")
            {
                MessageBox.Show("Error: Need txt file !");
                return;
            }

            if (path != string.Empty)
                PathLabel.Text = path;
        }

        private string ReadFile(string path)
        {
            FileStream fstream = File.OpenRead(PathLabel.Text);
            byte[] buffer = new byte[fstream.Length];
            fstream.Read(buffer, 0, buffer.Length);
            string textFromFile = Encoding.Default.GetString(buffer);
            return textFromFile;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }
    }
}

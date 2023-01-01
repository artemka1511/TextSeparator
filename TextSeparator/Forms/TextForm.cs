using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextSeparator.Forms
{
    public partial class TextForm : Form
    {
        public TextForm()
        {
            InitializeComponent();
        }

        private void SeparateButton_Click(object sender, EventArgs e)
        {
            string[] result = TextBox.Text.Split(new string[1] { SeparatorTextBox.Text }, StringSplitOptions.None);
            Hide();
            ResultForm resultForm = new ResultForm();
            resultForm.Show();

            foreach (var item in result)
                resultForm.ResultTextBox.SelectedText = item + Environment.NewLine + Environment.NewLine;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }
    }
}

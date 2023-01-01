using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextSeparator.Forms;

namespace TextSeparator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            Hide();
            FileForm fileForm = new FileForm();
            fileForm.Show();
        }

        private void SelectTextButton_Click(object sender, EventArgs e)
        {
            Hide();
            TextForm textForm = new TextForm();
            textForm.Show();
        }
    }
}

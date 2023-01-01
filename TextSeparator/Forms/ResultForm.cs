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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void RepeatButton_Click(object sender, EventArgs e)
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

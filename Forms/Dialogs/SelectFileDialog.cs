using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPBS.Dialogs
{
    public partial class SelectFileDialog : Form
    {
        public string FilePath { get; set; }
        public string Label { get; set; }
        public DialogResult Filter { get; internal set; }

        public SelectFileDialog()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.ShowDialog();
            txtFileName.Text = dialog.FileName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FilePath = txtFileName.Text;
            Label = txtLabel.Text;

            if (FilePath.Length == 0)
            {
                MessageBox.Show("Please select file");
                return;
            }

            if (Label.Length == 0)
            {
                MessageBox.Show("Please enter label");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

using System;
using System.Deployment.Application;
using System.Windows.Forms;

namespace SPBS.Dialogs
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            var title = Application.ProductName;

            lblTitle.Text = title;
            lblCompany.Text = "Joshua Kyte";
            lblCopyright.Text = "Copyright ©  2017";



            var version = Application.ProductVersion;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                version = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();

                lblVersion.Text = "Version: " + version;
            }
        }

        private void LblCopyright_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblVersion_Click(object sender, EventArgs e)
        {

        }

        private void lblCompany_Click(object sender, EventArgs e)
        {

        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }
    }
}

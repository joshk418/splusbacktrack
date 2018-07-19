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
            var version = Application.ProductVersion;

            lblTitle.Text = title;
            lblCompany.Text = "Joshua Kyte";
            lblCopyright.Text = "Copyright ©  2017";

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                version = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();

                lblVersion.Text = "Version: " + version;
            }
        }
    }
}

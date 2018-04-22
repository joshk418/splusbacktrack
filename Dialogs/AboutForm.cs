using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPBS.Dialogs
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            var title = Application.ProductName;
            var company = Application.CompanyName;

            lblTitle.Text = title;
            lblCompany.Text = company;
            lblCopyright.Text = "Copyright ©  2017";



            var version = Application.ProductVersion;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                version = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();

                lblVersion.Text = "Version: " + version;
            }
        }

        private void lblCopyright_Click(object sender, EventArgs e)
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SPBS.Dialogs;
using System.Deployment.Application;
using System.Diagnostics.Eventing.Reader;

namespace SPBS
{
    public partial class Form1 : Form
    {
        public string FilePath1 { get; set; }
        public string FilePath2 { get; set; }
        public string FilePath3 { get; set; }
        public string FilePath4 { get; set; }
        public string FilePath5 { get; set; }
        public string FilePath6 { get; set; }
        public string FilePath7 { get; set; }
        public string FilePath8 { get; set; }
        public string FilePath9 { get; set; }
        public string FilePath10 { get; set; }

        public new static string ProductVersion { get; }
        public Keys KeyCode { get; private set; }

        //Test Commit to new branch

        public Form1()
        {
            InitializeComponent();
            FilePath1 = Properties.Settings.Default.FilePath1;
            FilePath2 = Properties.Settings.Default.FilePath2;
            FilePath3 = Properties.Settings.Default.FilePath3;
            FilePath4 = Properties.Settings.Default.FilePath4;
            FilePath5 = Properties.Settings.Default.FilePath5;
            FilePath6 = Properties.Settings.Default.FilePath6;
            FilePath7 = Properties.Settings.Default.FilePath7;
            FilePath8 = Properties.Settings.Default.FilePath8;

            lblFileName1.Text = FilePath1;
            lblFileName2.Text = FilePath2;
            lblFileName3.Text = FilePath3;
            lblFileName4.Text = FilePath4;
            lblFileName5.Text = FilePath5;
            lblFileName6.Text = FilePath6;
            lblFileName7.Text = FilePath7;
            
            button1.Text = Properties.Settings.Default.Label1;
            button2.Text = Properties.Settings.Default.Label2;
            button3.Text = Properties.Settings.Default.Label3;
            button4.Text = Properties.Settings.Default.Label4;
            button5.Text = Properties.Settings.Default.Label5;
            button6.Text = Properties.Settings.Default.Label6;
            button7.Text = Properties.Settings.Default.Label7;


            //var version = Application.ProductVersion;

            //if (ApplicationDeployment.IsNetworkDeployed)
            //{
            //    version = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();

            //    lblVersion.Text = "Version: " + version;
            //}

            mediaPlayer.settings.volume = 100;
        }

        private void PlaySong(string filePath)
        {
            var url = filePath;
            if (!File.Exists(url))
            {
                MessageBox.Show("File Not Found");
                return;
            }

            mediaPlayer.URL = url;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlaySong(FilePath1);
        }
        private void button2_Click(object sender, EventArgs e)
         {
            PlaySong(FilePath2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlaySong(FilePath3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlaySong(FilePath4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PlaySong(FilePath5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PlaySong(FilePath6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PlaySong(FilePath7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PlaySong(FilePath8);
        }
        

        


        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            var dialog = new SelectFileDialog();
            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                var filePath = dialog.FilePath;
                var label = dialog.Label;

                FilePath1 = filePath;
                lblFileName1.Text = filePath;
                button1.Text = label;

                //Save Settings
                Properties.Settings.Default.FilePath1 = filePath;
                Properties.Settings.Default.Label1 = label;
                Properties.Settings.Default.Save();
            }

            dialog.Dispose();
        }

        private void btnSelectFile2_Click(object sender, EventArgs e)
        {
            var dialog = new SelectFileDialog();
            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                var filePath = dialog.FilePath;
                var label = dialog.Label;

                FilePath2 = filePath;
                lblFileName2.Text = filePath;
                button2.Text = label;

                //Save Settings
                Properties.Settings.Default.FilePath2 = filePath;
                Properties.Settings.Default.Label2 = label;
                Properties.Settings.Default.Save();
            }

            dialog.Dispose();
        }

        private void btnSelectFile3_Click(object sender, EventArgs e)
        {
            var dialog = new SelectFileDialog();
            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                var filePath = dialog.FilePath;
                var label = dialog.Label;

                FilePath3 = filePath;
                lblFileName3.Text = filePath;
                button3.Text = label;

                //Save Settings
                Properties.Settings.Default.FilePath3 = filePath;
                Properties.Settings.Default.Label3 = label;
                Properties.Settings.Default.Save();
            }

            dialog.Dispose();
        }

        private void btnSelectFile4_Click(object sender, EventArgs e)
        {
            var dialog = new SelectFileDialog();
            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                var filePath = dialog.FilePath;
                var label = dialog.Label;

                FilePath4 = filePath;
                lblFileName4.Text = filePath;
                button4.Text = label;

                //Save Settings
                Properties.Settings.Default.FilePath4 = filePath;
                Properties.Settings.Default.Label4 = label;
                Properties.Settings.Default.Save();
            }

            dialog.Dispose();
        }

        private void btnSelectFile5_Click(object sender, EventArgs e)
        {
            var dialog = new SelectFileDialog();
            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                var filePath = dialog.FilePath;
                var label = dialog.Label;

                FilePath5 = filePath;
                lblFileName5.Text = filePath;
                button5.Text = label;

                //Save Settings
                Properties.Settings.Default.FilePath5 = filePath;
                Properties.Settings.Default.Label5 = label;
                Properties.Settings.Default.Save();
            }

            dialog.Dispose();
        }

        private void btnSelectFile6_Click(object sender, EventArgs e)
        {
            var dialog = new SelectFileDialog();
            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                var filePath = dialog.FilePath;
                var label = dialog.Label;

                FilePath6 = filePath;
                lblFileName6.Text = filePath;
                button6.Text = label;

                //Save Settings
                Properties.Settings.Default.FilePath6 = filePath;
                Properties.Settings.Default.Label6 = label;
                Properties.Settings.Default.Save();
            }

            dialog.Dispose();
        }

        private void btnSelectFile7_Click(object sender, EventArgs e)
        {
            var dialog = new SelectFileDialog();
            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                var filePath = dialog.FilePath;
                var label = dialog.Label;

                FilePath7 = filePath;
                lblFileName7.Text = filePath;
                button7.Text = label;

                //Save Settings
                Properties.Settings.Default.FilePath7 = filePath;
                Properties.Settings.Default.Label7 = label;
                Properties.Settings.Default.Save();
            }

            dialog.Dispose();
        }
        

        private void lblVersion_Click(object sender, EventArgs e)
        {
            var aboutdialog = new AboutForm();
            aboutdialog.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // lblVersion.Text = "Version:" + Application.ProductVersion;

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    mediaPlayer.Ctlcontrols.stop();
                    break;
                case Keys.D1:
                    PlaySong(FilePath1);
                    break;
                case Keys.D2:
                    PlaySong(FilePath2);
                    break;
                case Keys.D3:
                    PlaySong(FilePath3);
                    break;
                case Keys.D4:
                    PlaySong(FilePath4);
                    break;
                case Keys.D5:
                    PlaySong(FilePath5);
                    break;
                case Keys.D6:
                    PlaySong(FilePath6);
                    break;
                case Keys.D7:
                    PlaySong(FilePath7);
                    break;
                

            }

        }
    }
}
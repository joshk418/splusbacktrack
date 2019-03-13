using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SPBS.Dialogs;
using SPBS.Models;
using System.Deployment.Application;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace SPBS
{
    public partial class MainForm : Form
    {
        const string FILE_INFO_FILEPATH = @"..\\SongData\\mediainfo.txt";

        /*
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
        */

        public new static string ProductVersion { get; }
        public Keys KeyCode { get; private set; }

        private List<Button> PlayButtonList;
        private List<Button> SelectFileButtonList;
        private List<MediaFile> MediaFileList;
        private List<string> mediaInfoFile = File.ReadAllLines(FILE_INFO_FILEPATH).ToList();

        public MainForm()
        {
            InitializeComponent();



            /*
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
            */
            var properties = Properties.Settings.Default;
            
            MediaFileList = new List<MediaFile> { };

            foreach (var line in mediaInfoFile)
            {
                var info = line.Split('|');
                MediaFileList.Add(new MediaFile(info[0], info[1]));
            }
           
            PlayButtonList = new List<Button>
            {
                button1,
                button2

            };

            SelectFileButtonList = new List<Button>
            {
                btnSelectFile1,
                btnSelectFile2
            };

            

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

        private void SelectFile(object button, EventArgs e)
        {
            var buttonIndex = GetButtonIndex(button);
            var pressedPlayButton = PlayButtonList[buttonIndex];
            var dialog = new SelectFileDialog();
            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                var filePath = dialog.FilePath;
                var label = dialog.Label;

                MediaFileList[buttonIndex].FilePath = filePath;
                PlayButtonList[buttonIndex].Text = label;

                ResetFileStorage();
            }

            dialog.Dispose();
        }
        

        private void PlayButton_Click(object button, EventArgs e)
        {
            var buttonIndex = GetButtonIndex(button);
            PlaySong(MediaFileList[buttonIndex].FilePath);
            Console.WriteLine(MediaFileList[buttonIndex].FilePath);
        }

        private int GetButtonIndex(object button)
        {
            for(var i = 0; i < PlayButtonList.Count; i++)
            {
                if(button == PlayButtonList[i])
                {
                    return i;
                }
            }

            for (var i = 0; i < SelectFileButtonList.Count; i++)
            {
                if (button == SelectFileButtonList[i])
                {
                    return i;
                }
            }

            return -1;
        }

        private void ResetFileStorage()
        {
            File.WriteAllText(FILE_INFO_FILEPATH, string.Empty);

            for(var i = 0; i < MediaFileList.Count; i++)
            {
                mediaInfoFile.Add($"{MediaFileList[i].FilePath}|{MediaFileList[i].Label}");
                File.WriteAllLines(FILE_INFO_FILEPATH, mediaInfoFile);
            }
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {
            var aboutdialog = new AboutForm();
            aboutdialog.ShowDialog();
        }

        private void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            /*
            switch (e.KeyCode)
            {
                case Keys.Space:
                    if (mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        mediaPlayer.Ctlcontrols.pause();
                    }
                    else
                    {
                        mediaPlayer.Ctlcontrols.play();
                    }
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
            */

        }
    }
}
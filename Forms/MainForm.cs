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

        public new static string ProductVersion { get; }
        public Keys KeyCode { get; private set; }

        private List<Button> PlayButtonList;
        private List<Button> SelectFileButtonList;
        private List<Label> SongLabelList;
        private List<MediaFile> MediaFileList;
        private List<string> mediaInfoFile = File.ReadAllLines(FILE_INFO_FILEPATH).ToList();

        public MainForm()
        {
            InitializeComponent();
            
            // TODO: Create way for user to add new button            
            
            MediaFileList = new List<MediaFile> { };

            PlayButtonList = new List<Button>
            {
                button1,
                button2,
                button3,
                button4,
                button5,
                button6,
                button7
            };

            SelectFileButtonList = new List<Button>
            {
                btnSelectFile1,
                btnSelectFile2,
                btnSelectFile3,
                btnSelectFile4,
                btnSelectFile5,
                btnSelectFile6,
                btnSelectFile7
            };

            SongLabelList = new List<Label>
            {
                lblFileName1,
                lblFileName2,
                lblFileName3,
                lblFileName4,
                lblFileName5,
                lblFileName6,
                lblFileName7
            };
            
            foreach (var line in mediaInfoFile)
            {
                var info = line.Split('|');
                MediaFileList.Add(new MediaFile(info[0], info[1]));
            }

            UpdateUIText();

            mediaPlayer.settings.volume = 100;
        }        

        private void SelectFile(object button, EventArgs e)
        {
            var buttonIndex = GetButtonIndex(button);
            var pressedPlayButton = PlayButtonList[buttonIndex];
            var dialog = new SelectFileDialog();

            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                EditMediaFileInformation(buttonIndex, dialog.FilePath, dialog.Label);                
            }

            dialog.Dispose();
        }
        

        private void PlayButton_Click(object button, EventArgs e)
        {
            var buttonIndex = GetButtonIndex(button);
            PlaySong(MediaFileList[buttonIndex].FilePath);
            ResetFileStorage();
            Console.WriteLine(MediaFileList[buttonIndex].FilePath);
        }

        private void PlaySong(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File Not Found");
                return;
            }
            mediaPlayer.URL = filePath;
        }

        private void UpdateUIText()
        {
            for(var i = 0; i < MediaFileList.Count; i++)
            {
                EditMediaFileInformation(i, MediaFileList[i].FilePath, MediaFileList[i].Label);
            }
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

        private void EditMediaFileInformation(int index, string filePath, string label)
        {
            MediaFileList[index].FilePath = filePath;
            SongLabelList[index].Text = filePath;
            PlayButtonList[index].Text = label;
            MediaFileList[index].Label = label;
        }

        private void ResetFileStorage()
        {
            File.WriteAllText(FILE_INFO_FILEPATH, string.Empty);

            for (var i = 0; i < mediaInfoFile.Count; i++)
            {
                mediaInfoFile[i] = $"{MediaFileList[i].FilePath}|{MediaFileList[i].Label}";                
            }

            File.WriteAllLines(FILE_INFO_FILEPATH, mediaInfoFile);
        }

        private void LblVersion_Click(object sender, EventArgs e)
        {
            var aboutdialog = new AboutForm();
            aboutdialog.ShowDialog();
        }

        private void MainForm_KeyPress(object sender, KeyEventArgs e)
        {
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
            }

        }
    }
}
namespace SPBS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelectFile1 = new System.Windows.Forms.Button();
            this.lblFileName1 = new System.Windows.Forms.Label();
            this.lblFileName2 = new System.Windows.Forms.Label();
            this.btnSelectFile2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblFileName3 = new System.Windows.Forms.Label();
            this.btnSelectFile3 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblFileName4 = new System.Windows.Forms.Label();
            this.btnSelectFile4 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblFileName5 = new System.Windows.Forms.Label();
            this.btnSelectFile5 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblFileName6 = new System.Windows.Forms.Label();
            this.btnSelectFile6 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblFileName7 = new System.Windows.Forms.Label();
            this.btnSelectFile7 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblAbout = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(11, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Song";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // btnSelectFile1
            // 
            this.btnSelectFile1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelectFile1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSelectFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectFile1.Location = new System.Drawing.Point(224, 109);
            this.btnSelectFile1.Name = "btnSelectFile1";
            this.btnSelectFile1.Size = new System.Drawing.Size(35, 29);
            this.btnSelectFile1.TabIndex = 2;
            this.btnSelectFile1.Text = "...";
            this.btnSelectFile1.UseVisualStyleBackColor = false;
            this.btnSelectFile1.Click += new System.EventHandler(this.SelectFile);
            // 
            // lblFileName1
            // 
            this.lblFileName1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFileName1.AutoEllipsis = true;
            this.lblFileName1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblFileName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFileName1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileName1.Location = new System.Drawing.Point(11, 91);
            this.lblFileName1.MaximumSize = new System.Drawing.Size(200, 13);
            this.lblFileName1.Name = "lblFileName1";
            this.lblFileName1.Size = new System.Drawing.Size(200, 13);
            this.lblFileName1.TabIndex = 3;
            this.lblFileName1.Text = "Filepath";
            // 
            // lblFileName2
            // 
            this.lblFileName2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFileName2.AutoEllipsis = true;
            this.lblFileName2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblFileName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFileName2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileName2.Location = new System.Drawing.Point(11, 175);
            this.lblFileName2.MaximumSize = new System.Drawing.Size(200, 13);
            this.lblFileName2.Name = "lblFileName2";
            this.lblFileName2.Size = new System.Drawing.Size(200, 13);
            this.lblFileName2.TabIndex = 6;
            this.lblFileName2.Text = "Filepath";
            // 
            // btnSelectFile2
            // 
            this.btnSelectFile2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelectFile2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSelectFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectFile2.Location = new System.Drawing.Point(224, 191);
            this.btnSelectFile2.Name = "btnSelectFile2";
            this.btnSelectFile2.Size = new System.Drawing.Size(35, 29);
            this.btnSelectFile2.TabIndex = 5;
            this.btnSelectFile2.Text = "...";
            this.btnSelectFile2.UseVisualStyleBackColor = false;
            this.btnSelectFile2.Click += new System.EventHandler(this.SelectFile);
            // 
            // button2
            // 
            this.button2.AllowDrop = true;
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(11, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "Song";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // lblFileName3
            // 
            this.lblFileName3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFileName3.AutoEllipsis = true;
            this.lblFileName3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblFileName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFileName3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileName3.Location = new System.Drawing.Point(11, 253);
            this.lblFileName3.MaximumSize = new System.Drawing.Size(200, 13);
            this.lblFileName3.Name = "lblFileName3";
            this.lblFileName3.Size = new System.Drawing.Size(200, 13);
            this.lblFileName3.TabIndex = 9;
            this.lblFileName3.Text = "Filepath";
            // 
            // btnSelectFile3
            // 
            this.btnSelectFile3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelectFile3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSelectFile3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectFile3.Location = new System.Drawing.Point(224, 269);
            this.btnSelectFile3.Name = "btnSelectFile3";
            this.btnSelectFile3.Size = new System.Drawing.Size(35, 29);
            this.btnSelectFile3.TabIndex = 8;
            this.btnSelectFile3.Text = "...";
            this.btnSelectFile3.UseVisualStyleBackColor = false;
            this.btnSelectFile3.Click += new System.EventHandler(this.SelectFile);
            // 
            // button3
            // 
            this.button3.AllowDrop = true;
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(11, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 52);
            this.button3.TabIndex = 7;
            this.button3.Text = "Song";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // lblFileName4
            // 
            this.lblFileName4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFileName4.AutoEllipsis = true;
            this.lblFileName4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblFileName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFileName4.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileName4.Location = new System.Drawing.Point(11, 333);
            this.lblFileName4.MaximumSize = new System.Drawing.Size(200, 13);
            this.lblFileName4.Name = "lblFileName4";
            this.lblFileName4.Size = new System.Drawing.Size(200, 13);
            this.lblFileName4.TabIndex = 12;
            this.lblFileName4.Text = "Filepath";
            // 
            // btnSelectFile4
            // 
            this.btnSelectFile4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelectFile4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSelectFile4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectFile4.Location = new System.Drawing.Point(224, 349);
            this.btnSelectFile4.Name = "btnSelectFile4";
            this.btnSelectFile4.Size = new System.Drawing.Size(35, 29);
            this.btnSelectFile4.TabIndex = 11;
            this.btnSelectFile4.Text = "...";
            this.btnSelectFile4.UseVisualStyleBackColor = false;
            this.btnSelectFile4.Click += new System.EventHandler(this.SelectFile);
            // 
            // button4
            // 
            this.button4.AllowDrop = true;
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(11, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 52);
            this.button4.TabIndex = 10;
            this.button4.Text = "Song";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // lblFileName5
            // 
            this.lblFileName5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFileName5.AutoEllipsis = true;
            this.lblFileName5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblFileName5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFileName5.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileName5.Location = new System.Drawing.Point(11, 413);
            this.lblFileName5.MaximumSize = new System.Drawing.Size(200, 13);
            this.lblFileName5.Name = "lblFileName5";
            this.lblFileName5.Size = new System.Drawing.Size(200, 13);
            this.lblFileName5.TabIndex = 15;
            this.lblFileName5.Text = "Filepath";
            // 
            // btnSelectFile5
            // 
            this.btnSelectFile5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelectFile5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSelectFile5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectFile5.Location = new System.Drawing.Point(224, 429);
            this.btnSelectFile5.Name = "btnSelectFile5";
            this.btnSelectFile5.Size = new System.Drawing.Size(35, 29);
            this.btnSelectFile5.TabIndex = 14;
            this.btnSelectFile5.Text = "...";
            this.btnSelectFile5.UseVisualStyleBackColor = false;
            this.btnSelectFile5.Click += new System.EventHandler(this.SelectFile);
            // 
            // button5
            // 
            this.button5.AllowDrop = true;
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(11, 429);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 52);
            this.button5.TabIndex = 13;
            this.button5.Text = "Song";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // lblFileName6
            // 
            this.lblFileName6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFileName6.AutoEllipsis = true;
            this.lblFileName6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblFileName6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFileName6.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileName6.Location = new System.Drawing.Point(11, 493);
            this.lblFileName6.MaximumSize = new System.Drawing.Size(200, 13);
            this.lblFileName6.Name = "lblFileName6";
            this.lblFileName6.Size = new System.Drawing.Size(200, 13);
            this.lblFileName6.TabIndex = 18;
            this.lblFileName6.Text = "Filepath";
            this.toolTip1.SetToolTip(this.lblFileName6, "lblFileName6.Text");
            // 
            // btnSelectFile6
            // 
            this.btnSelectFile6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelectFile6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSelectFile6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectFile6.Location = new System.Drawing.Point(224, 509);
            this.btnSelectFile6.Name = "btnSelectFile6";
            this.btnSelectFile6.Size = new System.Drawing.Size(35, 29);
            this.btnSelectFile6.TabIndex = 17;
            this.btnSelectFile6.Text = "...";
            this.btnSelectFile6.UseVisualStyleBackColor = false;
            this.btnSelectFile6.Click += new System.EventHandler(this.SelectFile);
            // 
            // button6
            // 
            this.button6.AllowDrop = true;
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(11, 509);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(204, 52);
            this.button6.TabIndex = 16;
            this.button6.Text = "Song";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // lblFileName7
            // 
            this.lblFileName7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFileName7.AutoEllipsis = true;
            this.lblFileName7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblFileName7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFileName7.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileName7.Location = new System.Drawing.Point(11, 573);
            this.lblFileName7.MaximumSize = new System.Drawing.Size(200, 13);
            this.lblFileName7.Name = "lblFileName7";
            this.lblFileName7.Size = new System.Drawing.Size(200, 13);
            this.lblFileName7.TabIndex = 21;
            this.lblFileName7.Text = "Filepath";
            // 
            // btnSelectFile7
            // 
            this.btnSelectFile7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelectFile7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSelectFile7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectFile7.Location = new System.Drawing.Point(224, 589);
            this.btnSelectFile7.Name = "btnSelectFile7";
            this.btnSelectFile7.Size = new System.Drawing.Size(35, 29);
            this.btnSelectFile7.TabIndex = 20;
            this.btnSelectFile7.Text = "...";
            this.btnSelectFile7.UseVisualStyleBackColor = false;
            this.btnSelectFile7.Click += new System.EventHandler(this.SelectFile);
            // 
            // button7
            // 
            this.button7.AllowDrop = true;
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(11, 589);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(204, 52);
            this.button7.TabIndex = 19;
            this.button7.Text = "Song";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(302, 83);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(704, 596);
            this.mediaPlayer.TabIndex = 0;
            // 
            // lblAbout
            // 
            this.lblAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAbout.AutoSize = true;
            this.lblAbout.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblAbout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAbout.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAbout.Location = new System.Drawing.Point(14, 651);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(20, 22);
            this.lblAbout.TabIndex = 31;
            this.lblAbout.Text = "?";
            this.toolTip1.SetToolTip(this.lblAbout, "About Information");
            this.lblAbout.Click += new System.EventHandler(this.LblVersion_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblAbout);
            this.panel1.Controls.Add(this.btnSelectFile1);
            this.panel1.Controls.Add(this.lblFileName1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnSelectFile2);
            this.panel1.Controls.Add(this.lblFileName2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnSelectFile3);
            this.panel1.Controls.Add(this.lblFileName3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnSelectFile4);
            this.panel1.Controls.Add(this.lblFileName7);
            this.panel1.Controls.Add(this.lblFileName4);
            this.panel1.Controls.Add(this.btnSelectFile7);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btnSelectFile5);
            this.panel1.Controls.Add(this.lblFileName6);
            this.panel1.Controls.Add(this.lblFileName5);
            this.panel1.Controls.Add(this.btnSelectFile6);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 681);
            this.panel1.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 74);
            this.panel3.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(41, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 58);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tracks";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(115, 658);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 79);
            this.panel2.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 64);
            this.label2.TabIndex = 2;
            this.label2.Text = "S-Plus Backtrack Studio";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S-Plus Backtrack Studio (Test)";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelectFile1;
        private System.Windows.Forms.Label lblFileName1;
        private System.Windows.Forms.Label lblFileName2;
        private System.Windows.Forms.Button btnSelectFile2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblFileName3;
        private System.Windows.Forms.Button btnSelectFile3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblFileName4;
        private System.Windows.Forms.Button btnSelectFile4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblFileName5;
        private System.Windows.Forms.Button btnSelectFile5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblFileName6;
        private System.Windows.Forms.Button btnSelectFile6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblFileName7;
        private System.Windows.Forms.Button btnSelectFile7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}


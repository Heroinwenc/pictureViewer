
namespace pictureViewer
{
    partial class Form1
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
            this.btnResimSec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnKlasorSec = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkOrderly = new System.Windows.Forms.CheckBox();
            this.chkSlideShow = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnkclt = new System.Windows.Forms.Button();
            this.btnbyt = new System.Windows.Forms.Button();
            this.ayarbutton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ayarbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResimSec
            // 
            this.btnResimSec.BackColor = System.Drawing.Color.Coral;
            this.btnResimSec.Location = new System.Drawing.Point(78, 529);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(97, 36);
            this.btnResimSec.TabIndex = 0;
            this.btnResimSec.Text = "Select A Picture";
            this.btnResimSec.UseVisualStyleBackColor = false;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 459);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnKlasorSec
            // 
            this.btnKlasorSec.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnKlasorSec.Location = new System.Drawing.Point(78, 488);
            this.btnKlasorSec.Name = "btnKlasorSec";
            this.btnKlasorSec.Size = new System.Drawing.Size(97, 36);
            this.btnKlasorSec.TabIndex = 3;
            this.btnKlasorSec.Text = "Choose Folder";
            this.btnKlasorSec.UseVisualStyleBackColor = false;
            this.btnKlasorSec.Click += new System.EventHandler(this.btnKlasorSec_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkOrderly);
            this.groupBox1.Controls.Add(this.chkSlideShow);
            this.groupBox1.Location = new System.Drawing.Point(311, 488);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 81);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slide Show";
            // 
            // chkOrderly
            // 
            this.chkOrderly.AutoSize = true;
            this.chkOrderly.Checked = true;
            this.chkOrderly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOrderly.Location = new System.Drawing.Point(71, 41);
            this.chkOrderly.Name = "chkOrderly";
            this.chkOrderly.Size = new System.Drawing.Size(59, 17);
            this.chkOrderly.TabIndex = 1;
            this.chkOrderly.Text = "Orderly";
            this.chkOrderly.UseVisualStyleBackColor = true;
            this.chkOrderly.CheckedChanged += new System.EventHandler(this.chkOrderly_CheckedChanged);
            // 
            // chkSlideShow
            // 
            this.chkSlideShow.AutoSize = true;
            this.chkSlideShow.Location = new System.Drawing.Point(6, 41);
            this.chkSlideShow.Name = "chkSlideShow";
            this.chkSlideShow.Size = new System.Drawing.Size(59, 17);
            this.chkSlideShow.TabIndex = 0;
            this.chkSlideShow.Text = "Enable";
            this.chkSlideShow.UseVisualStyleBackColor = true;
            this.chkSlideShow.CheckedChanged += new System.EventHandler(this.chkSlideShow_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(18, 21);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(162, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 90;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnkclt);
            this.groupBox2.Controls.Add(this.btnbyt);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Location = new System.Drawing.Point(505, 488);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 81);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zoom Settings";
            // 
            // btnkclt
            // 
            this.btnkclt.Location = new System.Drawing.Point(198, 43);
            this.btnkclt.Name = "btnkclt";
            this.btnkclt.Size = new System.Drawing.Size(75, 23);
            this.btnkclt.TabIndex = 4;
            this.btnkclt.Text = "Small";
            this.btnkclt.UseVisualStyleBackColor = true;
            this.btnkclt.Click += new System.EventHandler(this.btnkclt_Click);
            // 
            // btnbyt
            // 
            this.btnbyt.Location = new System.Drawing.Point(198, 19);
            this.btnbyt.Name = "btnbyt";
            this.btnbyt.Size = new System.Drawing.Size(75, 23);
            this.btnbyt.TabIndex = 3;
            this.btnbyt.Text = "Big";
            this.btnbyt.UseVisualStyleBackColor = true;
            this.btnbyt.Click += new System.EventHandler(this.btnbyt_Click);
            // 
            // ayarbutton
            // 
            this.ayarbutton.Image = global::pictureViewer.Properties.Resources.ayarbutonu;
            this.ayarbutton.Location = new System.Drawing.Point(866, 12);
            this.ayarbutton.Name = "ayarbutton";
            this.ayarbutton.Size = new System.Drawing.Size(43, 38);
            this.ayarbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ayarbutton.TabIndex = 6;
            this.ayarbutton.TabStop = false;
            this.ayarbutton.Click += new System.EventHandler(this.ayarbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(311, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 593);
            this.Controls.Add(this.ayarbutton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKlasorSec);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResimSec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseWheel);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ayarbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnKlasorSec;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSlideShow;
        private System.Windows.Forms.CheckBox chkOrderly;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnkclt;
        private System.Windows.Forms.Button btnbyt;
        private System.Windows.Forms.PictureBox ayarbutton;
    }
}


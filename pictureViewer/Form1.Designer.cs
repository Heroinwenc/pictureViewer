
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnResimSec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnKlasorSec = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkOrderly = new System.Windows.Forms.CheckBox();
            this.chkSlideShow = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.adminbutton = new System.Windows.Forms.PictureBox();
            this.ayarbutton = new System.Windows.Forms.PictureBox();
            this.kullanicibutton = new System.Windows.Forms.PictureBox();
            this.suruklelbl1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayarbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicibutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResimSec
            // 
            this.btnResimSec.BackColor = System.Drawing.Color.Coral;
            this.btnResimSec.Location = new System.Drawing.Point(78, 575);
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
            this.listBox1.Location = new System.Drawing.Point(12, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 459);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnKlasorSec
            // 
            this.btnKlasorSec.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnKlasorSec.Location = new System.Drawing.Point(78, 534);
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
            this.groupBox1.Location = new System.Drawing.Point(311, 534);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(311, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.adminbutton);
            this.groupBox2.Controls.Add(this.ayarbutton);
            this.groupBox2.Controls.Add(this.kullanicibutton);
            this.groupBox2.Location = new System.Drawing.Point(848, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(70, 459);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menüler";
            // 
            // adminbutton
            // 
            this.adminbutton.Image = ((System.Drawing.Image)(resources.GetObject("adminbutton.Image")));
            this.adminbutton.Location = new System.Drawing.Point(6, 397);
            this.adminbutton.Name = "adminbutton";
            this.adminbutton.Size = new System.Drawing.Size(58, 56);
            this.adminbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminbutton.TabIndex = 11;
            this.adminbutton.TabStop = false;
            this.adminbutton.Visible = false;
            this.adminbutton.Click += new System.EventHandler(this.adminbutton_Click);
            // 
            // ayarbutton
            // 
            this.ayarbutton.Image = ((System.Drawing.Image)(resources.GetObject("ayarbutton.Image")));
            this.ayarbutton.Location = new System.Drawing.Point(9, 72);
            this.ayarbutton.Name = "ayarbutton";
            this.ayarbutton.Size = new System.Drawing.Size(55, 47);
            this.ayarbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ayarbutton.TabIndex = 10;
            this.ayarbutton.TabStop = false;
            this.ayarbutton.Click += new System.EventHandler(this.ayarbutton_Click);
            // 
            // kullanicibutton
            // 
            this.kullanicibutton.Image = ((System.Drawing.Image)(resources.GetObject("kullanicibutton.Image")));
            this.kullanicibutton.Location = new System.Drawing.Point(9, 19);
            this.kullanicibutton.Name = "kullanicibutton";
            this.kullanicibutton.Size = new System.Drawing.Size(55, 47);
            this.kullanicibutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kullanicibutton.TabIndex = 9;
            this.kullanicibutton.TabStop = false;
            this.kullanicibutton.Click += new System.EventHandler(this.kullanicibutton_Click);
            // 
            // suruklelbl1
            // 
            this.suruklelbl1.AutoSize = true;
            this.suruklelbl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.suruklelbl1.Location = new System.Drawing.Point(60, 19);
            this.suruklelbl1.Name = "suruklelbl1";
            this.suruklelbl1.Size = new System.Drawing.Size(177, 19);
            this.suruklelbl1.TabIndex = 9;
            this.suruklelbl1.Text = "PictureViewer User Menu";
            this.suruklelbl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.suruklelbl1_MouseDown);
            this.suruklelbl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.suruklelbl1_MouseMove);
            this.suruklelbl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.suruklelbl1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(835, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 624);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.suruklelbl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKlasorSec);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResimSec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseWheel);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayarbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicibutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnKlasorSec;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSlideShow;
        private System.Windows.Forms.CheckBox chkOrderly;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox ayarbutton;
        private System.Windows.Forms.PictureBox kullanicibutton;
        public System.Windows.Forms.PictureBox adminbutton;
        private System.Windows.Forms.Label suruklelbl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
    }
}


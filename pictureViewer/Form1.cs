using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpeg dosyaları (*.jpeg)|*.jpg|png dosyaları(*.png)|*.png|" +
                "Tüm Resim Dosyaları|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName.Length > 0)
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            else
                MessageBox.Show("Dosya seçmediniz!");
        }

        private void btnKlasorSec_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            //folderBrowserDialog1.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);                   
            if (folderBrowserDialog1.SelectedPath.Length > 0)
            {
                String[] klasor = Directory.GetFiles(folderBrowserDialog1.SelectedPath);

                //var imageFiles = from file in Directory.EnumerateFiles(this.folderBrowserDialog1.SelectedPath)
                //                 let extension = Path.GetExtension(file)
                //                 where extension.Equals(".jpg") || extension.Equals(".png")
                //                 select file;

                foreach (string dosyalar in klasor)
                {
                    //listBox1.Items.Add(Path.GetFileName(dosyalar));                    
                    if (Path.GetFullPath(dosyalar).EndsWith(".png") == true || Path.GetFullPath(dosyalar).EndsWith(".jpg") == true || Path.GetFullPath(dosyalar).EndsWith(".JPG") == true || Path.GetFullPath(dosyalar).EndsWith(".jpeg") == true)
                    {
                        listBox1.Items.Add(Path.GetFullPath(dosyalar));
                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chkOrderly.Checked == false)
            {
                //Slayt Random
                int adet = listBox1.Items.Count;
                int sayi = rnd.Next(0, adet);
                listBox1.SelectedIndex = sayi;
            }
            else
            {
                //Slayt Sıralı
                if (listBox1.SelectedIndex == listBox1.Items.Count - 1 && chkOrderly.Checked == true)
                {
                    listBox1.SelectedIndex = 0;
                }
                else
                {
                    if (chkOrderly.Checked == true)
                    {
                        listBox1.SelectedIndex++;
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = listBox1.Text;
        }


        private void chkOrderly_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOrderly.Checked == false)
            {
                chkOrderly.Text = "Random";

            }
            else
            {
                chkOrderly.Text = "Orderly";

            }
        }

        private void chkSlideShow_CheckedChanged(object sender, EventArgs e)
        {
            //İsim Değiştirme
            if (chkSlideShow.Checked == true)
            {
                chkSlideShow.Text = "Disable";
            }
            else
            {
                chkSlideShow.Text = "Enable";
            }
            if (chkSlideShow.Checked == true)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private Point mouseDownPoint = Point.Empty;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = pictureBox1.PointToClient(Control.MousePosition);
                int deltaY = mousePos.Y - mouseDownPoint.Y;
                int nWidth = pictureBox1.Width + deltaY;
                int nHeight = pictureBox1.Height + deltaY;
                if (nWidth > 0 && nHeight > 0)
                {
                    pictureBox1.Width = nWidth;
                    pictureBox1.Height = nHeight;
                }
            }
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (e.Delta > 0)
                {
                    pictureBox1.Width += 10;
                    pictureBox1.Height += 10;
                }
                else
                {
                    if (pictureBox1.Width > 50 && pictureBox1.Height > 50)
                    {
                        pictureBox1.Width -= 10;
                        pictureBox1.Height -= 10;
                    }
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Width = trackBar1.Value * 50;
            pictureBox1.Height = trackBar1.Value * 50;
        }

        private void btnbyt_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Width = pictureBox1.Image.Width + 50;
            pictureBox1.Height = pictureBox1.Image.Height + 50;
        }

        private void btnkclt_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox1.Width = pictureBox1.Image.Width;
            pictureBox1.Height = pictureBox1.Image.Height;
        }

        private void ayarbutton_Click(object sender, EventArgs e)
        {
            // Açılan formda kullanıcının ayarlarını değiştirebileceği kodlar yazılabilir.
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }
    }
}
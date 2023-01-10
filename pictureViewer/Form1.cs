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
    }
}
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
                goruntuleyicibox.ImageLocation = openFileDialog1.FileName;
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
            goruntuleyicibox.ImageLocation = listBox1.Text;
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
                Point mousePos = goruntuleyicibox.PointToClient(Control.MousePosition);
                int deltaY = mousePos.Y - mouseDownPoint.Y;
                int nWidth = goruntuleyicibox.Width + deltaY;
                int nHeight = goruntuleyicibox.Height + deltaY;
                if (nWidth > 0 && nHeight > 0)
                {
                    goruntuleyicibox.Width = nWidth;
                    goruntuleyicibox.Height = nHeight;
                }
            }
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (goruntuleyicibox.Image != null)
            {
                if (e.Delta > 0)
                {
                    goruntuleyicibox.Width += 10;
                    goruntuleyicibox.Height += 10;
                }
                else
                {
                    if (goruntuleyicibox.Width > 50 && goruntuleyicibox.Height > 50)
                    {
                        goruntuleyicibox.Width -= 10;
                        goruntuleyicibox.Height -= 10;
                    }
                }
            }
        }

        private void kullanicibutton_Click(object sender, EventArgs e)
        {
            // Kullanıcı Menüsü.
            User_menu usermenu = new User_menu();
            usermenu.ShowDialog();
        }

        private void ayarbutton_Click(object sender, EventArgs e)
        {
            // Ayarlar Menüsü.
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void adminbutton_Click(object sender, EventArgs e)
        {
            // Admin Panel Menüsü.
            adminpanel adminform = new adminpanel();
            adminform.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //adminbutton.Visible = false;
           
        }

        private void Form1_Shown(object sender, EventArgs e)
        {           
            if (User_menu.adminlogin == true)
            {
                adminbutton.Visible = true;
                adminpanel adminform = new adminpanel();
                adminform.Close();
            }
            else
                adminbutton.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void suruklelbl1_MouseDown(object sender, MouseEventArgs e)
        //Tıkladığımızda mouse tuşu aşağı doğru hareket edince gerçekleşir.
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void suruklelbl1_MouseMove(object sender, MouseEventArgs e)
        //Mouse hareket ederse gerçekleşecek ifadeler. Biz basılı iken hareket etmesi için dragging tanımladık.
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void suruklelbl1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.InitLayout();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        //Tıkladığımızda mouse tuşu aşağı doğru hareket edince gerçekleşir.
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        //Mouse hareket ederse gerçekleşecek ifadeler. Biz basılı iken hareket etmesi için dragging tanımladık.
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string dosya in files)
            {
                if (IsImage(dosya))
                {
                    listBox1.Items.Add(dosya);
                }
            }
        }
        private bool IsImage(string dosya)
        {
            string ext = Path.GetExtension(dosya).ToLower();
            return ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".gif" || ext == ".tif" || ext == ".tiff" ;
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}
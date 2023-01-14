using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureViewer
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
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

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        //Mouse hareket ederse gerçekleşecek ifadeler. Biz basılı iken hareket etmesi için dragging tanımladık.
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        //Tıkladığımızda mouse tuşu aşağı doğru hareket edince gerçekleşir.
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        Form1 form1 = new Form1();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                form1.timer1.Interval = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Değer Girilmedi");
            }
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //Dil Seçenekleri Başlangıç
            if(dil==0)
            {

                suruklelbl1.Text = "Resim Görüntüleyici Ayarları";
                label1.Text = "Slayt Süre";
                label2.Text = "              Dil";
                MessageBox.Show("Değişiklikler Kaydedildi, Lütfen Slaytı Yeniden Başlatın!");
                form1.suruklelbl1.Text = "Fotoğraf ve Video Görüntüleyici                                                                                      Video Görüntüleyici Çok Yakında";
            }
            else if(dil==1)
            {
                suruklelbl1.Text = "PictureViewer Settings";
                label1.Text = "Interval";
                label2.Text = "Language";
                MessageBox.Show("Changes Saved, Please Restart Slide!");
            }
        }
        public static int dil;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dil = Convert.ToInt32(comboBox1.SelectedIndex);
            if (dil == 0)
            {
                MessageBox.Show("Dil Türkçe Olarak Ayarlandı!");
            }
            else if(dil == 1)
            {
                MessageBox.Show("Language Set to English!");
            }
        }
    }
}

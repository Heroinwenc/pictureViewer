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
    public partial class User_menu : Form
    {
        public User_menu()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Giriş Başarılı!");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
        }



    }
}

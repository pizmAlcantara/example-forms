using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace advancedLauncher
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt işlemleri başlatıldı!");
            string cins;
            if(radioButton1.Checked)
            {
                cins = "Kadın";
            }
            else if(radioButton2.Checked)
            {
                cins = "Erkek";
            }
            else
            {
                cins = "Seçilmemiş";
            }
           
            for(int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);
                progressBar1.Value = i;
                if(i == 100)
                {
                    MessageBox.Show("Kayıt işlemleri tamamlandı!\n\nKayıt Bilgileri:\n - Ad, Soyad: " + textBox1.Text + "\n - TCK-NO: " + textBox2.Text + "\n - Kullanıcı Adı: " + textBox3.Text + "\n - Cinsiyet: " + cins);
                    break;
                }
            }
        }
    }
}

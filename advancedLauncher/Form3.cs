using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace advancedLauncher
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy"))
            {
                MessageBox.Show("Mevcut günü seçemezsin!", "Hata!");
            }
            else
            {
                listBox1.Items.Add("Ad, Soyad: " + textBox1.Text + " - TCK-NO: " + maskedTextBox1.Text + " - Tarih: " + dateTimePicker1.Text);
                MessageBox.Show("Randevu kayıdı yapıldı!\n\n - Ad, Soyad: "+textBox1.Text+ "\n - TCK-NO: "+maskedTextBox1.Text+"\n - Tarih: "+dateTimePicker1.Text, "Başarılı!");
            }

        }
    }
}

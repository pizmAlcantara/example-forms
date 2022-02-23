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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var loginForm = new Form2();
            this.Hide();
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                MessageBox.Show("Giriş başarısız!");
            }
            else
            {
                MessageBox.Show("Giriş başarılı!\nKullanıcı Adı: " + textBox1.Text, "Giriş Başarılı!");
                this.Hide();
                var loginedForm = new Form3();
                loginedForm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

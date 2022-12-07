using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders5_uçuş_bilgileri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota:" + comboBox1.Text + "-" + comboBox2.Text + "tarih:" + dateTimePicker1.Text + "saat:" + maskedTextBox2.Text 
                +"Yolcu Bilgileri:" + "~~"
             + "Adsoyad:" + textBox1.Text + "TC:" + maskedTextBox3.Text + "Telefon:" + maskedTextBox4.Text);
            MessageBox.Show("yolcu bilgileri Oluşturuldu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}

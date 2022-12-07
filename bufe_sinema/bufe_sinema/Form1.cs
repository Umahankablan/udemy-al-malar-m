using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bufe_sinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, toplam;
            misir = Convert.ToInt16(txtmisir.Text);
            su = Convert.ToInt16(txtsu.Text);
            bilet = Convert.ToInt16(txtbilet.Text);
            cay = Convert.ToInt16(txtcay.Text);

            toplam = misir * 25 + su * 5 + cay * 9 + bilet * 35;
            labeltoplam.Text = toplam.ToString() + " TL";

            kasatutar = kasatutar + toplam;
            labelkasa.Text = kasatutar.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtmisir.Text = " ";
            txtsu.Text = " ";
            txtcay.Text = " ";
            txtbilet.Text = " ";
            txtmisir.  Focus();
        }
    }
}

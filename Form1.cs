using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_büfe_satis_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, cay, su, toplam;
            misir = Convert.ToInt32(txtmsr.Text);
            cay = Convert.ToInt32(txtcay.Text);
            bilet = Convert.ToInt32(txtbilet.Text);
            su = Convert.ToInt32(txtsu.Text);

            toplam = misir * 4 + bilet * 8 + su * 1 + cay * 2;
            lbltoplam.Text = toplam.ToString() + " TL ";

            kasatutar = kasatutar + toplam;
            lblkasa.Text = kasatutar.ToString() + " TL ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbilet.Text = " ";
            txtcay.Text = " ";
            txtmsr.Text = " ";
            txtsu.Text = " ";
            txtmsr.Focus();


        }
    }
}

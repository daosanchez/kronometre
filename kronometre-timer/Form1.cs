using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kronometre_timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int salise = 90;
        int saniye = 25;
        int dakika = 30;
        int saat = 2;
        private void timer1_Tick(object sender, EventArgs e)
        {//yazilimkodlama.com
            salise++;
            //progressBar1.Value = salise;
            if (salise == 100)
            {
                salise = 0;
                saniye++;
            }

            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }


            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }

            lblSalise.Text = salise.ToString();
            lblSaniye.Text = saniye.ToString();
            lblDakika.Text = dakika.ToString();
            lblSaat.Text = saat.ToString();

        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
            listBox1.Items.Add(saat + ":" + dakika + ":" + saniye + "." + salise);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            salise = 0;
            saniye = 0;
            dakika = 0;
            saat = 0;
            lblSalise.Text = salise.ToString();
            lblSaniye.Text = saniye.ToString();
            lblDakika.Text = dakika.ToString();
            lblSaat.Text = saat.ToString();
            listBox1.Items.Clear();
        }
    }
}

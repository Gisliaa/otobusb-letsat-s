using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otobusbıletsatıs
{
    public partial class yönetici : Form
    {
        public yönetici()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminKullaniciEkle adminkullaniciekle = new AdminKullaniciEkle();
            adminkullaniciekle.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            YöneticiKullanicilariGörüntüle yöneticikullanicilarigörüntüle = new YöneticiKullanicilariGörüntüle();
            yöneticikullanicilarigörüntüle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Seferler seferler = new Seferler();
            seferler.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            yöneticibiletlerigörüntüle yöneticibiletlerigörüntüle = new yöneticibiletlerigörüntüle();
            yöneticibiletlerigörüntüle.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            yöneticikullanicisil yöneticikullanicisil = new yöneticikullanicisil();
            yöneticikullanicisil.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            yöneticiKullaniciGüncelle yöneticiKullaniciGüncelle = new yöneticiKullaniciGüncelle();
            yöneticiKullaniciGüncelle.Show();
            this.Hide();
        }
    }
}

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
    public partial class müsteripanel : Form
    {
        public müsteripanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             biletAlMain biletAlMain = new biletAlMain();
            biletAlMain.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musterıyolculuklarım musterıyolculuklarım = new musterıyolculuklarım();
            musterıyolculuklarım.Show();
            this.Hide();
        }

        private void müsteripanel_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            kullaniciBilgilerimiGüncelle kullaniciBilgilerimiGüncelle = new kullaniciBilgilerimiGüncelle();
            kullaniciBilgilerimiGüncelle.Show();
            this.Hide();
        }
    }
}

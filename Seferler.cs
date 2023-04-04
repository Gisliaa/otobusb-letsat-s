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
    public partial class Seferler : Form
    {
        public Seferler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seferekle seferekle = new seferekle();
            seferekle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yönetici yönetici = new yönetici();
            yönetici.Show();
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
            yöneticiseferlerigörüntüle yöneticiseferlerigörüntüle = new yöneticiseferlerigörüntüle();
            yöneticiseferlerigörüntüle.Show();
            this.Hide();
        }
    }
}

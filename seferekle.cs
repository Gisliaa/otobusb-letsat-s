using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace otobusbıletsatıs
{
    public partial class seferekle : Form
    {
        public seferekle()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-FG0SAS5\\SQLEXPRESS;Initial Catalog=otobüsbiletsatıs;Integrated Security=True");
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.Clear();
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox5.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(baglantı.State==ConnectionState.Closed)baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into seferler (arac,nereden,nereye,saat,tarih)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            MessageBox.Show("Sefere Eklendi");
            baglantı.Close();
            seferekle seferekle = new seferekle();
            seferekle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Seferler seferler = new Seferler();
            seferler.Show();
            this.Hide();
        }
    }
}

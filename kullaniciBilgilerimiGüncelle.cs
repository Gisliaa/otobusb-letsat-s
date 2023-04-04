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
using System.CodeDom;

namespace otobusbıletsatıs
{
    public partial class kullaniciBilgilerimiGüncelle : Form
    {
        public kullaniciBilgilerimiGüncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-FG0SAS5\\SQLEXPRESS;Initial Catalog=otobüsbiletsatıs;Integrated Security=True");
        string Eposta = Form1.GidenEposta;
        private void kullaniciBilgilerimiGüncelle_Load(object sender, EventArgs e)
        {
            
            if (baglantı.State==ConnectionState.Closed)baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from müsteri where eposta='"+Eposta+"'", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                textBox1.Text = oku["ad"].ToString();
                textBox2.Text = oku["soyad"].ToString();
                textBox3.Text = oku["eposta"].ToString();
                textBox4.Text = oku["sifre"].ToString();
            }
            
            oku.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (baglantı.State == ConnectionState.Closed) baglantı.Open();
            SqlCommand komut = new SqlCommand("UPDATE müsteri SET ad='" + textBox1.Text + "',soyad='" + textBox2.Text + "',eposta='" + textBox3.Text + "',sifre='" + textBox4.Text + "'where eposta='" + Eposta + "'", baglantı);
            komut.ExecuteNonQuery();
            MessageBox.Show("Güncelleme başarılı");
            kullaniciBilgilerimiGüncelle kullaniciBilgilerimiGüncelle = new kullaniciBilgilerimiGüncelle();
            kullaniciBilgilerimiGüncelle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

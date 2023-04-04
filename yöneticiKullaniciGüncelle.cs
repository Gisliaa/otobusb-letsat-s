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
    public partial class yöneticiKullaniciGüncelle : Form
    {
        public yöneticiKullaniciGüncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-FG0SAS5\\SQLEXPRESS;Initial Catalog=otobüsbiletsatıs;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (baglantı.State == ConnectionState.Closed) baglantı.Open();
            SqlCommand komut = new SqlCommand("UPDATE müsteri SET ad='" + textBox1.Text + "',soyad='" + textBox2.Text + "',eposta='" + textBox3.Text + "',sifre='" + textBox4.Text + "'where ıd='" + textBox5.Text + "'", baglantı);
            komut.ExecuteNonQuery();
            MessageBox.Show("Güncelleme başarılı");
            yöneticiKullaniciGüncelle yöneticiKullaniciGüncelle = new yöneticiKullaniciGüncelle();
            yöneticiKullaniciGüncelle.Show();
            this.Hide();
        }
        
        private void yöneticiKullaniciGüncelle_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (baglantı.State == ConnectionState.Closed) baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from müsteri where ıd='" + textBox5.Text + "'", baglantı);
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

        private void button2_Click(object sender, EventArgs e)
        {
            yönetici yönetici = new yönetici();
            yönetici.Show();
            this.Hide();
        }
    }
}

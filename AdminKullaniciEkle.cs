using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace otobusbıletsatıs
{
    public partial class AdminKullaniciEkle : Form
    {
        public AdminKullaniciEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-FG0SAS5\\SQLEXPRESS;Initial Catalog=otobüsbiletsatıs;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (baglantı.State == ConnectionState.Closed) baglantı.Open();

            SqlCommand komut = new SqlCommand("select * from müsteri where eposta='" + textBox4.Text + "'", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("E-posta sisteme kayitli");
                oku.Close();
            }
            else
            {
                oku.Close();
                if (baglantı.State == ConnectionState.Closed) baglantı.Open();
                SqlCommand uyeekle = new SqlCommand("insert into müsteri (tcno,ad,soyad,eposta,sifre,yetki) values ('" + textBox3.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "')", baglantı);
                uyeekle.ExecuteNonQuery();
                MessageBox.Show("Kayit olundu.");
                baglantı.Close();
                AdminKullaniciEkle adminkullaniciekle = new AdminKullaniciEkle();
                adminkullaniciekle.Show();
                this.Hide();
            }



            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yönetici yönetici = new yönetici();
            yönetici.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

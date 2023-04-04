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
using System.Security.Cryptography.X509Certificates;

namespace otobusbıletsatıs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-FG0SAS5\\SQLEXPRESS;Initial Catalog=otobüsbiletsatıs;Integrated Security=True");
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static string GidenEposta = "";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglantı.State == ConnectionState.Closed) baglantı.Open();
                SqlCommand kontrol = new SqlCommand("select * from müsteri where eposta ='" + textBox1.Text + "'and sifre='" + textBox2.Text + "'", baglantı);
                SqlDataReader oku = kontrol.ExecuteReader();
                oku.Read();
                if (oku.HasRows)
                {
                    if (oku["yetki"].ToString() == "Yönetici")
                    {
                        MessageBox.Show("Merhaba " + oku["ad"]+" " + oku["soyad"]+" Girişiniz Onaylandı.");
                        yönetici yönetici = new yönetici();
                        yönetici.Show();
                        this.Hide();
                    }
                    else if (oku["yetki"].ToString() == "müşteri")
                    {
                        MessageBox.Show("Merhaba " + oku["ad"] + " " + oku["soyad"] + " Girişiniz Onaylandı.");
                        müsteripanel müsteripanel = new müsteripanel();
                        müsteripanel.Show();
                        this.Hide();
                    }

                }
                
                
            }
            catch
            {
                MessageBox.Show("E-Posta veya sifreniz hatali tekrar deneyiniz.");
            }
            GidenEposta = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            kayitol kayitol = new kayitol();
            kayitol.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

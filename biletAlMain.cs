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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace otobusbıletsatıs
{
    public partial class biletAlMain : Form
    {
        public biletAlMain()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-FG0SAS5\\SQLEXPRESS;Initial Catalog=otobüsbiletsatıs;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            
            //SqlDataAdapter adp;
            
            if (baglantı.State==ConnectionState.Closed)baglantı.Open();
            SqlDataReader dr;
            
            SqlCommand komut = new SqlCommand("select * from seferler where nereden='"+textBox1.Text+"'and nereye='"+textBox2.Text+"' ", baglantı);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["nereden"]);
                comboBox4.Items.Add(dr["nereye"]);
                comboBox3.Items.Add(dr["saat"]);
            }
            dr.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (baglantı.State == ConnectionState.Closed) baglantı.Open();
            string Eposta = Form1.GidenEposta;


            SqlCommand komut = new SqlCommand("insert into biletler (nereden,nereye,saat,Eposta,koltuknumarası) values ('" + comboBox2.Text + "','" + comboBox4.Text + "','" + comboBox3.Text + "','" + Eposta + "','" + comboBox1.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            MessageBox.Show("Satın Alım Başarılı");
            baglantı.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            müsteripanel müsteripanel = new müsteripanel();
            müsteripanel.Show();
            this.Hide();
        }
    }
}

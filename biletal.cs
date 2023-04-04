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
    public partial class biletal : Form
    {
        public biletal()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-FG0SAS5\\SQLEXPRESS;Initial Catalog=otobüsbiletsatıs;Integrated Security=True");
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (baglantı.State == ConnectionState.Closed) baglantı.Open();
            string Eposta = Form1.GidenEposta;

            
            SqlCommand komut = new SqlCommand("insert into biletler (nereden,nereye,tarih,saat,Eposta,koltuknumarası) values ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + this.dateTimePicker1.Text + "','" + comboBox3.Text + "','" + Eposta + "','"+comboBox4.Text+"')", baglantı);
            komut.ExecuteNonQuery();
            MessageBox.Show("Satın Alım Başarılı");
            baglantı.Close();
            
        }
        private void biletal_Load(object sender, EventArgs e)
        {
            SqlCommand komut;
            //SqlDataAdapter adp;
            DataTable table = new DataTable();
            SqlDataReader dr;
            if (baglantı.State == ConnectionState.Closed) baglantı.Open();
            komut = new SqlCommand("select * from seferler", baglantı);
            dr =komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["nereden"]);
                comboBox2.Items.Add(dr["nereye"]);
                comboBox3.Items.Add(dr["saat"]);
                
                
                
                
            }
            dr.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            müsteripanel müsteripanel = new müsteripanel();
            müsteripanel.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/mm/yyyy";
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            
        }
    }
}

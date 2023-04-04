using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace otobusbıletsatıs
{
    public partial class yöneticibiletlerigörüntüle : Form
    {
        public yöneticibiletlerigörüntüle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yönetici yönetici = new yönetici();
            yönetici.Show();
            this.Hide();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-FG0SAS5\\SQLEXPRESS;Initial Catalog=otobüsbiletsatıs;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter adp;
        private void yöneticibiletlerigörüntüle_Load(object sender, EventArgs e)
        {
            if (baglantı.State == ConnectionState.Closed) baglantı.Open();

            DateTime tarihSaat = new DateTime();
            tarihSaat = DateTime.Today;
            

            SqlCommand komut = new SqlCommand("UPDATE biletler SET Durum='Aktif' WHERE tarih < '" + tarihSaat + "'", baglantı); ;
            komut.ExecuteNonQuery();
            komut = new SqlCommand("UPDATE biletler SET Durum='Pasif' WHERE tarih > '"+ tarihSaat + "'", baglantı);
            komut.ExecuteNonQuery();


            
            komut = new SqlCommand("select * from biletler", baglantı);
            adp = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            adp.Fill(ds, "biletler");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "biletler";
            dataGridView1.Columns[0].HeaderText = "biletler";

            


        }
    }
}

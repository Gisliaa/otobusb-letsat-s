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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace otobusbıletsatıs
{
    public partial class yöneticikullanicisil : Form
    {
        public yöneticikullanicisil()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-FG0SAS5\\SQLEXPRESS;Initial Catalog=otobüsbiletsatıs;Integrated Security=True");
        private void yöneticikullanicisil_Load(object sender, EventArgs e)
        {
            SqlCommand komut;
            SqlDataAdapter adp;
            komut = new SqlCommand("select * from müsteri", baglantı);
            adp = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            adp.Fill(ds, "müsteri");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "müsteri";
            dataGridView1.Columns[0].HeaderText = "müsteri";


            /*    ------------------------------------------------------------------         */
            DataTable table = new DataTable();
            SqlDataReader dr;
            if (baglantı.State == ConnectionState.Closed) baglantı.Open();
            komut = new SqlCommand("select * from müsteri", baglantı);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["tcno"]);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            SqlDataAdapter adp;
            DataTable table = new DataTable();
            SqlDataReader dr;
            if (baglantı.State == ConnectionState.Closed) baglantı.Open();
            komut = new SqlCommand("DELETE FROM müsteri WHERE tcno=('"+comboBox1.Text+"')", baglantı);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["tcno"]);
            }
            MessageBox.Show("Kişi silindi");
            yöneticikullanicisil yöneticikullanicisil = new yöneticikullanicisil();
            yöneticikullanicisil.Show();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
namespace otobusbıletsatıs
{
    public partial class YöneticiKullanicilariGörüntüle : Form
    {
        public YöneticiKullanicilariGörüntüle()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-FG0SAS5\\SQLEXPRESS;Initial Catalog=otobüsbiletsatıs;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter adp;
        private void YöneticiKullanicilariGörüntüle_Load(object sender, EventArgs e)
        {
            komut = new SqlCommand("select * from müsteri", baglantı);
            adp = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            adp.Fill(ds, "müsteri");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "müsteri";
            dataGridView1.Columns[0].HeaderText = "müsteri";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yönetici yönetici = new yönetici();
            yönetici.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

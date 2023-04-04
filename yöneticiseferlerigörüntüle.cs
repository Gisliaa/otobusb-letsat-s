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

namespace otobusbıletsatıs
{
    public partial class yöneticiseferlerigörüntüle : Form
    {
        public yöneticiseferlerigörüntüle()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-FG0SAS5\\SQLEXPRESS;Initial Catalog=otobüsbiletsatıs;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter adp;
        private void yöneticiseferlerigörüntüle_Load(object sender, EventArgs e)
        {
            komut = new SqlCommand("select * from seferler", baglantı);
            adp = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            adp.Fill(ds, "seferler");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "seferler";
            dataGridView1.Columns[0].HeaderText = "seferler";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seferler seferler = new Seferler();
            seferler.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

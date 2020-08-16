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

namespace _28_Mart_2018__çikolata_uygulaması_
{
    public partial class Siparişİşlemleri : Form
    {
        public Siparişİşlemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server = HP-Bilgisayar; Database=Çikolata;Trusted_Connection=True;");

        private void Siparişİşlemleri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandType = CommandType.StoredProcedure;
            komut.Connection = baglanti;
            komut.CommandText = "Hesap";
            komut.ExecuteNonQuery();
            baglanti.Close();
            SqlDataAdapter goruntule = new SqlDataAdapter(komut);
            DataTable doldur = new DataTable();
            goruntule.Fill(doldur);
            dataGridView1.DataSource = doldur;
        }
    }
}

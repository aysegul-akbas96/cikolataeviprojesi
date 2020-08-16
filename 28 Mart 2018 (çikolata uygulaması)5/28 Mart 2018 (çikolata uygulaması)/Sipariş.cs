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
    public partial class Sipariş : Form
    {
        public Sipariş()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection("Server=.;Database=Çikolata;uid=sa;pwd=1234;");
        SqlConnection baglanti = new SqlConnection("Server = HP-Bilgisayar; Database=Çikolata;Trusted_Connection=True;");

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Listele()
        {

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "SiparisGörüntüle";
            SqlDataAdapter goruntule = new SqlDataAdapter(komut);
            DataTable doldur = new DataTable();
            goruntule.Fill(doldur);
            dataGridView1.DataSource = doldur;
        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 git = new Form4();
            git.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sipariş_Load(object sender, EventArgs e)
        {
            SqlCommand komuttt = new SqlCommand();
            komuttt.Connection = baglanti;
            komuttt.CommandType = CommandType.StoredProcedure;
            komuttt.CommandText = "SiparisID";

            SqlDataReader drrr;  //sql den verileri okumak içinn 
            baglanti.Open();
            drrr = komuttt.ExecuteReader(); //okunan verileri çalıştır..
            while (drrr.Read())
            {
                comboBox1.Items.Add(drrr["SiparişID"]);
            }
            baglanti.Close();

           
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "MüşteriListeleCombo";

            SqlDataReader dr;  //sql den verileri okumak içinn 
            baglanti.Open();
            dr = komut.ExecuteReader(); //okunan verileri çalıştır..
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["MüşteriID"]);
            }
            baglanti.Close();
        }

        private void görüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand();
            ekle.Connection = baglanti;
            ekle.CommandType = CommandType.StoredProcedure;
            ekle.CommandText = "SiparisEkle";
            ekle.Parameters.AddWithValue("SiparişTarihi", dateTimePicker1.Value);
            ekle.Parameters.AddWithValue("SiparişAdet", textBox1.Text);
            ekle.Parameters.AddWithValue("MüşteriID ", comboBox2.SelectedItem);
           
            ekle.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand();
            sil.Connection = baglanti;
            sil.CommandType = CommandType.StoredProcedure;
            sil.CommandText = "SiparisSil";
            sil.Parameters.AddWithValue("SiparişID", comboBox1.SelectedItem);
            sil.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void aramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "SiparisIDArama";
            komut.Parameters.AddWithValue("SiparişID", comboBox1.SelectedItem);
            komut.ExecuteNonQuery();
            baglanti.Close();
            SqlDataAdapter goruntule = new SqlDataAdapter(komut);
            DataTable doldur = new DataTable();
            goruntule.Fill(doldur);
            dataGridView1.DataSource = doldur;
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "SiparişGüncelle";
            komut.Parameters.AddWithValue("SiparişID", comboBox1.SelectedItem);
            komut.Parameters.AddWithValue("SiparişTarihi", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("SiparişAdet", textBox1.Text);
            komut.Parameters.AddWithValue("MüşteriID", comboBox2.SelectedItem);
   
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }
    }
}

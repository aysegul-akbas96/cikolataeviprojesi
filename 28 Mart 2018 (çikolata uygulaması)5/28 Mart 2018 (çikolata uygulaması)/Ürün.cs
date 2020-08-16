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
    public partial class Ürün : Form
    {
        public Ürün()
        {
            InitializeComponent();
        }
        
        // SqlConnection baglanti = new SqlConnection("Server=.;Database=Çikolata;uid=sa;pwd=1234;");
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
            komut.CommandText = "ÜrünGörüntüle";
            SqlDataAdapter goruntule = new SqlDataAdapter(komut);
            DataTable doldur = new DataTable();
            goruntule.Fill(doldur);
            dataGridView1.DataSource = doldur;
        }

        private void Ürün_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "ÜrünGörüntüle";

            SqlDataReader dr;  //sql den verileri okumak içinn 
            baglanti.Open();
            dr = komut.ExecuteReader(); //okunan verileri çalıştır..
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["ÜrünID"]);
            }
            baglanti.Close();
            //tür ıd görüntüleme
            SqlCommand komut1 = new SqlCommand();
            komut1.Connection = baglanti;
            komut1.CommandType = CommandType.StoredProcedure;
            komut1.CommandText = "TürIDlistele";

            SqlDataReader dr1;
            baglanti.Open();
            dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox2.Items.Add(dr1["TürID"]);
            }
            baglanti.Close();
            //ÖdemeID
            SqlCommand komutt = new SqlCommand();
            komutt.Connection = baglanti;
            komutt.CommandType = CommandType.StoredProcedure;
            komutt.CommandText = "OdeListele";

            SqlDataReader drr;  //sql den verileri okumak içinn 
            baglanti.Open();
            drr = komutt.ExecuteReader(); //okunan verileri çalıştır..
            while (drr.Read())
            {
                comboBox3.Items.Add(drr["ÖdemeID"]);
            }
            baglanti.Close();
            //Müşteri Listele
            SqlCommand komuttt = new SqlCommand();
            komuttt.Connection = baglanti;
            komuttt.CommandType = CommandType.StoredProcedure;
            komuttt.CommandText = "MüşteriListeleCombo";

            SqlDataReader drrr;  //sql den verileri okumak içinn 
            baglanti.Open();
            drrr = komuttt.ExecuteReader(); //okunan verileri çalıştır..
            while (drrr.Read())
            {
                comboBox4.Items.Add(drrr["MüşteriID"]);
            }
            baglanti.Close();




        }

        private void ürünGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "ÜrünGörüntüle";
            SqlDataAdapter goruntule = new SqlDataAdapter(komut);
            DataTable doldur = new DataTable();
            goruntule.Fill(doldur);
            dataGridView1.DataSource = doldur;
        }

        private void ürünAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "ÜrünIDArama";
            komut.Parameters.AddWithValue("ÜrünID", comboBox1.SelectedItem);
            komut.ExecuteNonQuery();
            baglanti.Close();
            SqlDataAdapter goruntule = new SqlDataAdapter(komut);
            DataTable doldur = new DataTable();
            goruntule.Fill(doldur);
            dataGridView1.DataSource = doldur;
        }

        private void anaSayfayaDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 git = new Form4();
            git.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ürünEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand();
            ekle.Connection = baglanti;
            ekle.CommandType = CommandType.StoredProcedure;
            ekle.CommandText = "ÜrünEkle";
            ekle.Parameters.AddWithValue("ÜrünAdı", textBox1.Text);
            ekle.Parameters.AddWithValue("ÜrünÖzellik", textBox2.Text);
            ekle.Parameters.AddWithValue("ÜrünAdet", textBox3.Text);
            ekle.Parameters.AddWithValue("TürID", comboBox2.SelectedItem);
            ekle.Parameters.AddWithValue("ÖdemeID",comboBox3.SelectedItem);
            ekle.Parameters.AddWithValue("MüşteriID", comboBox4.SelectedItem);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void ürünSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Ürünler where ÜrünID=@ÜrünID", baglanti);
            komut.Parameters.AddWithValue("@ÜrünID", comboBox1.SelectedItem);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void ürünGnücellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Update Ürünler set ÜrünAdı='" + textBox1.Text.ToString() + "',ÜrünÖzellik='" + textBox2.Text.ToString() +"',ÜrünAdet='"+textBox3.Text.ToString()+"',TürID='"+comboBox2.SelectedItem.ToString() +"',ÖdemeID='"+comboBox3.SelectedItem.ToString()+"',MüşteriID='"+comboBox4.SelectedItem.ToString()+"'where ÜrünID='" + comboBox1.SelectedItem.ToString() + "'", baglanti);


            komut.ExecuteNonQuery();

            baglanti.Close();
            Listele();
        }
    }
    }


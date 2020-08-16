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

    public partial class ÜrünTür : Form
    {
        public ÜrünTür()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server = HP-Bilgisayar; Database=Çikolata;Trusted_Connection=True;");
        // SqlConnection baglanti = new SqlConnection("Server=.;Database=Çikolata;uid=sa;pwd=1234;");
        private void ÜrünTür_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("select TürID from ÜrünTür", baglanti);
            SqlDataReader drr;
            drr = komutt.ExecuteReader();
            while (drr.Read())
            {
                comboBox1.Items.Add(drr["TürID"]);
            }
            baglanti.Close();
        }
        public void Listele(string ulas)
        {
            SqlDataAdapter goster = new SqlDataAdapter(ulas, baglanti);
            DataTable doldur = new DataTable();
            goster.Fill(doldur);
            dataGridView1.DataSource = doldur;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ÜrünTür(TürAdı)values(@TürAdı)", baglanti);
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("TürAdı",textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele("select *from ÜrünTür");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Listele("select *from ÜrünTür");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from ÜrünTür where TürID='" + comboBox1.SelectedItem + "'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable doldur = new DataTable();
            da.Fill(doldur);
            dataGridView1.DataSource = doldur;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete ÜrünTür where TürID='" + comboBox1.SelectedItem + "'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable doldur = new DataTable();
            da.Fill(doldur);
            dataGridView1.DataSource = doldur;
            baglanti.Close();
            Listele("select *from ÜrünTür");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Update ÜrünTür set TürAdı='" + textBox1.Text.ToString()  + "'where TürID='" + comboBox1.SelectedItem.ToString() + "'", baglanti);


            komut.ExecuteNonQuery();

            baglanti.Close();
            Listele("select *from ÜrünTür");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 git = new Form4();
            git.Show();
            this.Hide();
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server = HP-Bilgisayar; Database=Çikolata;Trusted_Connection=True;");
       // SqlConnection baglanti = new SqlConnection("Server=.;Database=Çikolata;uid=sa;pwd=1234;");
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            dataGridView1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            dataGridView1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;


            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "MüşteriListeleCombo";

            SqlDataReader dr;  //sql den verileri okumak içinn 
            baglanti.Open();
            dr = komut.ExecuteReader(); //okunan verileri çalıştır..
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["MüşteriID"]);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "MüşteriAraID";
            komut.Parameters.AddWithValue("MüşteriID",comboBox1.SelectedItem);
            komut.ExecuteNonQuery();
            baglanti.Close();
            SqlDataAdapter goruntule = new SqlDataAdapter(komut);
            DataTable doldur = new DataTable();
            goruntule.Fill(doldur);
            dataGridView1.DataSource = doldur;




        }
        public void Listele()
        {
        
            SqlCommand komut = new SqlCommand(); 
            komut.Connection = baglanti; 
            komut.CommandType = CommandType.StoredProcedure; 
            komut.CommandText = "MüşteriGörüntüle"; 
            SqlDataAdapter goruntule = new SqlDataAdapter(komut); 
            DataTable doldur = new DataTable();
            goruntule.Fill(doldur);
            dataGridView1.DataSource = doldur; 
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand();
            ekle.Connection = baglanti;
            ekle.CommandType = CommandType.StoredProcedure;
            ekle.CommandText = "MüşteriEkle";
            ekle.Parameters.AddWithValue("MüşteriAdı", textBox1.Text);
            ekle.Parameters.AddWithValue("MüşteriSoyadı", textBox2.Text);
            ekle.Parameters.AddWithValue("Adres", textBox3.Text);
            ekle.Parameters.AddWithValue("Email", textBox4.Text);
            ekle.Parameters.AddWithValue("Telefon", textBox5.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand();
            sil.Connection = baglanti;
            sil.CommandType = CommandType.StoredProcedure;
            sil.CommandText = "MüşteriSil";
            sil.Parameters.AddWithValue("MüşteriID", comboBox1.SelectedItem);
            sil.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "MüşteriGüncelle";
            komut.Parameters.AddWithValue("MüşteriID", comboBox1.SelectedItem);
            komut.Parameters.AddWithValue("MüşteriAdı", textBox1.Text);
            komut.Parameters.AddWithValue("MüşteriSoyadı", textBox2.Text);
            komut.Parameters.AddWithValue("Adres", textBox3.Text);
            komut.Parameters.AddWithValue("Email", textBox4.Text);
            komut.Parameters.AddWithValue("Telefon", textBox5.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {

          
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 git =new Form4();
            git.Show();
            this.Hide();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

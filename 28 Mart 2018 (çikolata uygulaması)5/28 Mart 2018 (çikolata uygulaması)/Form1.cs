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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = HP-Bilgisayar; Database=Çikolata;Trusted_Connection=True;");
       // SqlConnection baglanti = new SqlConnection("Server=.;Database=Çikolata;uid=sa;pwd=1234;");


        private void üyeGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }
       

        private void üyeOlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "Getir";
            komut.Parameters.AddWithValue("ÜyeAdı", textBox1.Text);
            komut.Parameters.AddWithValue("Şifre", textBox2.Text);
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form3 git = new Form3();
                git.Show();
                this.Hide();
             

            }
           
            else
            {
                temizle();
                MessageBox.Show("Hatalı giriş yaptınız!Lütfen tekrar deneyiniz");
            }


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text ="";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "ÜyeOl";
            komut.Parameters.AddWithValue("ÜyeAdı", textBox3.Text);
            komut.Parameters.AddWithValue("ÜyeSoyadı", textBox4.Text);
            komut.Parameters.AddWithValue("Email", textBox5.Text);
            komut.Parameters.AddWithValue("Şifre", textBox6.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
         
         


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void üyeOlmadanGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 git = new Form3();
            git.Show();
            this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
           
        }

       

        private void adminGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "AGirişi";
            komut.Parameters.AddWithValue("AdminAdı", textBox7.Text);
            komut.Parameters.AddWithValue("Şifre", textBox8.Text);
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form4 git = new Form4();
                git.Show();
                this.Hide();


            }


            else
            {
                temizle();
                MessageBox.Show("Hatalı giriş yaptınız!Lütfen tekrar deneyiniz");
            }
        }
    }
}

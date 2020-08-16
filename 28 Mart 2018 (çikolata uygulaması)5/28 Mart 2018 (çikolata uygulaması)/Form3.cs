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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
         SqlConnection baglanti = new SqlConnection("Server = HP-Bilgisayar; Database=Çikolata;Trusted_Connection=True;");
        
        //SqlConnection baglanti = new SqlConnection("Server=.;Database=Çikolata;uid=sa;pwd=1234;");
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void Form3_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void ürünleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void beyazÇikolatalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = ımageList1.Images[2];
        }

        private void sütlüÇikolatalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = ımageList1.Images[0];
        }

        private void bitterÇikolatalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = ımageList1.Images[1];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ürünNumarasınaGöreBakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "ÜrünListeleCombo";

            SqlDataReader dr;  //sql den verileri okumak içinn 
            baglanti.Open();
            dr = komut.ExecuteReader(); //okunan verileri çalıştır..
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["ÜrünID"]);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Siparişİşlemleri git = new Siparişİşlemleri();
            git.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fatura git = new Fatura();
            double toplam = Convert.ToDouble (textBox2.Text) * Convert.ToDouble (textBox3.Text);


            git.listBox1.Items.Add("SeçilenÇikolata:" + comboBox2.SelectedItem.ToString());
            git.listBox1.Items.Add("TOPLAM ÜCRET:" +toplam);
            git.Show();
            this.Hide();

        
        }
    }
}

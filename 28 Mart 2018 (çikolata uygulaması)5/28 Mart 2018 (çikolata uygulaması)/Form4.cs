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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection("Server=.;Database=Çikolata;uid=sa;pwd=1234;");
        SqlConnection baglanti = new SqlConnection("Server = HP-Bilgisayar; Database=Çikolata;Trusted_Connection=True;");


        private void müşteriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 git = new Form2();
            git.Show();
            this.Hide();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void ürünİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ürün git = new Ürün();
            git.Show();
            this.Hide();
        }

        private void ürünTürToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜrünTür git = new ÜrünTür();
            git.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }

        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sipariş git = new Sipariş();
            git.Show();
            this.Hide();
        }
    }
}

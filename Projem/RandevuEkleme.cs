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

namespace Projem
{
    public partial class RandevuEkleme : Form
    {
        public RandevuEkleme()
        {
            InitializeComponent();
        }
        SqlBaglantisi bagla = new SqlBaglantisi();
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            SqlCommand komut3 = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bagla.baglanti());
            komut3.Parameters.AddWithValue("@r1", maskedTextBox2.Text);
            komut3.Parameters.AddWithValue("@r2", maskedTextBox1.Text);
            komut3.Parameters.AddWithValue("@r3", comboBox2.Text);
            komut3.Parameters.AddWithValue("@r4", comboBox1.Text);
            komut3.ExecuteReader();

           
           
        }

        private void RandevuEkleme_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular", bagla.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AsistanDetay ad = new AsistanDetay();
            ad.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 5)
            {
                progressBar1.Value = 60;
            }
            else if (sayac == 10)
            {
                progressBar1.Value = 90;
            }
            if (sayac == 12)
            {
                progressBar1.Value = 100;
                MessageBox.Show("Randevu Oluşturuldu");
            }

        }
    }
}

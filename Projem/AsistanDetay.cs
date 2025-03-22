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
    public partial class AsistanDetay : Form
    {
        public AsistanDetay()
        {
            InitializeComponent();
        }
        public string Tcno;
        SqlBaglantisi bagla = new SqlBaglantisi();
            private void AsistanDetay_Load(object sender, EventArgs e)
        {
            label3.Text = Tcno;

            // Ad Soyad Taşıma
            SqlCommand komut2 = new SqlCommand("Select  AsistanAdSoyad From Tbl_Asistan where AsistanTC=@p1", bagla.baglanti());
            komut2.Parameters.AddWithValue("@p1", label3.Text);
            SqlDataReader dr1 = komut2.ExecuteReader();
            while (dr1.Read())
            {
                label4.Text = dr1[0].ToString();
            }


            //Branşları datagride aktarma

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAd From Tbl_Brans", bagla.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            //Doktorları Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Doktorlar", bagla.baglanti());
            da2.Fill(dt2);
            dataGridView3.DataSource = dt2;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RandevuEkleme re = new RandevuEkleme();
            re.Show();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular(Duyuru) values(@x1)", bagla.baglanti());
            komut.Parameters.AddWithValue("@x1", richTextBox1.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Duyuru Oluşturuldu ");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoktorPaneli dp = new DoktorPaneli();
            dp.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BransPaneli bp = new BransPaneli();
            bp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DuyurularKontol dk = new DuyurularKontol();
            dk.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RandevuAl ra = new RandevuAl();
            ra.Show();
            this.Hide();
        }
    }
}

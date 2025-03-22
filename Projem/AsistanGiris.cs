using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projem
{
    public partial class AsistanGiris : Form
    {
        public AsistanGiris()
        {
            InitializeComponent();
        }

        private void AsistanGiris_Load(object sender, EventArgs e)
        {

        }
        SqlBaglantisi bagla = new SqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select * from Tbl_Asistan where AsistanTc = @p1 and AsistanSifre = @p2", bagla.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {

                AsistanDetay ad = new AsistanDetay();
                ad.Tcno = maskedTextBox1.Text;
               
            
                ad.Show();
                this.Hide();
            }

            else
                MessageBox.Show("Hatalı TC Veya Şifre !!!");
        }
       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
                textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandevuAl ra = new RandevuAl();
            ra.Show();
            this.Hide();

        }
    }
}

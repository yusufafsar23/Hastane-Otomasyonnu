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
    public partial class DoktorPaneli : Form
    {
        public DoktorPaneli()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }
        SqlBaglantisi bagla = new SqlBaglantisi();
        private void DoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Doktorlar", bagla.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@a1,@a2,@a3,@a4,@a5)", bagla.baglanti());
            komut.Parameters.AddWithValue("@a1", textBox1.Text);
            komut.Parameters.AddWithValue("@a2", textBox2.Text);
            komut.Parameters.AddWithValue("@a3", comboBox1.Text);
            komut.Parameters.AddWithValue("@a4", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@a5", textBox3.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Doktor Eklendi");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where DoktorAd=@e1", bagla.baglanti());
            komut.Parameters.AddWithValue("@e1", textBox1.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlCommand komut2 = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorBrans=@p3,DoktorSifre=@p5,DoktorTC=@p4 where DoktorSoyad=@p2", bagla.baglanti());
            komut2.Parameters.AddWithValue("@p1", textBox1.Text);
            komut2.Parameters.AddWithValue("@p2", textBox2.Text);
            komut2.Parameters.AddWithValue("@p3", comboBox1.Text);
            komut2.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            komut2.Parameters.AddWithValue("@p5", textBox3.Text);
            komut2.ExecuteNonQuery();
            bagla.baglanti().Close();
            MessageBox.Show("Doktorlar Güncellendi");
        }

        


    }
}

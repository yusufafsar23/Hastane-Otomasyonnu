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
    public partial class DoktorGiris : Form
    {
        public DoktorGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bagla = new SqlBaglantisi();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
                textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTC = @p1 and DoktorSifre = @p2", bagla.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {

                DoktorDetay dd = new DoktorDetay();
                dd.tcno = maskedTextBox1.Text;
            
                dd.Show();
                this.Hide();
            }

            else
                MessageBox.Show("Hatalı TC Veya Şifre !!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandevuAl ra = new RandevuAl();
            ra.Show();
            this.Hide();
        }
    }

   /* private void DoktorGiris_Load(object sender, EventArgs e)
        {

        }*/
    }


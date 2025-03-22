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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection bagla = new SqlConnection("Data Source = ysffsr; Initial Catalog = HastaneProje; Integrated Security = True");
       

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RandevuAl ra = new RandevuAl();
            ra.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnYakınHastane eyh = new EnYakınHastane();
            eyh.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            İletisim i = new İletisim();
            i.Show();
        }
    }
}

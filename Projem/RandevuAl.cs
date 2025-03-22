using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projem
{
    public partial class RandevuAl : Form
    {
        public RandevuAl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoktorGiris dg = new DoktorGiris();
            dg.Show();
                this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AsistanGiris ag = new AsistanGiris();
            ag.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DoktorGiris dg = new DoktorGiris();
            dg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastaGiris hg = new HastaGiris();
            hg.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AsistanGiris ag = new AsistanGiris();
            ag.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

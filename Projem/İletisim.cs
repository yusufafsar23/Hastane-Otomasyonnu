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
    public partial class İletisim : Form
    {
        public İletisim()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&ifkv=ASKXGp0Z5IYU0KLGdTLVRWoJIcFGqaXgHTj_pn6Ch6ObBPr2HoWLo0T1q7TyrMgshFPqVdLEviTw6Q&rip=1&sacu=1&service=mail&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S-385322792%3A1704718210345612&theme=glif");
        
    }
    }
}

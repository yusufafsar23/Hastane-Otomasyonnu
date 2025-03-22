using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projem
{
    class SqlBaglantisi
        
    {
        SqlConnection baglan = new SqlConnection("Data Source = YSFFSR; Initial Catalog = HastaneProje; Integrated Security = True");

        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source = YSFFSR; Initial Catalog = HastaneProje; Integrated Security = True");
            baglan.Open();
            return baglan;
        }
    }
}

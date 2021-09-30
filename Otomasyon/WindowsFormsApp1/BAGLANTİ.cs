using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    class BAGLANTİ
    {
        public SqlConnection sqlbaglantisi() { 
        
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-S15EUPN;Initial Catalog=BerkayAkarDevexpressTicariOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}

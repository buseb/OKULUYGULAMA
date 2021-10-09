using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKULUYGULAMA
{
    public class sql
    {
        public SqlConnection baglan()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-BR37C26;Initial Catalog=ogrenciListesi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
       
    }
}

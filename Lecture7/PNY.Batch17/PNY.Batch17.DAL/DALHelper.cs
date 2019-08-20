using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNY.Batch17.DAL
{
    public class DALHelper
    {
        public static SqlConnection GetSqlConnection()
        {
            string conString = @"Data Source=.;Initial Catalog=SalesDemoBatch17;Integrated Security=True";
            return new SqlConnection(conString);
        }
    }
}

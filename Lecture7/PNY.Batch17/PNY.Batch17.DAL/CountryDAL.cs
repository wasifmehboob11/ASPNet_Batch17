using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PNY.Batch17.Common;

namespace PNY.Batch17.DAL
{
    public class CountryDAL
    {
        private readonly string getCountries = @"Select ID, Name From Country";
        public List<Country> GetCountries()
        {
            SqlConnection sqlConnection = DALHelper.GetSqlConnection();
            SqlCommand sqlCommand = new SqlCommand(getCountries, sqlConnection);
            SqlDataReader sqlDataReader = null;
            List<Country> countries = null;
            sqlConnection.Open();
            try
            {
                sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    countries = new List<Country>();
                    while(sqlDataReader.Read())
                    {
                        Country country = new Country(Convert.ToInt32(sqlDataReader["ID"]), Convert.ToString(sqlDataReader["Name"]));
                        countries.Add(country);
                    }
                    
                }
            }
            finally
            {
                if (sqlDataReader != null)
                    sqlDataReader.Close();
                sqlConnection.Close();
                if (countries != null)
                    countries.TrimExcess();
            }

            return countries;
        }
    }
}

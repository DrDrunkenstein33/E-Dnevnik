es (19 sloc)  468 Bytes
   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace EDnevnik
{
    class Con
    {
        static public SqlConnection Connect()
        {
            string CS = ConfigurationManager.ConnectionStrings["home"].ConnectionString;
            SqlConnection veza = new SqlConnection(CS);
            return veza;
        }
    }
}
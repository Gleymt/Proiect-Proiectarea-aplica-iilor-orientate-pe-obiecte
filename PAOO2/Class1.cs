using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace PAOO2
{
    class Baza_de_date
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=paoo");
         
        public MySqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}

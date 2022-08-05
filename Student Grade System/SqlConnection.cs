using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;


namespace Student_Grade_System
{
    class Sql_Connection
    {
       public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-BDSUH1M\SQLEXPRESS;Initial Catalog=StudentGradesDB;Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}

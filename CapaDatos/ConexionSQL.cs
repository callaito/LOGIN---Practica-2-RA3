using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public class ConncctionSql
    {
        private readonly string connectionString;
        public ConncctionSql()
        {
            connectionString = " Server = RADELIN-PC ;DataBase= Loginn; integrated security= true";
        }
        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);

        }
    }
}

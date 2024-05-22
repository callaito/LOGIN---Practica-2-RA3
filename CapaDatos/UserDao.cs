using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace D.Datos
{
    public class UserDao : ConncctionSql
    {

        public bool Login(string Usuario, string Contraseña)
        {
            using (var connection = GetSqlConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuarios where LoginName =@user AND Password =@pass";
                    command.Parameters.AddWithValue("@user", Usuario);
                    command.Parameters.AddWithValue("@pass", Contraseña);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;

                }
            }


        }

    }
}
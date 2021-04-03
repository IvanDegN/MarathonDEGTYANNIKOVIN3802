using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarathonDEGTYANNIKOVIN3802
{
    class ClassSQL
    {
        public static string connectionStr = @"Data Source=PCSQLSTUD01;Initial Catalog = 10180030; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True";

        public static bool IsResult(string sqlExpression)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            SqlCommand sql = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = sql.ExecuteReader();
            sql = new SqlCommand(sqlExpression, connection);
            reader = sql.ExecuteReader();
            if (reader.HasRows) // проверка если ли строки. Если да, то true иначе false
            {
                reader.Read();
                return true;
            }
            else return false;
        }

        public static string Query(string sqlExpression)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            SqlCommand sql = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.HasRows) // получение первой строки из таблицы
            {
                reader.Read();
                return reader.GetString(0);
            }
            else return null;
        }
    }
}

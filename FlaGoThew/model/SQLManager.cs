using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeDeCourseCours.model
{
    internal class SQLManager
    {
        private const string connectionUrl = "server=localhost;Port=3306; database=listecourse;uid=root;pwd=\"\";";

        public static MySqlDataReader query(string query)
        {
            return query<MySqlDataReader>((cnn) =>
            {
                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = query;
                MySqlDataReader result = cmd.ExecuteReader();
                return result;
            });
        }

        public static MySqlDataAdapter dataReader(string query)
        {
            return query<MySqlDataAdapter>((cnn) =>
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, cnn);
                return mySqlDataAdapter;
            });
        }

        public static R query<R>(Func<MySqlConnection, R> ac)
        {

            MySqlConnection cnn = new MySqlConnection(connectionUrl);
            try
            {
                cnn.Open();
                R result = ac.Invoke(cnn);
                cnn.Close();
                return result;
            }
            catch (Exception ex)
            {
                return default;
            }
            finally
            {
                cnn.Close();
            }
        }

        public static void request(Action<MySqlConnection> ac)
        {

            MySqlConnection cnn = new MySqlConnection(connectionUrl);
            try
            {
                cnn.Open();
                ac.Invoke(cnn);
                cnn.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}

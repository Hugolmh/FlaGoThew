using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTache.sql
{
    public class SQLManager
    {
        private const string connectionUrl = "server=localhost;Port=3306; database=GestionTaches;uid=root;pwd=\"\";";

        
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

        /// <summary>
        /// Permet de simplifier l'appel de requetes vers la base de données.
        /// Elle ouvre et ferme les connection entre chaque requetes automatiquement.
        /// Exemple de code :
        /// <code>
        ///    SQLManager.query<int>((cnn) =>
        ///    {
        ///        MySqlCommand cmd = cnn.CreateCommand();
        ///        cmd.CommandText = "SELECT id FROM maTable WHERE id=@id";
        ///        cmd.Parameters.AddWithValue("@id", 10);
        ///        MySqlDataReader result = cmd.ExecuteReader();
        ///        return result.NextResult()? result.GetInt32("id") : -1;
        ///    });
        /// </code>
        /// Le code d'exemple fait une requete d'un simple SELECT en lui passant en paramettre 
        /// du nom "@id" un int '10'.
        /// Elle retourne un int, celle de l'id du resultat de la requete.
        /// Dans le lambda, on y retourne directement le resultat que l'ont souhaite retourner à
        /// la fin de la requete tout en y spécifiant le type de retour dans la généricité '<int>'
        /// précisé dans l'appel de la requette.
        /// 
        /// </summary>
        /// <typeparam name="R"></typeparam>
        /// <param name="ac"></param>
        /// <returns></returns>
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
                MessageBox.Show(ex.Message);
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

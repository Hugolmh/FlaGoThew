using FlaGoThew.model.utils;
using GestionTache.sql;
using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FlaGoThew.model.users
{
    public class UserManager
    {

        public static Boolean Login(string email, string password)
        {
            return SQLManager.query<bool>((cnn) =>
            {
                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Utilisateur WHERE email=@email AND motdepasse=@motdepasse";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@motdepasse", password);

                MySqlDataReader r = cmd.ExecuteReader();
                return r.HasRows;
            });
        }

        public static List<User> getUsers()
        {
            return SQLManager.query<List<User>>((cnn) =>
            {
                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Utilisateur";

                MySqlDataReader r = cmd.ExecuteReader();
                r.NextResult();
                List<User> users = new List<User>();
                while (r.Read())
                {
                    users.Add(r.GetInt32("id_utilisateur"), r.GetString("nom"), r.GetString("email"), null, Enum.Parse<RoleUser>(r.GetInt32("role"));
                }
                return r.HasRows;
            });
        }

        public static User getUser()
        {

        }

    }
}

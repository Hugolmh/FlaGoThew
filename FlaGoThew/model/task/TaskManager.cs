using GestionTache.sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlaGoThew.model.task
{
    public class TaskManager
    {
        public static Task CreateTask(int idProject, int idUser, string nameTask, string descriptionTask, 
                                string prioriteTask, DateTime dateEcheanceTask) 
        {
            int idTask = 0;

            SQLManager.query<int>((cnn) =>
            {
                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = "INSERT INTO Tache " +
                                   "(nom_tache, description, statut, priorite, date_echeance, id_projet, id_utilisateur) " +
                                   "values(@nomTache, @description, @statut, @priorite, @date_echeance, @id_projet, @id_utilisateur)";
                cmd.Parameters.AddWithValue("@nomTache", nameTask);
                cmd.Parameters.AddWithValue("@description", descriptionTask);
                cmd.Parameters.AddWithValue("@statut", "toDo");
                cmd.Parameters.AddWithValue("@priorite", prioriteTask);
                cmd.Parameters.AddWithValue("@date_echeance", dateEcheanceTask);
                cmd.Parameters.AddWithValue("@id_projet", idProject);
                cmd.Parameters.AddWithValue("@id_utilisateur", idUser);
                MySqlDataReader result = cmd.ExecuteReader();
                return result.NextResult() ? result.GetInt32("id_tache") : -1;
            });


            Task newTask = new Task(idTask, nameTask, descriptionTask, "toDo", prioriteTask, dateEcheanceTask);

            return newTask;
        }


        public static DataTable GetTasks(String statut, int idProject) 
        {
            MySqlDataAdapter dataAdapter = SQLManager.query<MySqlDataAdapter>((cnn) =>
            {
                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = "SELECT id_tache, nom_tache, description, id_utilisateur, priorite, date_echeance " +
                                    "FROM tache WHERE statut = @statut AND id_projet = @id_projet";
                cmd.Parameters.AddWithValue("@id_projet", idProject);
                cmd.Parameters.AddWithValue("@statut", statut);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
                return mySqlDataAdapter;
            });
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public static int GetIdSelectedTache(DataGridView dgv)
        {
            if (dgv.CurrentCell == null)
            {
                return 0;
            }

            int rowIndex = dgv.CurrentCell.RowIndex;

            return Int32.Parse(dgv.Rows[rowIndex].Cells[0].Value.ToString());
        }

        public static void EditTask(int idTask, String taskName, String description, int idUser, String priorite, DateTime dateEcheance)
        {
            SQLManager.query<int>((cnn) =>
            {
                try
                {
                    MySqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandText =   "UPDATE tache SET nom_tache = @nom_tache, description = @description, id_utilisateur = @id_utilisateur, priorite = @priorite, date_echeance = @date_echeance WHERE id_tache = @id_tache";
                    cmd.Parameters.AddWithValue("@nom_tache", taskName);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@id_utilisateur", idUser);
                    cmd.Parameters.AddWithValue("@priorite", priorite);
                    cmd.Parameters.AddWithValue("@date_echeance", dateEcheance);
                    cmd.Parameters.AddWithValue("@id_tache", idTask);
                    MySqlDataReader result = cmd.ExecuteReader();
                    return result.NextResult() ? result.GetInt32("id_tache") : -1;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return -1;
                }
            });
        }


        public static void DeleteTask(int idTask) 
        {
            SQLManager.query<int>((cnn) =>
            {
                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = "DELETE FROM tache where id_tache = @id_tache";
                cmd.Parameters.AddWithValue("@id_tache", idTask);
                MySqlDataReader result = cmd.ExecuteReader();
                return result.NextResult() ? result.GetInt32("id_tache") : -1;
            });
        }
        public Task EditNameTask(int idTask, string newName) { return null; }

        public Task EditDescriptionTask(int idTask, string description) { return null; }

        public Task CommentTask(int idTask, string message) { return null; }

        public static void ChangeTaskStatus(int idTask, string status) 
        {
            SQLManager.query<int>((cnn) =>
            {
                try
                {

                    MySqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandText = "UPDATE tache SET statut = @statut WHERE id_tache = @id_tache";
                    cmd.Parameters.AddWithValue("@statut", status);
                    cmd.Parameters.AddWithValue("@id_tache", idTask);
                    MySqlDataReader result = cmd.ExecuteReader();
                    return result.NextResult() ? result.GetInt32("id_tache") : -1;
                } catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return -1;
                }
            });
        }

        public Task ChangeTaskPriority(int idTask, string priority) { return null;  }

        public Task AffectTaskMember(int idTask, int idMember) { return null; }


    }
}

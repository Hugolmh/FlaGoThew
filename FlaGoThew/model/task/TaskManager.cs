using GestionTache.sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FlaGoThew.model.task
{
    public class TaskManager
    {
        public Task CreateTask(int idProject, int idUser, string nameTask, string descriptionTask, 
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


            //Task newTask = new Task(idTask, nameTask, descriptionTask, "toDo", prioriteTask, dateEcheanceTask);

            return null; 
        }

        public bool DeleteTask(int idStak) { return true; }

        public Task EditNameTask(int idTask, string newName) { return null; }

        public Task EditDescriptionTask(int idTask, string description) { return null; }

        public Task CommentTask(int idTask, string message) { return null; }

        public Task ChangeTaskStatus(int idTask, string status) {  return null; }

        public Task ChangeTaskPriority(int idTask, string priority) { return null;  }

        public Task AffectTaskMember(int idTask, int idMember) { return null; }


    }
}

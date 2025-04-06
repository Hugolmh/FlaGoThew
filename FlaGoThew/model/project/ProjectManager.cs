using System;
using System.Collections.Generic;
using GestionTache.sql;
using MySql.Data.MySqlClient;

namespace FlaGoThew.model.project
{
    public class ProjectManager
    {
        public static bool CreateProject(Project project)
        {
            string query = "INSERT INTO projet (nom, description_projet, date_creation, date_fin, statut) " +
                           "VALUES (@name, @description, @creationDate, @endDate, @status)";

            try
            {
                SQLManager.request((cnn) =>
                {
                    MySqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@name", project.Name);
                    cmd.Parameters.AddWithValue("@description", project.Description);
                    cmd.Parameters.AddWithValue("@creationDate", project.CreationDate);
                    cmd.Parameters.AddWithValue("@endDate", project.EndDate);
                    cmd.Parameters.AddWithValue("@status", project.Status);
                    cmd.ExecuteNonQuery();
                });

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la création du projet : {ex.Message}");
                return false;
            }
        }

        public static bool UpdateProject(string oldProjectName, string newProjectName, string newDescription, DateTime newEndDate, string newStatus)
        {
            string query = "UPDATE projet SET nom = @newName, description_projet = @newDescription, date_fin = @newEndDate, statut = @newStatus WHERE nom = @oldName";

            try
            {
                SQLManager.request((cnn) =>
                {
                    MySqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@oldName", oldProjectName);
                    cmd.Parameters.AddWithValue("@newName", newProjectName);
                    cmd.Parameters.AddWithValue("@newDescription", newDescription);
                    cmd.Parameters.AddWithValue("@newEndDate", newEndDate);
                    cmd.Parameters.AddWithValue("@newStatus", newStatus);
                    cmd.ExecuteNonQuery();
                });

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la mise à jour du projet : {ex.Message}");
                return false;
            }
        }


        public static bool DeleteProjectByName(string projectName)
        {
            string query = "DELETE FROM projet WHERE nom = @name";

            try
            {
                SQLManager.request((cnn) =>
                {
                    MySqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@name", projectName);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    Console.WriteLine(rowsAffected > 0 ? "Suppression réussie !" : "Échec de la suppression.");
                });

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la suppression du projet : {ex.Message}");
                return false;
            }
        }

        public static List<Project> GetAllProjects()
        {
            List<Project> projects = new List<Project>();
            string query = "SELECT id_projet, nom, description_projet, date_creation, date_fin, statut FROM projet";

            try
            {
                SQLManager.request((cnn) =>
                {
                    MySqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandText = query;
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Project project = new Project(
                            reader.GetInt32("id_projet"),
                            reader.GetString("nom"),
                            reader.GetString("description_projet"),
                            reader.GetDateTime("date_creation"),
                            reader.GetDateTime("date_fin"),
                            reader.GetString("statut")
                        );

                        Console.WriteLine($"Projet trouvé en BDD : {project.Name}");
                        projects.Add(project);
                    }
                });

                Console.WriteLine($"Total projets récupérés : {projects.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la récupération des projets : {ex.Message}");
            }

            return projects;
        }

        public static Project GetProjectById(int idProject)
        {
            string query = "SELECT id_projet, nom, description_projet, date_creation, date_fin, statut FROM projet WHERE id_projet = @id_projet";

            try
            {
                return SQLManager.query<Project>((cnn) =>
                {
                    MySqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@id_projet", idProject);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Project project = new Project(
                            reader.GetInt32("id_projet"),
                            reader.GetString("nom"),
                            reader.GetString("description_projet"),
                            reader.GetDateTime("date_creation"),
                            reader.GetDateTime("date_fin"),
                            reader.GetString("statut")
                        );

                        Console.WriteLine($"Projet trouvé en BDD : {project.Name}");
                        return project;
                    }
                    return null;
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la récupération des projets : {ex.Message}");
            }

            return null;
        }


    }
}

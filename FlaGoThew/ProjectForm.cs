using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FlaGoThew.model.project;

namespace FlaGoThew
{
    public partial class ProjectForm : UserControl
    {
        private Project selectedProject;

        public ProjectForm()
        {
            InitializeComponent();
            selectedProject = new Project();
            LoadProjects();

            // Événement double clic
            ListProject.CellDoubleClick += ListProject_CellDoubleClick;
        }

        private void LoadProjects()
        {
            List<Project> projects = ProjectManager.GetAllProjects();
            ListProject.Rows.Clear();

            if (ListProject.ColumnCount == 0)
            {
                ListProject.ColumnCount = 5;
                ListProject.Columns[0].Name = "Nom";
                ListProject.Columns[1].Name = "Description";
                ListProject.Columns[2].Name = "Date de création";
                ListProject.Columns[3].Name = "Date de fin";
                ListProject.Columns[4].Name = "Statut";
            }

            foreach (var project in projects)
            {
                ListProject.Rows.Add(
                    project.Name,
                    project.Description,
                    project.CreationDate.ToShortDateString(),
                    project.EndDate.ToShortDateString(),
                    project.Status
                );
            }
        }

        private void ListProject_SelectionChanged(object sender, EventArgs e)
        {
            if (ListProject.SelectedRows.Count > 0)
            {
                selectedProject.Name = ListProject.SelectedRows[0].Cells[0].Value.ToString();
                selectedProject.Description = ListProject.SelectedRows[0].Cells[1].Value.ToString();
                selectedProject.CreationDate = DateTime.Parse(ListProject.SelectedRows[0].Cells[2].Value.ToString());
                selectedProject.EndDate = DateTime.Parse(ListProject.SelectedRows[0].Cells[3].Value.ToString());
                selectedProject.Status = ListProject.SelectedRows[0].Cells[4].Value.ToString();

                NameProject.Text = selectedProject.Name;
                DescProject.Text = selectedProject.Description;
                dateTimeProject.Value = selectedProject.EndDate;
                Status.Text = selectedProject.Status;
            }
        }

        private void NameProject_TextChanged(object sender, EventArgs e)
        {
            selectedProject.Name = NameProject.Text;
        }

        private void DescProject_TextChanged(object sender, EventArgs e)
        {
            selectedProject.Description = DescProject.Text;
        }

        private void dateTimeProject_ValueChanged(object sender, EventArgs e)
        {
            selectedProject.EndDate = dateTimeProject.Value;
        }

        private void Status_TextChanged(object sender, EventArgs e)
        {
            selectedProject.Status = Status.Text;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            selectedProject.CreationDate = DateTime.Now;

            if (ProjectManager.CreateProject(selectedProject))
            {
                MessageBox.Show("Projet créé avec succès !");
                LoadProjects();
            }
            else
            {
                MessageBox.Show("Erreur lors de la création du projet.");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ListProject.SelectedRows.Count > 0)
            {
                string projectName = ListProject.SelectedRows[0].Cells[0].Value.ToString();
                if (ProjectManager.DeleteProjectByName(projectName))
                {
                    MessageBox.Show("Projet supprimé avec succès !");
                    LoadProjects();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression du projet.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un projet à supprimer.");
            }
        }

        private void ModifyTask_Click(object sender, EventArgs e)
        {
            if (ListProject.SelectedRows.Count > 0)
            {
                string oldProjectName = ListProject.SelectedRows[0].Cells[0].Value.ToString();

                string newProjectName = string.IsNullOrWhiteSpace(NameProject.Text) ? oldProjectName : NameProject.Text;
                string newDescription = string.IsNullOrWhiteSpace(DescProject.Text) ? ListProject.SelectedRows[0].Cells[1].Value.ToString() : DescProject.Text;
                DateTime newEndDate = dateTimeProject.Value;
                string newStatus = Status.Text;

                if (ProjectManager.UpdateProject(oldProjectName, newProjectName, newDescription, newEndDate, newStatus))
                {
                    MessageBox.Show("Projet modifié avec succès !");
                    LoadProjects();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification du projet.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un projet à modifier.");
            }
        }

        // Méthode corrigée pour gérer l'ouverture correcte de Home
        private void ListProject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string projectName = ListProject.Rows[e.RowIndex].Cells[0].Value.ToString();
                OpenHomeForm(projectName);
            }
        }

        // Méthode corrigée pour ouvrir la nouvelle Form (Home.cs)
        private void OpenHomeForm(string projectName)
        {
            Home homeForm = new Home(); // Vérifie bien que Home() ne nécessite pas de paramètres !

            homeForm.Show(); // ouvre simplement la nouvelle fenêtre
            // ou homeForm.ShowDialog(); pour bloquer les autres fenêtres
        }

        // Supprimer ou laisse vide si inutilisé
        private void ListProject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

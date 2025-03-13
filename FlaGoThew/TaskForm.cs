using FlaGoThew.model.task;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaGoThew
{
    public partial class TaskForm : Form
    {
        private int idProject;

        public TaskForm(int idProject)
        {
            this.idProject = idProject;
            InitializeComponent();

            MajDgv();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CreateTask_Click(object sender, EventArgs e)
        {
            string nomProjet = NomProjet.Text; 
            string nameTask = NameTask.Text;
            string descriptionTask = DescTask.Text;
            int idUser = Int32.Parse(IdUser.Text);
            string prioriteTask = PrioTask.Text;
            DateTime dateEcheanceTask = DateEcheance.Value;


            TaskManager.CreateTask(this.idProject, idUser, nameTask, descriptionTask,
                                prioriteTask, dateEcheanceTask);

            MajDgv();
            ResetTextBoxes();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void ToDoInProgess_Click(object sender, EventArgs e)
        {
            int idTask = TaskManager.GetIdSelectedTache(ToDo);

            TaskManager.ChangeTaskStatus(idTask, "inProgress");
            MajDgv();
        }

        private void InProgressToDo_Click(object sender, EventArgs e)
        {
            int idTask = TaskManager.GetIdSelectedTache(InProgress);

            TaskManager.ChangeTaskStatus(idTask, "toDo");
            MajDgv();
        }

        private void InProgressDone_Click(object sender, EventArgs e)
        {
            int idTask = TaskManager.GetIdSelectedTache(InProgress);

            TaskManager.ChangeTaskStatus(idTask, "done");

            MajDgv();
        }

        private void DoneInProgress_Click(object sender, EventArgs e)
        {
            int idTask = TaskManager.GetIdSelectedTache(Done);

            TaskManager.ChangeTaskStatus(idTask, "inProgress");

            MajDgv();
        }

        private void DeleteTask_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteTodo_Click(object sender, EventArgs e)
        {
            int idTask = TaskManager.GetIdSelectedTache(ToDo);

            TaskManager.DeleteTask(idTask);
            MajDgv();
        }

        private void DeleteInProgress_Click(object sender, EventArgs e)
        {
            int idTask = TaskManager.GetIdSelectedTache(InProgress);

            TaskManager.DeleteTask(idTask);
            MajDgv();
        }

        private void DeleteDone_Click(object sender, EventArgs e)
        {
            int idTask = TaskManager.GetIdSelectedTache(Done);

            TaskManager.DeleteTask(idTask);
            MajDgv();
        }


        private void MajDgv()
        {
            DataTable tasksTodo = TaskManager.GetTasks("toDo", idProject);
            ToDo.DataSource = tasksTodo;
            ToDo.Columns[0].Visible = true;

            DataTable tasksInProgress = TaskManager.GetTasks("inProgress", idProject);
            InProgress.DataSource = tasksInProgress;
            InProgress.Columns[0].Visible = true;

            DataTable done = TaskManager.GetTasks("done", idProject);
            Done.DataSource = done;
            Done.Columns[0].Visible = true;
        }

        private void ModifyToDo_Click(object sender, EventArgs e)
        {
            MajTache(ToDo);
        }

        private void ConfirmModif_Click(object sender, EventArgs e)
        {
            
        }

        private void ModifyInProgress_Click(object sender, EventArgs e)
        {
            MajTache(InProgress);
        }

        private void ModifyDone_Click(object sender, EventArgs e)
        {
            MajTache(Done);
        }


        private void MajTache(DataGridView statut)
        {
            if (NameTask.Text != "")
            {
                int rowIndex = statut.CurrentCell.RowIndex;
                int idTask = TaskManager.GetIdSelectedTache(statut);
                String taskName = NameTask.Text;
                String description = DescTask.Text;
                int idUser = Int32.Parse(IdUser.Text);
                String priorite = PrioTask.Text;
                DateTime dateEcheance = DateEcheance.Value;

                TaskManager.EditTask(idTask, taskName, description, idUser, priorite, dateEcheance);

                

                MajDgv();
                ResetTextBoxes();
            }
            else
            {
                int rowIndex = statut.CurrentCell.RowIndex;

                String taskName = statut.Rows[rowIndex].Cells[1].Value.ToString();
                String description = statut.Rows[rowIndex].Cells[2].Value.ToString();
                int idUser = Int32.Parse(statut.Rows[rowIndex].Cells[3].Value.ToString());
                String priorite = statut.Rows[rowIndex].Cells[4].Value.ToString();
                DateTime dateEcheance = DateTime.ParseExact(statut.Rows[rowIndex].Cells[5].Value.ToString(), "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture); ;

                NameTask.Text = taskName;
                DescTask.Text = description;
                IdUser.Text = idUser.ToString();
                PrioTask.Text = priorite;
                DateEcheance.Value = dateEcheance;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void ResetTextBoxes()
        {
            NameTask.Clear();
            DescTask.Clear();
            IdUser.Clear();
            PrioTask.Clear();
            DateEcheance.Value = DateTime.Now;
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
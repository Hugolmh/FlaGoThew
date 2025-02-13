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
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CreateTask_Click(object sender, EventArgs e)
        {
            string nomProjet = NomProjet.Text; 
            string nameTask = NameTask.Text;
            string descriptionTask = DescTask.Text;
            int idUser = Int32.Parse(UserTask.Text);
            string prioriteTask = PrioTask.Text;
            DateTime dateEcheanceTask = DateEcheance.Value;


            TaskManager.CreateTask(this.idProject, idUser, nameTask, descriptionTask,
                                prioriteTask, dateEcheanceTask);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

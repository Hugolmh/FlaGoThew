using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaGoThew.model.task
{
    public class Task
    {
        private int idTask;
        private string nameTask;
        private string descriptionTask;
        private string statusTask;
        private string prioriteTask;
        private DateTime dateEcheanceTask;

        public Task(int idTask, string nameTask, string descriptionTask, string statusTask, string prioriteTask, DateTime dateEcheanceTask)
        {
            this.idTask = idTask;
            this.nameTask = nameTask;
            this.descriptionTask = descriptionTask;
            this.statusTask = statusTask;
            this.prioriteTask = prioriteTask;
            this.dateEcheanceTask = dateEcheanceTask;
        }


        public int GetIdTask() { return idTask; }


        public string GetNameTask() { return nameTask; } 
        public void SetNameTask(string nameTask) {  this.nameTask = nameTask; }


        public string GetDescriptionTask() {  return descriptionTask; } 
        public void SetDescriptionTask(string descriptionTask) { this.descriptionTask = descriptionTask; }


        public string GetStatusTask() {  return statusTask; }
        public void SetStatusTask(string statusTask) { this.statusTask = statusTask; }


        public string GetPrioriteTask() { return prioriteTask; }
        public void SetPrioriteTask(string priorite) {  this.prioriteTask = priorite; }


        public DateTime GetdateEcheanceTask() {  return dateEcheanceTask; }
        public void SetdateEcheanceTask(DateTime dateEcheanceTask) { this.dateEcheanceTask= dateEcheanceTask; }










    }
}

using System;

namespace FlaGoThew.model.project
{
    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }

        public Project(string name, string description, DateTime creationDate, DateTime endDate, string status)
        {
            Name = name;
            Description = description;
            CreationDate = creationDate;
            EndDate = endDate;
            Status = status;
        }

        public Project() { }
    }
}

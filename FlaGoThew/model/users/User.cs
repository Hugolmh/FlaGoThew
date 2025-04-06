using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaGoThew.model.users
{
    public class User
    {
        public int IdProjet { get; }
        public string Name { get; }
        public string Email { get; }
        public string Motdepasse { get; }
        public RoleUser Role { get; set; }
        
        public User(int idProjet, string name, string email, string motdepasse, RoleUser roleUser) {
            this.IdProjet = idProjet;
            this.Name = name;
            this.Email = email;
            this.Role = roleUser;
        }

        public User(int idProjet, string name, string email, string motdepasse) : this(idProjet, name, email, motdepasse, RoleUser.Member)
        {
        }

    }
}

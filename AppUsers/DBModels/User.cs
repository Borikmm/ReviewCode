using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUsers
{
    public class User
    {
        public int id {  get; set; }
        private string name;
        private string role;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public User() { }

        public User(string name, string role)
        {
            this.name = name;
            this.role = role;
        }
    }
}

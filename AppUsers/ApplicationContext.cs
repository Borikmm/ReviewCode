using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AppUsers
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Core> Cores { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Core_place> Cores_places { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationContext() : base("DefaultConnection") { }
    }
}

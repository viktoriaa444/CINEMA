using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CINEMA.Class
{
    class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UserContext() : base("DefaultConnection") { }
    }
}

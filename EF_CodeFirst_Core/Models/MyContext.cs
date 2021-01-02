using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_CodeFirst_Core.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public virtual DbSet<Role> AllRoles { get; set; }
        public virtual DbSet<User> AllUsers { get; set; }
    }
}

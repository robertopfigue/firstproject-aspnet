using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.Models
{
    public class FirstProjectContext : DbContext
    {
        public FirstProjectContext (DbContextOptions<FirstProjectContext> options)
            : base(options)
        {
        }

        public DbSet<FirstProject.Models.Department> Department { get; set; }
    }
}

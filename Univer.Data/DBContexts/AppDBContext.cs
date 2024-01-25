using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Domain.Entity;

namespace Univer.Data.DBContexts
{
    public class AppDBContext:DbContext
    {
        public DbSet<Students> student { get; set; }
        public DbSet<Course> course { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server=localhost; port=5432; username=postgres; password=20000101; database=University");
        }
    }
}

using LearnEf.Domains;
using Microsoft.EntityFrameworkCore;

namespace LearnEf.Data
{
    public class MyContext : DbContext {
        public DbSet<Company> Companies {get; set;}
        public DbSet<Department> Departments {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./MyTestDb.db");
        }
    }
}
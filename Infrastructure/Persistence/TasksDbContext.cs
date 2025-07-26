using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Persistence
{
    public class TasksDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public TasksDbContext(DbContextOptions<TasksDbContext> options) : base(options)
        {
        }

        public DbSet<Tasks> tasks { get; set; }
        public DbSet<Persons> persons { get; set; }
    }
}

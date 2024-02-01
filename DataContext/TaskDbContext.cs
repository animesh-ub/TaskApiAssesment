using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TaskApi.DataContext
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options)
            : base(options) { }
        public DbSet<Models.Task> Tasks { get; set; }
    }
}

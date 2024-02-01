using Microsoft.EntityFrameworkCore;
using TaskApi.DataContext;
using TaskApi.ITaskRepository;
using TaskApi.Repo;

namespace TaskApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<TaskDbContext>(op => op.UseSqlServer(builder.Configuration["ConnectionStrings:myConnection"]));

            builder.Services.AddControllers();

            builder.Services.AddTransient<ITask, TaskRepo>();

            // Add Required Dependencies here
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
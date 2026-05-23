using Microsoft.EntityFrameworkCore;
using TodoListApiii.Models;
using TodoListApiii.Models;

namespace TodoListApiii.Dataaa
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;

namespace MinimalAPI
{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
            : base(options)
            { }
        public DbSet<Todo> Todos { get; set; }

    }
}

using ivica_anic_netcore_web_api.Model;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace ivica_anic_netcore_web_api.Controllers
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}

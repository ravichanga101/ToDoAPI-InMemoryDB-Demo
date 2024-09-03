using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ToDoAPI_InMemoryDB.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}

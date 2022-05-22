using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo_app.Model;

namespace todo_app.Infrastructure {
    public class TodoContext: DbContext {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<TodoList> todoList { get; set; }
    }
}

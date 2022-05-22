using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using todo_app.Infrastructure;
using todo_app.Model;

namespace todo_app.Controllers {
    public class IndexModel : PageModel {
        private readonly TodoContext _context;

        public IndexModel(TodoContext context) {
            _context = context;
        }

        public IList<TodoList> TodoList { get;set; }

        public async Task OnGetAsync() {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            TodoList = await _context.todoList.Where(todo => todo.UserId == userId).ToListAsync();
        }
    }
}

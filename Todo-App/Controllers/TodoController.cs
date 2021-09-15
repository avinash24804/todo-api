using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo_App.Infrastructure;

namespace ToDo_App.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoContext context;
        public TodoController(TodoContext context)
        {
            this.context = context;
        }
        public Task<ActionResult> Index()
        {
            
        }
    }
}

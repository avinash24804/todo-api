﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo_App.Models;

namespace ToDo_App.Infrastructure
{
    public class TodoContext: DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options):base(options)
        {

        }

        public DbSet<TodoList> TodoList { get; set; }
    }
}

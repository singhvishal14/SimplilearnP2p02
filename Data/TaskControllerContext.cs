using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assisgnment16.Models;

namespace Assisgnment16.Data
{
    public class TaskControllerContext : DbContext
    {
        public TaskControllerContext (DbContextOptions<TaskControllerContext> options)
            : base(options)
        {
        }

        public DbSet<Assisgnment16.Models.Task> Task { get; set; } = default!;
    }
}

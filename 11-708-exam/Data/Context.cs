using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_708_exam
{
    public class Context: DbContext
    {
        public DbSet<File> Files { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }

}

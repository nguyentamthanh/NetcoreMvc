using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PROJECT_DEMO.Models;
using PROJECT_DEMO.Data;

namespace PROJECT_DEMO.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<PROJECT_DEMO.Models.Movie> Movie { get; set; }

        public DbSet<PROJECT_DEMO.Models.Student> Student { get; set; }
    }


}

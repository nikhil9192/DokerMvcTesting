using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DokerMvcTesting.Models;

namespace DokerMvcTesting.Data
{
    public class DokerMvcTestingContext : DbContext
    {
        public DokerMvcTestingContext (DbContextOptions<DokerMvcTestingContext> options)
            : base(options)
        {
        }

        public DbSet<DokerMvcTesting.Models.Person> Person { get; set; } = default!;
    }
}

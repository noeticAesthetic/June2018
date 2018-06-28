using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using June2018.Models;

namespace June2018.Models
{
    public class June2018Context : DbContext
    {
        public June2018Context (DbContextOptions<June2018Context> options)
            : base(options)
        {
        }

        public DbSet<June2018.Models.Product> Product { get; set; }
    }
}
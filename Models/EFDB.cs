using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject.Models
{
    public class EFDB : DbContext
    {
        public DbSet<User> Users { get; set; }

        public EFDB(DbContextOptions<EFDB> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

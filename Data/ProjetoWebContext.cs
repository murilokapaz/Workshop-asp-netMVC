﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoWeb.Models
{
    public class ProjetoWebContext : DbContext
    {
        public ProjetoWebContext (DbContextOptions<ProjetoWebContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoWeb.Models.Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
    }
}

﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Context : DbContext
    {
        public DbSet<LoginData> LoginData { get; set; }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-GUFE3U9Q\SQLEXPRESS;Database=DataProject;Trusted_Connection=True;");
        }
    }
}

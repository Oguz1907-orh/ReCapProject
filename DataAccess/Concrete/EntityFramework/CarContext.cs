﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = RentaCar; Trusted_Connection = true");

        }
            public DbSet<Car> Cars { get; set; }
            public DbSet<Brand> Brands { get; set; }
            public DbSet<Brand> Users { get; set; }
            public DbSet<Color> Colors { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet <RentInform> RentInforms { get; set; }

    }

}


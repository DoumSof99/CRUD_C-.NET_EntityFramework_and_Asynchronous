﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_System.models
{
    class MyDBContext : DbContext
    {

        public MyDBContext() : base("MyDBConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyDBContext, Migrations.Configuration>("MyDBConnectionString"));
        }
    

        public DbSet<Detail> Details { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}

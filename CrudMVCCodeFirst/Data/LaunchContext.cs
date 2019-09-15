using CrudMVCCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CrudMVCCodeFirst.Data
{
    public class LaunchContext : DbContext
    {
        public LaunchContext() : base("LaunchContext")
        {
        }

        public DbSet<LaunchEntry> Launches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace test.DAL


{
    public class OracleDbContext : DbContext
    {
        public DbSet<Blog> Blog { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
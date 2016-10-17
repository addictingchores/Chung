using ADDictingChoresProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ADDictingChoresProject.DAL
{
    public class AddictingChoresContext : DbContext
    {

        public AddictingChoresContext() : base("AddictingChoresContext")
        {
        } 

        public DbSet<Child> Children { get; set; }
        public DbSet<Chore> Chores { get; set; }
        public DbSet<Reward> Rewards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
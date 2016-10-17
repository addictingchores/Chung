using AddictingChoresProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace AddictingChoresProject.DAL
{
    public class AddictingChoresContext : DbContext
    {

        public AddictingChoresContext() : base("Data Source=SQL5031.myASP.NET;Initial Catalog=DB_A11531_francisschommer;Persist Security Info=True;User ID=DB_A11531_francisschommer_admin;Password=e11672.java;")
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
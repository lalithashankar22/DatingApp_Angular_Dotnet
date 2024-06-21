using Dating_app.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

/*
 * Pakages 
 * using Microsoft.EntityFrameworkCore; 
 * Microsoft.EntityFrameworkCore.SqlServer --to use sql database, in prog.cs file to use 'UseSqlServer'
 * Microsoft.EntityFrameworkCore.Tools  --to execute Add-Migration
 */
namespace Dating_app.DB_Context
{
    public class DA_DBContextClass:DbContext
    {
        public DA_DBContextClass(DbContextOptions<DA_DBContextClass> dbcontextopts) : base(dbcontextopts) 
        {//when we have more than one db class 
                
        }
        //Add-Migration "one" -context "DA_DBContextClass"
        //Update-Database -context "DA_DBContextClass"
        public DbSet<AppUserClass> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var user = new List<AppUserClass>()
            {
                new AppUserClass
                {
                    Id = 1,
                    UserName = "Test22",  
                    Password = "test22"
                },
                new AppUserClass
                {
                    Id = 2,
                    UserName = "Test11",
                    Password = "test11"

                }
            };

            modelBuilder.Entity<AppUserClass>().HasData(user);
        }
    }


}

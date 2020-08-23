using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Classfields.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace Classfields.Data.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    foreach (var property in modelBuilder.Model.GetEntityTypes()
        //        .SelectMany(e => e.GetProperties()
        //            .Where(p => p.ClrType == typeof(string))))
        //    {
        //        property.
        //    }
        //}

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreatedAt") != null && 
                                                                         entry.Entity.GetType().GetProperty("UpdatedAt") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreatedAt").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("UpdatedAt").CurrentValue = DateTime.Now;
                }
            }

            //foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("UpdatedAt") != null))
            //{
            //    if (entry.State == EntityState.Modified)
            //    {
            //        entry.Property("UpdatedAt").CurrentValue = DateTime.Now;
            //    }
            //}

            return base.SaveChangesAsync(cancellationToken);
        } 
    }
}
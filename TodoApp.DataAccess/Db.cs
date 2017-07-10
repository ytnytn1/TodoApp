using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TodoApp.DbModel;

namespace TodoApp.DataAccess
{
    public class Db:DbContext
    {

        public DbSet<UserPassword> UserPasswords { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=TodoApp;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.Relational().TableName = entity.DisplayName();

            }
            modelBuilder.Entity<UserPassword>()
                .HasOne(up => up.User)
                .WithMany()
                .HasForeignKey(u => u.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}

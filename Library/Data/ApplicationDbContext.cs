using System;
using System.Collections.Generic;
using System.Text;
using Library.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Book> Book { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<FilterProperties> filterProperties { get; set; }

        public DbSet<BookByCategory> bookByCategories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookByCategory>(entity =>
            {
                entity.HasNoKey();

            });
        }
    }
}

//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;
//using Testing.Models;

//namespace Testing.Models
//{
//    public partial class NewDbContext : DbContext
//    {
//        public NewDbContext()
//        {
//        }

//        public NewDbContext(DbContextOptions<NewDbContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<Product> Products { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NewDb");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Product>(entity =>
//            {
//                entity.ToTable("Product");

//                entity.Property(e => e.Id).ValueGeneratedNever();

//                entity.Property(e => e.Details).IsUnicode(false);

//                entity.Property(e => e.Name).IsUnicode(false);
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}

﻿//// <auto-generated />
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Infrastructure;
//using Microsoft.EntityFrameworkCore.Metadata;
//using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
//using Testing.Models;

//#nullable disable

//namespace Testing.Migrations
//{
//    [DbContext(typeof(NewDbContext))]
//    partial class NewDbContextModelSnapshot : ModelSnapshot
//    {
//        protected override void BuildModel(ModelBuilder modelBuilder)
//        {
//#pragma warning disable 612, 618
//            modelBuilder
//                .HasAnnotation("ProductVersion", "6.0.8")
//                .HasAnnotation("Relational:MaxIdentifierLength", 128);

//            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

//            modelBuilder.Entity("Testing.Models.Product", b =>
//                {
//                    b.Property<int>("Id")
//                        .HasColumnType("int");

//                    b.Property<string>("Details")
//                        .IsRequired()
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.Property<string>("Name")
//                        .IsRequired()
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.Property<int>("Price")
//                        .HasColumnType("int");

//                    b.HasKey("Id");

//                    b.ToTable("Product", (string)null);
//                });
//#pragma warning restore 612, 618
//        }
//    }
//}

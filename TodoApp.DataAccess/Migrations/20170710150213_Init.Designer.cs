using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TodoApp.DataAccess;
using TodoApp.Core;

namespace TodoApp.DataAccess.Migrations
{
    [DbContext(typeof(Db))]
    [Migration("20170710150213_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TodoApp.DbModel.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("DueDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("ParentId");

                    b.Property<int>("TaskStatus");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("UserId");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("TodoApp.DbModel.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("TodoApp.DbModel.UserPassword", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("UserPassword");
                });

            modelBuilder.Entity("TodoApp.DbModel.Task", b =>
                {
                    b.HasOne("TodoApp.DbModel.Task", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.HasOne("TodoApp.DbModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TodoApp.DbModel.UserPassword", b =>
                {
                    b.HasOne("TodoApp.DbModel.User", "User")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

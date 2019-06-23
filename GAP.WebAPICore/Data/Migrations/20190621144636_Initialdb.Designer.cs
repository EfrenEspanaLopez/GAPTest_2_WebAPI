﻿// <auto-generated />
using GAP.WebAPICore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GAP.WebAPICore.Migrations
{
    [DbContext(typeof(WebAPIContext))]
    [Migration("20190621144636_Initialdb")]
    partial class Initialdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GAP.WebAPICore.Data.Grades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Grade");

                    b.Property<int>("IdStudent");

                    b.Property<int>("IdSubject");

                    b.HasKey("Id");

                    b.HasIndex("IdStudent");

                    b.HasIndex("IdSubject");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("GAP.WebAPICore.Data.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("GAP.WebAPICore.Data.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("GAP.WebAPICore.Data.Grades", b =>
                {
                    b.HasOne("GAP.WebAPICore.Data.Student", "Student")
                        .WithMany("Grades")
                        .HasForeignKey("IdStudent")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GAP.WebAPICore.Data.Subject", "Subject")
                        .WithMany("Grades")
                        .HasForeignKey("IdSubject")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using HandsOnEFCodeFirst_Demo2.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HandsOnEFCodeFirst_Demo2.Migrations
{
    [DbContext(typeof(EMSDBContext))]
    [Migration("20220106090940_mig2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HandsOnEFCodeFirst_Demo2.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ProjectCode")
                        .HasMaxLength(5)
                        .HasColumnType("char(5)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("ProjectCode");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("HandsOnEFCodeFirst_Demo2.Entities.Project", b =>
                {
                    b.Property<string>("ProjectCode")
                        .HasMaxLength(5)
                        .HasColumnType("char(5)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("TeamSize")
                        .HasColumnType("int");

                    b.HasKey("ProjectCode");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("HandsOnEFCodeFirst_Demo2.Entities.Employee", b =>
                {
                    b.HasOne("HandsOnEFCodeFirst_Demo2.Entities.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectCode");

                    b.Navigation("Project");
                });
#pragma warning restore 612, 618
        }
    }
}

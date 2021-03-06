// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PETAS.Models.Domain.HRMS;

namespace PETAS.Data.Data
{
    public partial class HRMSContext : DbContext
    {
        public HRMSContext()
        {
        }

        public HRMSContext(DbContextOptions<HRMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<JobTitle> JobTitles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Head).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.AuthorizedById).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedById).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPfvaried).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdatedById).HasDefaultValueSql("((0))");

                entity.Property(e => e.NationalIdnumber).HasDefaultValueSql("('')");

                entity.Property(e => e.PfemployeePercentage).HasDefaultValueSql("((0))");

                entity.Property(e => e.PfemployerPercentage).HasDefaultValueSql("((0))");

                entity.Property(e => e.Supervisor).HasDefaultValueSql("((0))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
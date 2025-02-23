using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EFCore.DbContexts
{
    internal class ITIDbContext : DbContext
    {
        public ITIDbContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = ITI; Trusted_Connection = true; TrustServerCertificate=True");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud_Course>()
                .HasKey(e => new { e.Stud_ID, e.Course_ID });

            modelBuilder.ApplyConfiguration<Course_Inst>(new Course_InstConfigurations());

            modelBuilder.Entity<Department>()
                .HasMany<Student>(s => s.Students)
                .WithOne(d => d.Department)
                .HasForeignKey(s => s.Dept_Id);

            modelBuilder.Entity<Course_Inst>()
               .HasOne(e => e.Course)
               .WithMany(s => s.Course_Insts)
               .HasForeignKey(e => e.Course_ID);

            modelBuilder.Entity<Course_Inst>()
                .HasOne(e => e.Instructor)
                .WithMany(c => c.Course_Insts)
                .HasForeignKey(e => e.inst_ID);

            modelBuilder.Entity<Stud_Course>()
                .HasOne(e => e.Course)
                .WithMany(s => s.Courses)
                .HasForeignKey(e => e.Course_ID);

            modelBuilder.Entity<Stud_Course>()
               .HasOne(e => e.Student)
               .WithMany(s => s.Courses)
               .HasForeignKey(e => e.Stud_ID);

            modelBuilder.Entity<Department>()
                .HasMany<Instructor>(s => s.Instructors)
                .WithOne(d => d.Department)
                .HasForeignKey(s => s.Dept_ID);

           
        }
    }
}

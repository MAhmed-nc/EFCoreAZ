using LotDetailsEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotDetailsEFCore.EntityFramework
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<LotType> LotTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LotType>(entity =>
            {
                entity.HasKey("LotTypeInd");
                //entity.Property(e => e.LotTypeInd).HasColumnName("LotTypeInd")
                //entity.Property(e => e.LotTypeName)
                //    .HasMaxLength(50)
                //    .IsUnicode(false)
                //    .HasColumnName("LotTypeName");

                //entity.HasOne(d => d.Teacher)
                    //.WithMany(p => p.Course)
                    //.HasForeignKey(d => d.TeacherId)
                    //.OnDelete(DeleteBehavior.Cascade)
                    //.HasConstraintName("FK_Course_Teacher");
            });

            //modelBuilder.Entity<Standard>(entity =>
            //{
            //    entity.Property(e => e.Description)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.StandardName)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);
            //});

            //modelBuilder.Entity<Student>(entity =>
            //{
            //    entity.Property(e => e.StudentId).HasColumnName("StudentID");

            //    entity.Property(e => e.FirstName)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.LastName)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.HasOne(d => d.Standard)
            //        .WithMany(p => p.Student)
            //        .HasForeignKey(d => d.StandardId)
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .HasConstraintName("FK_Student_Standard");
            //});

            //modelBuilder.Entity<StudentAddress>(entity =>
            //{
            //    entity.HasKey(e => e.StudentId);

            //    entity.Property(e => e.StudentId)
            //        .HasColumnName("StudentID")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Address1)
            //        .IsRequired()
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Address2)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.City)
            //        .IsRequired()
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.State)
            //        .IsRequired()
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.HasOne(d => d.Student)
            //        .WithOne(p => p.StudentAddress)
            //        .HasForeignKey<StudentAddress>(d => d.StudentId)
            //        .HasConstraintName("FK_StudentAddress_Student");
            //});

            //modelBuilder.Entity<StudentCourse>(entity =>
            //{
            //    entity.HasKey(e => new { e.StudentId, e.CourseId });

            //    entity.HasOne(d => d.Course)
            //        .WithMany(p => p.StudentCourse)
            //        .HasForeignKey(d => d.CourseId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_StudentCourse_Course");

            //    entity.HasOne(d => d.Student)
            //        .WithMany(p => p.StudentCourse)
            //        .HasForeignKey(d => d.StudentId)
            //        .HasConstraintName("FK_StudentCourse_Student");
            //});

            //modelBuilder.Entity<Teacher>(entity =>
            //{
            //    entity.Property(e => e.StandardId).HasDefaultValueSql("((0))");

            //    entity.Property(e => e.TeacherName)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.HasOne(d => d.Standard)
            //        .WithMany(p => p.Teacher)
            //        .HasForeignKey(d => d.StandardId)
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .HasConstraintName("FK_Teacher_Standard");
            //});
        }
    }
}

using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using myprogram.DAL.Models;

namespace myprogram.DAL
{
    public partial class karaContext : IdentityDbContext
    {
        public karaContext()
        {
            Database.EnsureCreated();
        }

        public karaContext(DbContextOptions<karaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Load> Load { get; set; }
        public virtual DbSet<Para> Para { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-BRRBO9S;Initial Catalog=kyrsova;Integrated Security=True;");
            }
        }

        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Load>(entity =>
            {
                entity.HasKey(e => e.KodDial)
                    .HasName("PK__load__F02F5F21B2F5C101");

                entity.ToTable("load");

                entity.Property(e => e.KodDial)
                    .HasColumnName("kod_dial")
                    .ValueGeneratedNever();

                entity.Property(e => e.KodSubject).HasColumnName("kod_subject");

                entity.Property(e => e.KodTeacher).HasColumnName("kod_teacher");

                entity.Property(e => e.NumberGroup)
                    .HasColumnName("number_group")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StudyYear)
                    .HasColumnName("Study_year")
                    .HasMaxLength(50)
                    .IsUnicode(false); ;

                entity.HasOne(d => d.KodSubjectNavigation)
                    .WithMany(p => p.Load)
                    .HasForeignKey(d => d.KodSubject)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__load__kod_subjec__29572725");

                entity.HasOne(d => d.KodTeacherNavigation)
                    .WithMany(p => p.Load)
                    .HasForeignKey(d => d.KodTeacher)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__load__kod_teache__2A4B4B5E");

                entity.Property(p => p.KodDial).ValueGeneratedOnAdd()
                .IsRequired();
            });

            modelBuilder.Entity<Para>(entity =>
            {
                entity.HasKey(e => e.KodDial)
                    .HasName("PK__para__F02F5F21A360B2A6");

                entity.ToTable("para");

                entity.Property(e => e.KodDial)
                    .HasColumnName("kod_dial")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountHours).HasColumnName("count_hours");

                entity.Property(e => e.TypeTraning)
                    .HasColumnName("type_traning")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.KodDialNavigation)
                    .WithOne(p => p.Para)
                    .HasForeignKey<Para>(d => d.KodDial)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__para__kod_dial__2C3393D0");

                entity.Property(p => p.KodDial).ValueGeneratedOnAdd()
                .IsRequired();
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(e => e.KodSubject)
                    .HasName("PK__subject__71E4C958B68EC898");

                entity.ToTable("subject");

                entity.Property(e => e.KodSubject)
                    .HasColumnName("kod_subject")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(p => p.KodSubject).ValueGeneratedOnAdd()
                .IsRequired();
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.KodTeacher)
                    .HasName("PK__teacher__CD30064B93F75275");

                entity.ToTable("teacher");

                entity.Property(e => e.KodTeacher)
                    .HasColumnName("kod_teacher")
                    .ValueGeneratedNever();

                entity.Property(e => e.Degree)
                    .HasColumnName("degree")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Experience)
                    .HasColumnName("experience")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SecondName)
                    .HasColumnName("second_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdName)
                    .HasColumnName("third_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(p => p.KodTeacher).ValueGeneratedOnAdd()
               .IsRequired();

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

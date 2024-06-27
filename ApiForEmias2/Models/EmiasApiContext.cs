using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ApiForEmias2.Models;

public partial class EmiasApiContext : DbContext
{
    public EmiasApiContext()
    {
    }

    public EmiasApiContext(DbContextOptions<EmiasApiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<AnalysDocument> AnalysDocuments { get; set; }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<AppointmentDocument> AppointmentDocuments { get; set; }

    public virtual DbSet<Direction> Directions { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<ResearchDocument> ResearchDocuments { get; set; }

    public virtual DbSet<Speciality> Specialities { get; set; }

    public virtual DbSet<Statuss> Statusses { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.IdAdmin).HasName("PK__Admin__69F56766E688A0D7");

            entity.ToTable("Admin");

            entity.Property(e => e.IdAdmin).HasColumnName("ID_Admin");
            entity.Property(e => e.AdminName).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EnterPassword).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(50);
        });

        modelBuilder.Entity<AnalysDocument>(entity =>
        {
            entity.HasKey(e => e.IdAnalysDocument).HasName("PK__AnalysDo__11B9576427A46750");

            entity.ToTable("AnalysDocument");

            entity.Property(e => e.IdAnalysDocument).HasColumnName("ID_AnalysDocument");
            entity.Property(e => e.AppointmentId).HasColumnName("Appointment_ID");
            entity.Property(e => e.NameDocument).HasMaxLength(50);


        });

        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.IdAppointment).HasName("PK__Appointm__CE24CCCCA6143B23");

            entity.Property(e => e.IdAppointment).HasColumnName("ID_Appointment");
            entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");
            entity.Property(e => e.Oms).HasColumnName("OMS");
            entity.Property(e => e.StatusId).HasColumnName("Status_ID");

        });

        modelBuilder.Entity<AppointmentDocument>(entity =>
        {
            entity.HasKey(e => e.IdAppointmentDocument).HasName("PK__Appointm__077DCD837C0BE133");

            entity.ToTable("AppointmentDocument");

            entity.Property(e => e.IdAppointmentDocument).HasColumnName("ID_AppointmentDocument");
            entity.Property(e => e.AppointmentId).HasColumnName("Appointment_ID");
            entity.Property(e => e.NameDocument).HasMaxLength(50);

        });

        modelBuilder.Entity<Direction>(entity =>
        {
            entity.HasKey(e => e.IdDirection).HasName("PK__Directio__59A79AAF40CE03CE");

            entity.Property(e => e.IdDirection).HasColumnName("ID_Direction");
            entity.Property(e => e.Oms).HasColumnName("OMS");
            entity.Property(e => e.SpecialityId).HasColumnName("Speciality_ID");
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.IdDoctor).HasName("PK__Doctor__3246951CCB381FC8");

            entity.ToTable("Doctor");

            entity.Property(e => e.IdDoctor).HasColumnName("ID_Doctor");
            entity.Property(e => e.EnterPassword).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.SpecialityId).HasColumnName("Speciality_ID");
            entity.Property(e => e.Surname).HasMaxLength(50);
            entity.Property(e => e.WorkAddress).HasMaxLength(50);

        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Oms).HasName("PK__Patient__CB396B8B26D6F603");

            entity.ToTable("Patient");

            entity.Property(e => e.Oms).HasColumnName("OMS");
            entity.Property(e => e.Addresss).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LivingAddress).HasMaxLength(255);
            entity.Property(e => e.Nickname).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(18);
            entity.Property(e => e.Surname).HasMaxLength(50);
        });

        modelBuilder.Entity<ResearchDocument>(entity =>
        {
            entity.HasKey(e => e.IdResearchDocument).HasName("PK__Research__117811C60E7C47FD");

            entity.ToTable("ResearchDocument");

            entity.Property(e => e.IdResearchDocument).HasColumnName("ID_ResearchDocument");
            entity.Property(e => e.AppointmentId).HasColumnName("Appointment_ID");
            entity.Property(e => e.Attachment)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(50);

        });

        modelBuilder.Entity<Speciality>(entity =>
        {
            entity.HasKey(e => e.IdSpeciality).HasName("PK__Speciali__8D22304DEBE0DF66");

            entity.Property(e => e.IdSpeciality).HasColumnName("ID_Speciality");
            entity.Property(e => e.ImagePath).HasMaxLength(200);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Statuss>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PK__Statuss__5AC2A734E4B3C532");

            entity.ToTable("Statuss");

            entity.Property(e => e.IdStatus).HasColumnName("ID_Status");
            entity.Property(e => e.StatusName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

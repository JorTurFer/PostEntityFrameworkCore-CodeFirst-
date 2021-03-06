﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PostCore.Data;

namespace PostCore.Migrations
{
    [DbContext(typeof(PostDbContext))]
    partial class PostDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PostCore.Data.Alumnos", b =>
                {
                    b.Property<int>("IdAlumno")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdCurso");

                    b.Property<DateTime>("Nacimiento");

                    b.Property<string>("Nombre");

                    b.HasKey("IdAlumno");

                    b.HasIndex("IdCurso");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("PostCore.Data.Cursos", b =>
                {
                    b.Property<int>("IdCurso")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ciudad");

                    b.Property<int>("IdProfesor");

                    b.Property<string>("Nombre");

                    b.HasKey("IdCurso");

                    b.HasIndex("IdProfesor");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("PostCore.Data.Profesores", b =>
                {
                    b.Property<int>("IdProfesor")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("IdProfesor");

                    b.ToTable("Profesores");
                });

            modelBuilder.Entity("PostCore.Data.Alumnos", b =>
                {
                    b.HasOne("PostCore.Data.Cursos", "Curso")
                        .WithMany("Alumnos")
                        .HasForeignKey("IdCurso")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PostCore.Data.Cursos", b =>
                {
                    b.HasOne("PostCore.Data.Profesores", "Profesor")
                        .WithMany("Cursos")
                        .HasForeignKey("IdProfesor")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

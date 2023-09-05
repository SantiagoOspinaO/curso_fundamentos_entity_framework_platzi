﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using curso_fundamentos_entity_framework_platzi;

#nullable disable

namespace curso_fundamentos_entity_framework_platzi.Migrations
{
    [DbContext(typeof(TareasContext))]
    [Migration("20230905134046_InitialData")]
    partial class InitialData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("curso_fundamentos_entity_framework_platzi.Categoria", b =>
                {
                    b.Property<Guid>("categoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("peso")
                        .HasColumnType("int");

                    b.HasKey("categoriaId");

                    b.ToTable("Categoria", (string)null);

                    b.HasData(
                        new
                        {
                            categoriaId = new Guid("a9a12388-8c1a-49d5-9f6a-932fe1ea44a2"),
                            nombre = "Actividades pendientes",
                            peso = 20
                        },
                        new
                        {
                            categoriaId = new Guid("a9a12388-8c1a-49d5-9f6a-932fe1ea4402"),
                            nombre = "Actividades personales",
                            peso = 50
                        });
                });

            modelBuilder.Entity("curso_fundamentos_entity_framework_platzi.Tarea", b =>
                {
                    b.Property<Guid>("tareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("categoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("prioridad")
                        .HasColumnType("int");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("tareaId");

                    b.HasIndex("categoriaId");

                    b.ToTable("Tarea", (string)null);

                    b.HasData(
                        new
                        {
                            tareaId = new Guid("a9a12388-8c1a-49d5-9f6a-932fe1ea4410"),
                            categoriaId = new Guid("a9a12388-8c1a-49d5-9f6a-932fe1ea44a2"),
                            estado = false,
                            fechaCreacion = new DateTime(2023, 9, 5, 8, 40, 46, 726, DateTimeKind.Local).AddTicks(3296),
                            prioridad = 1,
                            titulo = "Pago de servicios publicos"
                        },
                        new
                        {
                            tareaId = new Guid("a9a12388-8c1a-49d5-9f6a-932fe1ea4411"),
                            categoriaId = new Guid("a9a12388-8c1a-49d5-9f6a-932fe1ea4402"),
                            estado = false,
                            fechaCreacion = new DateTime(2023, 9, 5, 8, 40, 46, 726, DateTimeKind.Local).AddTicks(3382),
                            prioridad = 0,
                            titulo = "Terminar de ver peliculas"
                        });
                });

            modelBuilder.Entity("curso_fundamentos_entity_framework_platzi.Tarea", b =>
                {
                    b.HasOne("curso_fundamentos_entity_framework_platzi.Categoria", "categoria")
                        .WithMany("tareas")
                        .HasForeignKey("categoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categoria");
                });

            modelBuilder.Entity("curso_fundamentos_entity_framework_platzi.Categoria", b =>
                {
                    b.Navigation("tareas");
                });
#pragma warning restore 612, 618
        }
    }
}

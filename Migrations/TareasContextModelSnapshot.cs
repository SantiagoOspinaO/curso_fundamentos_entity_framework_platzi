﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using curso_fundamentos_entity_framework_platzi;

#nullable disable

namespace curso_fundamentos_entity_framework_platzi.Migrations
{
    [DbContext(typeof(TareasContext))]
    partial class TareasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .IsRequired()
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
                });

            modelBuilder.Entity("curso_fundamentos_entity_framework_platzi.Tarea", b =>
                {
                    b.Property<Guid>("tareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("categoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .IsRequired()
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

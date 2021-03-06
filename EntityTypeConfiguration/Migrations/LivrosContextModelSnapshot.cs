﻿// <auto-generated />
using EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EntityTypeConfiguration.Migrations
{
    [DbContext(typeof(Program.LivrosContext))]
    partial class LivrosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityTypeConfiguration.Program+Livro", b =>
                {
                    b.Property<int>("LivroId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnoPublicacao");

                    b.Property<string>("Autor")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("date");

                    b.Property<string>("Titulo")
                        .HasColumnType("varchar(200)");

                    b.HasKey("LivroId");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("EntityTypeConfiguration.Program+LivroDetalhes", b =>
                {
                    b.Property<int>("LivroId");

                    b.Property<string>("Editora")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("NumeroPaginas")
                        .HasColumnType("smallint");

                    b.HasKey("LivroId");

                    b.ToTable("LivroDetalhe");
                });

            modelBuilder.Entity("EntityTypeConfiguration.Program+LivroDetalhes", b =>
                {
                    b.HasOne("EntityTypeConfiguration.Program+Livro", "Livro")
                        .WithOne("Detalhes")
                        .HasForeignKey("EntityTypeConfiguration.Program+LivroDetalhes", "LivroId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

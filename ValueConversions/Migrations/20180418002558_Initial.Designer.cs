﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using ValueConversions;

namespace ValueConversions.Migrations
{
    [DbContext(typeof(LivrosContext))]
    [Migration("20180418002558_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-preview2-30571")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ValueConversions.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("ClienteID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ValueConversions.Pedido", b =>
                {
                    b.Property<int>("PedidoID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClienteID");

                    b.Property<DateTime>("Data");

                    b.Property<int>("Status");

                    b.Property<decimal>("Valor");

                    b.HasKey("PedidoID");

                    b.HasIndex("ClienteID");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("ValueConversions.Produto", b =>
                {
                    b.Property<int>("ProdutoID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<int?>("PedidoID");

                    b.HasKey("ProdutoID");

                    b.HasIndex("PedidoID");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("ValueConversions.Pedido", b =>
                {
                    b.HasOne("ValueConversions.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID");
                });

            modelBuilder.Entity("ValueConversions.Produto", b =>
                {
                    b.HasOne("ValueConversions.Pedido")
                        .WithMany("Produtos")
                        .HasForeignKey("PedidoID");
                });
#pragma warning restore 612, 618
        }
    }
}

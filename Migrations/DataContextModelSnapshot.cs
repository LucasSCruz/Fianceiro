﻿// <auto-generated />
using System;
using Financeiro.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Financeiro.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Financeiro.API.Models.Banco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("contaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nomeBanco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Banco");
                });

            modelBuilder.Entity("Financeiro.API.Models.Conta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Conta");
                });

            modelBuilder.Entity("Financeiro.API.Models.Movimentacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataMovimentacao")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("bancoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("contaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nomeMovimentacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Movimentacao");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201208225827_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("WebApplication1.Models.Desenvolvedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("LancamentoHorasId")
                        .HasColumnType("int");

                    b.Property<int>("LancamentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LancamentoHorasId");

                    b.ToTable("Desenvolvedores");
                });

            modelBuilder.Entity("WebApplication1.Models.LancamentoHoras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("data_fim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("data_inicio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LancamentoHora");
                });

            modelBuilder.Entity("WebApplication1.Models.Desenvolvedor", b =>
                {
                    b.HasOne("WebApplication1.Models.LancamentoHoras", "LancamentoHoras")
                        .WithMany()
                        .HasForeignKey("LancamentoHorasId");

                    b.Navigation("LancamentoHoras");
                });
#pragma warning restore 612, 618
        }
    }
}

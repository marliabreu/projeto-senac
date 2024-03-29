﻿// <auto-generated />
using System;
using DotNetWebAPI_InMemoryDatabase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotNetWebAPI_InMemoryDatabase.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("DotNetWebAPI_InMemoryDatabase.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_cliente");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<int>("ContatoId")
                        .HasColumnType("int")
                        .HasColumnName("fk_contato");

                    b.Property<int>("MensagemId")
                        .HasColumnType("int")
                        .HasColumnName("fk_mensagem");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.HasKey("IdCliente");

                    b.HasIndex("ContatoId");

                    b.HasIndex("MensagemId");

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("DotNetWebAPI_InMemoryDatabase.Models.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("contato");
                });

            modelBuilder.Entity("DotNetWebAPI_InMemoryDatabase.Models.Mensagem", b =>
                {
                    b.Property<int>("IdMensagem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_mensagem");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdMensagem"));

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_hora");

                    b.Property<string>("Mensagens")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("mensagem");

                    b.HasKey("IdMensagem");

                    b.ToTable("mensagens");
                });

            modelBuilder.Entity("DotNetWebAPI_InMemoryDatabase.Models.Cliente", b =>
                {
                    b.HasOne("DotNetWebAPI_InMemoryDatabase.Models.Contato", "Contato")
                        .WithMany()
                        .HasForeignKey("ContatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DotNetWebAPI_InMemoryDatabase.Models.Mensagem", "Mensagem")
                        .WithMany()
                        .HasForeignKey("MensagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contato");

                    b.Navigation("Mensagem");
                });
#pragma warning restore 612, 618
        }
    }
}

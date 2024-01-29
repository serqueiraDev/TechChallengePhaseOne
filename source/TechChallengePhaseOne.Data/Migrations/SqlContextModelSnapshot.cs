﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechChallengePhaseOne.Data;

#nullable disable

namespace TechChallengePhaseOne.Data.Migrations
{
    [DbContext(typeof(SqlContext))]
    partial class SqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TechChallengePhaseOne.Domain.Entity.Acao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ContaInvestimentoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ContaInvestimentoId");

                    b.ToTable("Acao");
                });

            modelBuilder.Entity("TechChallengePhaseOne.Domain.Entity.ContaInvestimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("ContaInvestimento");
                });

            modelBuilder.Entity("TechChallengePhaseOne.Domain.Entity.Acao", b =>
                {
                    b.HasOne("TechChallengePhaseOne.Domain.Entity.ContaInvestimento", null)
                        .WithMany("CarteiraAcoes")
                        .HasForeignKey("ContaInvestimentoId");
                });

            modelBuilder.Entity("TechChallengePhaseOne.Domain.Entity.ContaInvestimento", b =>
                {
                    b.Navigation("CarteiraAcoes");
                });
#pragma warning restore 612, 618
        }
    }
}

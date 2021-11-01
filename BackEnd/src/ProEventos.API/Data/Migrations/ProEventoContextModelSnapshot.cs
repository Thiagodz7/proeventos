﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProEventos.API.Data;

namespace ProEventos.API.Data.Migrations
{
    [DbContext(typeof(ProEventoContext))]
    partial class ProEventoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProEventos.API.Models.Evento", b =>
                {
                    b.Property<int>("eventoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dataEvento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imagemUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("local")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qtdPessoas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tema")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("eventoId");

                    b.ToTable("Eventos");
                });
#pragma warning restore 612, 618
        }
    }
}

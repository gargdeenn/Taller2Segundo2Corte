﻿// <auto-generated />
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(PulsacionesContext))]
    partial class PulsacionesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Persona", b =>
                {
                    b.Property<string>("identificacion")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("pulsacion")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("sexo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("identificacion");

                    b.ToTable("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}

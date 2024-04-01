﻿// <auto-generated />
using LearnEF.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LearnEF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240401224839_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LearnEF.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("NVarchar(250)")
                        .HasColumnName("address");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("NVarchar(50)")
                        .HasColumnName("customer_name");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("MobilePhone")
                        .IsRequired()
                        .HasColumnType("NVarchar(14)")
                        .HasColumnName("mobile_phone");

                    b.HasKey("Id");

                    b.ToTable("m_customer");
                });
#pragma warning restore 612, 618
        }
    }
}

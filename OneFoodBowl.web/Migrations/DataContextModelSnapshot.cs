﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OneFoodBowl.web.Data;

namespace OneFoodBowl.web.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OneFoodBowl.web.Data.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("FirstName");

                    b.Property<int?>("GenderId");

                    b.Property<string>("Height");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("LastName");

                    b.Property<string>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("OneFoodBowl.web.Data.Entities.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("OneFoodBowl.web.Data.Entities.Customer", b =>
                {
                    b.HasOne("OneFoodBowl.web.Data.Entities.Gender", "Gender")
                        .WithMany("Customers")
                        .HasForeignKey("GenderId");
                });
#pragma warning restore 612, 618
        }
    }
}

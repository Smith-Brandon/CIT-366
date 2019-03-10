﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Super_Mega_Desk.Models;

namespace Super_Mega_Desk.Migrations
{
    [DbContext(typeof(Super_Mega_DeskContext))]
    [Migration("20190307163203_Date2")]
    partial class Date2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Super_Mega_Desk.Models.Desk", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Area");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<string>("Date");

                    b.Property<int>("Depth");

                    b.Property<int>("DrawerNumber");

                    b.Property<decimal>("FinalCost");

                    b.Property<string>("Material")
                        .IsRequired();

                    b.Property<decimal>("ShippingCost");

                    b.Property<int>("ShippingDays");

                    b.Property<int>("Width");

                    b.HasKey("ID");

                    b.ToTable("Desk");
                });
#pragma warning restore 612, 618
        }
    }
}

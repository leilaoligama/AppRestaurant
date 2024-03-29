﻿// <auto-generated />
using AppRestaurant.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppRestaurant.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    partial class RestaurantContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("AppRestaurant.Models.DishType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DishTypes");
                });

            modelBuilder.Entity("AppRestaurant.Models.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("AppRestaurant.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdMeal")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("QuantityItems")
                        .HasColumnType("int");

                    b.Property<string>("TimeOfDay")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdMeal")
                        .IsUnique();

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AppRestaurant.Models.Order", b =>
                {
                    b.HasOne("AppRestaurant.Models.Meal", "Meal")
                        .WithOne("Order")
                        .HasForeignKey("AppRestaurant.Models.Order", "IdMeal")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("AppRestaurant.Models.Meal", b =>
                {
                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}

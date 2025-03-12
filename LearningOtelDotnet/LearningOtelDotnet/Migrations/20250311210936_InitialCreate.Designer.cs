﻿// <auto-generated />
using LearningOtelDotnet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LearningOtelDotnet.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250311210936_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("LearningOtelDotnet.Model.TodoModel", b =>
                {
                    b.Property<int>("TodoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TodoId");

                    b.ToTable("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using GenerateQuiz.DAL.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GenerateQuiz.DAL.Migrations
{
    [DbContext(typeof(QuizContext))]
    [Migration("20201018103703_AddBlogCreatedTimestamp")]
    partial class AddBlogCreatedTimestamp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("GenerateQuiz.ENTITIES.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("A1")
                        .HasColumnType("TEXT");

                    b.Property<string>("A2")
                        .HasColumnType("TEXT");

                    b.Property<string>("A3")
                        .HasColumnType("TEXT");

                    b.Property<string>("A4")
                        .HasColumnType("TEXT");

                    b.Property<string>("B1")
                        .HasColumnType("TEXT");

                    b.Property<string>("B2")
                        .HasColumnType("TEXT");

                    b.Property<string>("B3")
                        .HasColumnType("TEXT");

                    b.Property<string>("B4")
                        .HasColumnType("TEXT");

                    b.Property<string>("C1")
                        .HasColumnType("TEXT");

                    b.Property<string>("C2")
                        .HasColumnType("TEXT");

                    b.Property<string>("C3")
                        .HasColumnType("TEXT");

                    b.Property<string>("C4")
                        .HasColumnType("TEXT");

                    b.Property<string>("CorrectAnswer1")
                        .HasColumnType("TEXT");

                    b.Property<string>("CorrectAnswer2")
                        .HasColumnType("TEXT");

                    b.Property<string>("CorrectAnswer3")
                        .HasColumnType("TEXT");

                    b.Property<string>("CorrectAnswer4")
                        .HasColumnType("TEXT");

                    b.Property<string>("D1")
                        .HasColumnType("TEXT");

                    b.Property<string>("D2")
                        .HasColumnType("TEXT");

                    b.Property<string>("D3")
                        .HasColumnType("TEXT");

                    b.Property<string>("D4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Header")
                        .HasColumnType("TEXT");

                    b.Property<string>("Link")
                        .HasColumnType("TEXT");

                    b.Property<string>("Selection1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Selection2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Selection3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Selection4")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("GenerateQuiz.ENTITIES.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("userName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });
#pragma warning restore 612, 618
        }
    }
}

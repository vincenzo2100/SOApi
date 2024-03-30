﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SOApi.Models;

#nullable disable

namespace SOApi.Migrations
{
    [DbContext(typeof(TagContext))]
    [Migration("20240330165132_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("SOApi.Models.CollectiveExternalLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CollectivesId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CollectivesId");

                    b.ToTable("CollectiveExternalLinks");
                });

            modelBuilder.Entity("SOApi.Models.Collectives", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Link")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Slug")
                        .HasColumnType("TEXT");

                    b.Property<int>("TagId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tags")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.ToTable("Collectives");
                });

            modelBuilder.Entity("SOApi.Models.Tag", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Has_Synonyms")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Is_Moderator_Only")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Is_Required")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Last_Activity_Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Synonyms")
                        .HasColumnType("TEXT");

                    b.Property<int?>("User_Id")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("SOApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SOApi.Models.CollectiveExternalLink", b =>
                {
                    b.HasOne("SOApi.Models.Collectives", null)
                        .WithMany("External_Links")
                        .HasForeignKey("CollectivesId");
                });

            modelBuilder.Entity("SOApi.Models.Collectives", b =>
                {
                    b.HasOne("SOApi.Models.Tag", null)
                        .WithMany("Collectives")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SOApi.Models.Collectives", b =>
                {
                    b.Navigation("External_Links");
                });

            modelBuilder.Entity("SOApi.Models.Tag", b =>
                {
                    b.Navigation("Collectives");
                });
#pragma warning restore 612, 618
        }
    }
}

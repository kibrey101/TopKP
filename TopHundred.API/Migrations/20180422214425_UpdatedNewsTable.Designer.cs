﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TopHundred.API.Entities;

namespace TopHundred.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180422214425_UpdatedNewsTable")]
    partial class UpdatedNewsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TopHundred.API.Entities.IcoItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<DateTime>("EndTime");

                    b.Property<int>("IcoTypeEnumeration");

                    b.Property<string>("IconLink")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Price");

                    b.Property<string>("PriceCurrency")
                        .IsRequired();

                    b.Property<int>("Rank");

                    b.Property<DateTime>("StartTime");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("TotalTokenCount");

                    b.Property<Guid?>("UserId");

                    b.Property<string>("WhitePaper")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("IcoItems");
                });

            modelBuilder.Entity("TopHundred.API.Entities.IcoLink", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("IcoItemId");

                    b.Property<string>("Link");

                    b.Property<int>("LinkIcon");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("IcoItemId");

                    b.ToTable("IcoLink");
                });

            modelBuilder.Entity("TopHundred.API.Entities.News", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorFirstName")
                        .IsRequired();

                    b.Property<string>("AuthorImage");

                    b.Property<string>("AuthorLastName")
                        .IsRequired();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<string>("ContentImage");

                    b.Property<string>("HighLight")
                        .IsRequired()
                        .HasMaxLength(350);

                    b.Property<string>("HighLightImage");

                    b.Property<DateTime>("PublishDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("TopHundred.API.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TopHundred.API.Entities.IcoItem", b =>
                {
                    b.HasOne("TopHundred.API.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TopHundred.API.Entities.IcoLink", b =>
                {
                    b.HasOne("TopHundred.API.Entities.IcoItem", "IcoItem")
                        .WithMany("IcoLinks")
                        .HasForeignKey("IcoItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

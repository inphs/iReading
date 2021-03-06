﻿// <auto-generated />
using iReading.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace iReading.DAL.Migrations
{
    [DbContext(typeof(ArticleDbContext))]
    [Migration("20170918090820_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("iReading.Entity.Articles", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Category");

                    b.Property<string>("Details");

                    b.Property<int>("IsDelete");

                    b.Property<DateTime>("IssueTime");

                    b.Property<string>("Logo");

                    b.Property<int>("Status");

                    b.Property<string>("Summary");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("ArticleId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("iReading.Entity.ArticleViews", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<int>("Hits");

                    b.Property<int>("ShowHits");

                    b.Property<int>("UserAgent");

                    b.Property<string>("UserIp");

                    b.Property<DateTime>("ViewTime");

                    b.HasKey("ArticleId");

                    b.ToTable("ArticleViews");
                });
#pragma warning restore 612, 618
        }
    }
}

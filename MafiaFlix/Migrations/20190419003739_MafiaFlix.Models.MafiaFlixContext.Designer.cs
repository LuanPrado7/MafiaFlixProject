﻿// <auto-generated />
using MafiaFlix.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MafiaFlix.Migrations
{
    [DbContext(typeof(MafiaFlixContext))]
    [Migration("20190419003739_MafiaFlix.Models.MafiaFlixContext")]
    partial class MafiaFlixModelsMafiaFlixContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MafiaFlix.Models.Movie", b =>
                {
                    b.Property<long>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cover");

                    b.Property<string>("Description");

                    b.Property<string>("Direction");

                    b.Property<int>("Duration");

                    b.Property<string>("Name");

                    b.Property<int>("ReleaseYear");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
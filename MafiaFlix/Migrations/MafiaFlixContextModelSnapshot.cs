﻿// <auto-generated />
using MafiaFlix.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MafiaFlix.Migrations
{
    [DbContext(typeof(MafiaFlixContext))]
    partial class MafiaFlixContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new { MovieId = 1L, Cover = "godfather", Description = "A saga conta a história de uma família mafiosa que luta para estabelecer sua supremacia na América depois da Segunda Guerra. Uma tentativa de assassinato deixa Vito Corleone incapacitado e força os filhos Michael e Sonny a assumirem os negócios.", Direction = "Francis Ford Coppola", Duration = 175, Name = "The Godfather", ReleaseYear = 1972 },
                        new { MovieId = 2L, Cover = "bonnie-clyde", Description = "Bonnie Parker se apaixona por um ex-presidiário, Clyde Barrow e decide acompanhá-lo. Juntos, iniciam uma carreira de crimes roubando carros e assaltando bancos até serem perseguidos pela polícia por todo o país.", Direction = "Arthur Penn", Duration = 112, Name = "Bonnie & Clyde", ReleaseYear = 1967 }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
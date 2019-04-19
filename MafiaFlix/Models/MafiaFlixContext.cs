using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MafiaFlix.Models
{
    public class MafiaFlixContext : DbContext
    {
        public MafiaFlixContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                MovieId = 1,
                Name = "The Godfather",
                Direction = "Francis Ford Coppola",
                Duration = 175,
                ReleaseYear = 1972,
                Description = "A saga conta a história de uma família mafiosa que luta para estabelecer sua supremacia na América depois da Segunda Guerra. Uma tentativa de assassinato deixa Vito Corleone incapacitado e força os filhos Michael e Sonny a assumirem os negócios.",
                Cover = "godfather"
            }, new Movie
            {
                MovieId = 2,
                Name = "Bonnie & Clyde",
                Direction = "Arthur Penn",
                Duration = 112,
                ReleaseYear = 1967,
                Description = "Bonnie Parker se apaixona por um ex-presidiário, Clyde Barrow e decide acompanhá-lo. Juntos, iniciam uma carreira de crimes roubando carros e assaltando bancos até serem perseguidos pela polícia por todo o país.",
                Cover = "bonnie-clyde"
            });
        }
    }
}

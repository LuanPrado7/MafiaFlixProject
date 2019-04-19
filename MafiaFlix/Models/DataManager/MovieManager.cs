using MafiaFlix.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MafiaFlix.Models.DataManager
{
    public class MovieManager: IDataRepository<Movie>
    {
        readonly MafiaFlixContext _mafiaFlixContext;

        public MovieManager(MafiaFlixContext context)
        {
            _mafiaFlixContext = context;
        }

        public IEnumerable<Movie> GetAll()
        {
            return _mafiaFlixContext.Movies.ToList();
        }

        public Movie Get(long id)
        {
            return _mafiaFlixContext.Movies
                .FirstOrDefault(e => e.MovieId == id);
        }

        public void Add(Movie movie)
        {
            _mafiaFlixContext.Movies.Add(movie);
            _mafiaFlixContext.SaveChanges();
        }

        public void Update(Movie movie, Movie entity)
        {
            movie.Name = entity.Name;
            movie.Direction = entity.Direction;
            movie.Duration = entity.Duration;
            movie.ReleaseYear = entity.ReleaseYear;
            movie.Description = entity.Description;
            movie.Cover = entity.Cover;

            _mafiaFlixContext.SaveChanges();
        }

        public void Delete(Movie movie)
        {
            _mafiaFlixContext.Movies.Remove(movie);
            _mafiaFlixContext.SaveChanges();
        }
    }
}

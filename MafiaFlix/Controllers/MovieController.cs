using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MafiaFlix.Models;
using MafiaFlix.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MafiaFlix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IDataRepository<Movie> _dataRepository;

        public MovieController(IDataRepository<Movie> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Movie
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Movie> Movies = _dataRepository.GetAll();
            return Ok(Movies);
        }

        // GET: api/Movie/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            Movie Movie = _dataRepository.Get(id);

            if (Movie == null)
            {
                return NotFound("The Movie record couldn't be found.");
            }

            return Ok(Movie);
        }

        // POST: api/Movie
        [HttpPost]
        public IActionResult Post([FromBody] Movie Movie)
        {
            if (Movie == null)
            {
                return BadRequest("Movie is null.");
            }

            _dataRepository.Add(Movie);
            return CreatedAtRoute(
                  "Get",
                  new { Id = Movie.MovieId },
                  Movie);
        }

        // PUT: api/Movie/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Movie Movie)
        {
            if (Movie == null)
            {
                return BadRequest("Movie is null.");
            }

            Movie MovieToUpdate = _dataRepository.Get(id);
            if (MovieToUpdate == null)
            {
                return NotFound("The Movie record couldn't be found.");
            }

            _dataRepository.Update(MovieToUpdate, Movie);
            return NoContent();
        }

        // DELETE: api/Movie/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Movie Movie = _dataRepository.Get(id);
            if (Movie == null)
            {
                return NotFound("The Movie record couldn't be found.");
            }

            _dataRepository.Delete(Movie);
            return NoContent();
        }
    }
}
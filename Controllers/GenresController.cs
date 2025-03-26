using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using MoviesAPI.Entities;

namespace MoviesAPI.Controllers
{
    [Route("api/genres")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IOutputCacheStore outputCacheStore;
        private readonly ApplicationDbContext context;
        private const string cacheTag = "genres";

        public GenresController(IOutputCacheStore outputCacheStore, ApplicationDbContext context)
        {
            this.outputCacheStore = outputCacheStore;
            this.context = context;
        }

        [HttpGet]//api/genres
        [OutputCache(Tags = [cacheTag])]
        public List<Genre> Get()
        {
            return new List<Genre>
            {
                new Genre { Id = 1, Name = "Drama" },
                new Genre { Id = 2, Name = "Action" },
             };
        }




        [HttpGet("{id:int}", Name = "GetGenreById")]   //api/genres/500
        [OutputCache(Tags = [cacheTag])]
        public async Task<ActionResult<Genre>> Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Genre genre)
        {
           context.Add(genre);
            await context.SaveChangesAsync();
            await outputCacheStore.EvictByTagAsync(cacheTag, default);
            return CreatedAtRoute("GetGenreById", new { id = genre.Id }, genre);
        }

        [HttpPut]
        public void Put()
        {

        }

        [HttpDelete]
        public void Delete()
        {

        }
    }
}

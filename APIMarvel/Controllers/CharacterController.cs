using APIMarvel.EF;
using APIMarvel.Model.Characters;
using APIMarvel.Model.Comics;
using APIMarvel.Model.Events;
using APIMarvel.Model.Series;
using APIMarvel.Model.Stories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMarvel.Controllers
{
    [ApiController]
    [Route("v1/public/character")]
    public class CharacterController : ControllerBase
    {
        [HttpGet]
        [Route("{id:long}")]
        public async Task<ActionResult<Character>> Get([FromServices] Context context, long id)
        {
            var character = await context.Characters.AsNoTracking()
                                                    .Where(x => x.Id == id)
                                                    .Include(x => x.Comics)
                                                    .Include(x => x.Events)
                                                    .Include(x => x.Series)
                                                    .Include(x => x.Stories)
                                                    .FirstOrDefaultAsync();

            if (character == null)
                throw new ArgumentException("Register Not Found");

            return character;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Character>>> GetAll([FromServices] Context context)
        {
            var characters = await context.Characters.AsNoTracking()
                                                     .Include(x => x.Comics)
                                                     .Include(x => x.Events)
                                                     .Include(x => x.Series)
                                                     .Include(x => x.Stories)
                                                     .ToListAsync();

            if (characters.Count() < 1)
                throw new ArgumentException("Register Not Found");

            return characters;
        }

        [HttpGet]
        [Route("{id:long}/comics")]
        public async Task<ActionResult<List<Comic>>> GetAllComics([FromServices] Context context, long id)
        {
            var comics = await context.Comics.AsNoTracking()
                                             .Where(x => x.CharacterId == id)
                                             .ToListAsync();

            if (comics.Count() < 1)
                throw new ArgumentException("Register Not Found");

            return comics;
        }

        [HttpGet]
        [Route("{id:long}/events")]
        public async Task<ActionResult<List<Event>>> GetAllEvents([FromServices] Context context, long id)
        {
            var events = await context.Events.AsNoTracking()
                                             .Where(x => x.CharacterId == id)
                                             .ToListAsync();

            if (events.Count() < 1)
                throw new ArgumentException("Register Not Found");

            return events;
        }

        [HttpGet]
        [Route("{id:long}/series")]
        public async Task<ActionResult<List<Serie>>> GetAllSeries([FromServices] Context context, long id)
        {
            var series = await context.Series.AsNoTracking()
                                             .Where(x => x.CharacterId == id)
                                             .ToListAsync();

            if (series.Count() < 1)
                throw new ArgumentException("Register Not Found");

            return series;
        }

        [HttpGet]
        [Route("{id:long}/stories")]
        public async Task<ActionResult<List<Storie>>> GetAllStories([FromServices] Context context, long id)
        {
            var stories = await context.Stories.AsNoTracking()
                                               .Where(x => x.CharacterId == id)
                                               .ToListAsync();

            if (stories.Count() < 1)
                throw new ArgumentException("Register Not Found");

            return stories;
        }
    }
}

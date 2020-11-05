using APIMarvel.Model.Characters;
using APIMarvel.Model.Comics;
using APIMarvel.Model.Events;
using APIMarvel.Model.Series;
using APIMarvel.Model.Stories;
using Microsoft.EntityFrameworkCore;

namespace APIMarvel.EF
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { 
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Comic> Comics { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Storie> Stories { get; set; }
    }
}

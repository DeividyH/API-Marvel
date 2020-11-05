using APIMarvel.Model.Characters;
using APIMarvel.Model.Comics;
using APIMarvel.Model.Events;
using APIMarvel.Model.Series;
using APIMarvel.Model.Stories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace APIMarvel.EF
{
    public class Seed
    {
        public static void Initializa(IServiceProvider serviceProvider)
        {
            CreateCharacter(serviceProvider);
        }

        protected static void CreateCharacter(IServiceProvider serviceProvider)
        {
            using (var context = new Context(
               serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                List<Comic> comicList1 = new List<Comic>();
                List<Event> eventList1 = new List<Event>();
                List<Serie> serieList1 = new List<Serie>();
                List<Storie> storieList1 = new List<Storie>();

                comicList1.Add(new Comic
                {
                    Id = 1,
                    Title = "Quadrinho Wolverine",
                    Modified = DateTime.Today,
                    CharacterId = 1
                });

                eventList1.Add(new Event
                {
                    Id = 1,
                    Title = "Apresentação",
                    Description = "Apresentação do quadrinho do wolverine",
                    Modified = DateTime.Today,
                    CharacterId = 1
                });

                serieList1.Add(new Serie
                {
                    Id = 1,
                    Title = "W de Wolverine",
                    Description = "Série sobre o personagem wolverine",
                    Modified = DateTime.Today,
                    CharacterId = 1
                });
                
                storieList1.Add(new Storie
                {
                    Id = 1,
                    Title = "Primeira história do wolverine",
                    Description = "História sobre o wolverine",
                    Modified = DateTime.Today,
                    CharacterId = 1
                });

                context.Characters.Add(new Character
                {
                    Id = 1,
                    Name = "Wolverine",
                    Description = "Marvel",
                    Modified = DateTime.Today,
                    ResourceURL = "",
                    Comics = comicList1,
                    Events = eventList1,
                    Series = serieList1,
                    Stories = storieList1
                });

                context.SaveChangesAsync();

                List<Comic> comicList2 = new List<Comic>();
                List<Event> eventList2 = new List<Event>();
                List<Serie> serieList2 = new List<Serie>();
                List<Storie> storieList2 = new List<Storie>();

                comicList2.Add(new Comic
                {
                    Id = 2,
                    Title = "Quadrinho Hulk",
                    Modified = DateTime.Today,
                    CharacterId = 2
                });

                eventList2.Add(new Event
                {
                    Id = 2,
                    Title = "Apresentação",
                    Description = "Apresentação do quadrinho do hulk",
                    Modified = DateTime.Today,
                    CharacterId = 2
                });
                
                serieList2.Add(new Serie
                {
                    Id = 2,
                    Title = "H de hulk",
                    Description = "Série sobre o personagem hulk",
                    Modified = DateTime.Today,
                    CharacterId = 2
                });

                storieList2.Add(new Storie
                {
                    Id = 2,
                    Title = "Primeira história do hulk",
                    Description = "História sobre o hulk",
                    Modified = DateTime.Today,
                    CharacterId = 2
                });

                context.Characters.Add(new Character
                {
                    Id = 2,
                    Name = "Hulk",
                    Description = "Marvel",
                    Modified = DateTime.Today,
                    ResourceURL = "",
                    Comics = comicList2,
                    Events = eventList2,
                    Series = serieList2,
                    Stories = storieList2
                });

                context.SaveChangesAsync();
            }
        }
    }
}

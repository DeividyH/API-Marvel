using APIMarvel.Model.Comics;
using APIMarvel.Model.Events;
using APIMarvel.Model.Images;
using APIMarvel.Model.Series;
using APIMarvel.Model.Stories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APIMarvel.Model.Characters
{
    public class Character
    {
        [Key]
        public long Id { get; set; }

        [MaxLength(256)]
        public string Name { get; set; }

        [MaxLength(512)]
        public string Description { get; set; }
        public DateTime Modified { get; set; }

        [MaxLength(128)]
        public string ResourceURL { get; set; }

        public Image Thumbnail { get; set; }

        public List<Comic> Comics { get; set; }
        public List<Event> Events { get; set; }
        public List<Serie> Series { get; set; }
        public List<Storie> Stories { get; set; }
    }
}

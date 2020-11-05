using APIMarvel.Model.Images;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIMarvel.Model.Events
{
    public class Event
    {
        [Key]
        public long Id { get; set; }

        [MaxLength(256)]
        public string Title { get; set; }

        [MaxLength(512)]
        public string Description { get; set; }

        [MaxLength(128)]
        public string ResourceURL { get; set; }

        public DateTime Modified { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Image Thumbnail { get; set; }

        [ForeignKey("CharacterId")]
        public long? CharacterId { get; set; }
    }
}

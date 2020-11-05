using APIMarvel.Model.Characters;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIMarvel.Model.Comics
{
    public class Comic
    {
        [Key]
        public long Id { get; set; }

        public int DigitalId { get; set; }

        [MaxLength(256)]
        public string Title { get; set; }

        public double IssueNumber { get; set; }

        [MaxLength(256)]
        public string VariantDescription { get; set; }

        [MaxLength(512)]
        public string Description { get; set; }

        public DateTime Modified { get; set; }

        [MaxLength(60)]
        public string Isbn { get; set; }

        [MaxLength(60)]
        public string Upc { get; set; }

        [MaxLength(60)]
        public string DiamondCode { get; set; }

        [MaxLength(60)]
        public string Ean { get; set; }

        [MaxLength(60)]
        public string Issn { get; set; }

        [MaxLength(60)]
        public string Format { get; set; }

        public int pageCount { get; set; }

        [ForeignKey("CharacterId")]
        public long? CharacterId { get; set; }
    }
}

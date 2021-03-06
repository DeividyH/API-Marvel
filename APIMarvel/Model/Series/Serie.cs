﻿using APIMarvel.Model.Images;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIMarvel.Model.Series
{
    public class Serie
    {
        [Key]
        public long Id { get; set; }

        [MaxLength(256)]
        public string Title { get; set; }

        [MaxLength(512)]
        public string Description { get; set; }

        [MaxLength(128)]
        public string ResourceURL { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }

        [MaxLength(128)]
        public string Rating { get; set; }
        public DateTime Modified { get; set; }
        public Image thumbnail { get; set; }

        [ForeignKey("CharacterId")]
        public long? CharacterId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIMarvel.Model.Images
{
    public class Image
    {
        [Key]
        public long Id { get; set; }
        
        [MaxLength(512)]
        public string Path { get; set; }

        [MaxLength(3)]
        public string Extension { get; set; }

        [ForeignKey("CharacterId")]
        public long? CharacterId { get; set; }

        [ForeignKey("EventId")]
        public long? EventId { get; set; }

        [ForeignKey("SerieId")]
        public long? SerieId { get; set; }
    }
}

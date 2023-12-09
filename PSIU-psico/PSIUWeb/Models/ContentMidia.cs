using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PSIUWeb.Models
{
    public class ContentMidia
    {
        [Key]
        public int Id { get; set; }

        public int MidiaId { get; set; }
        [ForeignKey("MidiaId")]
        public Midia? Midia { get; set; }

        public int ContentId { get; set; }
        [ForeignKey("ContentId")]

        public Content? Content { get; set; }
    }
}




using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PSIUWeb.Models
{
    public class Midia
    {
        [Key]
        public int MidiaId { get; set; }

        [Required(ErrorMessage = "URL requerida.")]
        [Display(Name = "Link")]
        public string? URL { get; set; }

        [Required(ErrorMessage = "Tipo de Midia requerido.")]
        [Display(Name = "Midia")]
        public string? TipoMidia { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; }
        public AppUser? User { get; set; }
    }
}

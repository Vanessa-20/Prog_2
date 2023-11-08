using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSIUWeb.Models
{
    public enum Race { 
        Asiático, 
        Branco, 
        Indigena, 
        Negro, 
        Pardo, 
        Outros
    }

    public class Pacient
    {
        [Key]
        public int Id { get; set; }
        
        
        [Required(ErrorMessage = "Nome requerido")]
        [Display(Name = "Nome completo")]
        public string? Name { get; set; }
        
        
        [Required(ErrorMessage = "Data requerida")]
        [Display(Name = "Data de nascimento")]
        public DateTime BirthDate { get; set; }
        
        
        [Required(ErrorMessage = "Peso requerido")]
        [Display(Name = "Peso do paciente")]
        public decimal Weight { get; set; }
        
        [Required(ErrorMessage = "Altura requerida")]
        [Display(Name = "Altura do paciente")]
        public decimal Height { get; set; }

        [Required(ErrorMessage = "Raça requerido")]
        [Display(Name = "Raça")]
        public Race Race { get; set; }
        
        [ForeignKey("User")]
        public string? UserId { get; set; }
        public AppUser? User { get; set; }

    }
}

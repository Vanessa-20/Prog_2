using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;



namespace PSIUWeb.Models
{
    public enum Gender { Feminino, Masculino, Outros }
    public class AppUser: IdentityUser
    {
        [Required(ErrorMessage = "Nome requerido.")]
        [Display(Name = "Nome completo")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Datade nascimento requerida.")]
        [Display(Name = "Data de nascimento")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Gênero/sexo requerido.")]
        [Display(Name = "Gênero/sexo")]
        public Gender Gender { get; set; }

        public DateTime CreationDate { get; set; }
    }
}

﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PSIUWeb.Models
{
    public enum Gender { Faminino, Masculino, Outros }

    public class AppUser : IdentityUser
    {
        [Required(ErrorMessage = "Nome Requerido.")]
        [Display(Name = "Nome Completo")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Data Nascimento Requerido.")]
        [Display(Name = "Data de Nascimento")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Sexo/Gêmero Requerido.")]
        [Display(Name = "Sexo/Gênero")]
        public Gender Gender { get; set; }

        public DateTime CreationDate { get; set; }
    }
}

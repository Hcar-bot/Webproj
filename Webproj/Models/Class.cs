using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Webproj.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Nome Completo")]
        public string? NomeCompleto { get; set; }

        [Display(Name = "Personagens Cadastrados")]
        public ICollection<Personagem>? Personagens { get; set; }

    }
}

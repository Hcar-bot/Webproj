using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Webproj.Models
{
    public class Universo
    {
        public int Id { get; set; }

        [Display(Name = "Nome do Universo")]
        [Required(ErrorMessage = "O nome do universo é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        public ICollection<Personagem>? Personagens { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Webproj.Models
{
    public class Habilidade
    {
        public int Id { get; set; }

        [Display(Name = "Nome da Habilidade")]
        [Required(ErrorMessage = "O nome da habilidade é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }
        public ICollection<Personagem>? Personagens { get; set; }


    }
}

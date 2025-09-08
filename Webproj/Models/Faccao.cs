using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Webproj.Models
{
    public class Faccao
    {
        public int Id { get; set; }

        [Display(Name = "Nome da Facção")]
        [Required(ErrorMessage = "O nome da facção é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        public ICollection<Personagem>? Personagens { get; set; }


    }
}

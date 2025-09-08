using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Webproj.Models
{
    [Table("Personagens")]
    public class Personagem
    {
        [Display (Name = "ID")]
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        

        [Display(Name = "Nome do Personagem")]
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(150, ErrorMessage = "O nome deve ter no máximo 150 caracteres.")]
        public string Nome { get; set; }

        [Display(Name = "Biografia")]
        public string? Descricao { get; set; }

        [Display(Name = "Data de Criação")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DataCriacao { get; set; }

        [Display(Name = "Universo")]
        public int UniversoId { get; set; }

        public string? UsuarioId { get; set; }

        public Universo? Universo { get; set; }
        public ApplicationUser? Usuario { get; set; }

        public ICollection<Habilidade>? Habilidades { get; set; }
        public ICollection<Faccao>? Faccoes { get; set; }
    }



}


using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Categoria
    {
        public long Id { get; set; }
        // Using some data annotations. This is similar to "@" annotations from java.
        [Required(ErrorMessage = "O campo descrição é obrigatório.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        // public List<Produto> Produtos { get; set; }
    }
}
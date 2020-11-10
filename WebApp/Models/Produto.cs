using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Produto
    {
        public long Id { get; set; }
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo preço é obrigatório.")]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }
        public long CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
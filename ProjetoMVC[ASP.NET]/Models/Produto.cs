using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC_ASP.NET_.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O campo quantidade é obrigatório")]
        [Range(1, 10, ErrorMessage ="Valor fora da faixa")]
        public int Quantidade { get; set; }
        [Display(Name = "Categorias")]
        [Required(ErrorMessage = "Escolha uma categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

    }
}

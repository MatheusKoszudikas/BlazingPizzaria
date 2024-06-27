using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazingPizza.Api.Entites
{
    public class CarrinhoDeCompra
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        public ICollection<CarrinhoDeItems>? Items { get; set; }

        public DateTime DataCriacao { get; set; }
    }
}

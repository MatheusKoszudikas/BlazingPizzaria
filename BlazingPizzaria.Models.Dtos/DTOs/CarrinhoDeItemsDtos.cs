
namespace BlazingPizzaria.Models.DTOs
{
    public class CarrinhoDeItemsDtos
    {

        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public ProdutoDtos? Produto { get; set; }

        public int Quantidade { get; set; }
        public int CarrinhoDeCompraId { get; set; }
        public CarrinhoDeCompraDtos? CarrinhoDeCompra { get; set; }
    }
}

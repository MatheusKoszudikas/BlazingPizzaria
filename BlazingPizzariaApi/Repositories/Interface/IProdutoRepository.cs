using BlazingPizza.Api.Entites;

namespace BlazingPizza.Api.Repositories.Interface
{
    public interface IProdutoRepository
    {
        Task<Produto?> GetItem(int id);
        Task<IEnumerable<Produto?>> GetItens();
        Task<IEnumerable<Categoria?>> GetItensPorCategorias(int id);
    }
}

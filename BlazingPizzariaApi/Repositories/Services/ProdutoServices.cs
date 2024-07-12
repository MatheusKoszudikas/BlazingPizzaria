using BlazingPizza.Api.Dependencias;
using BlazingPizza.Api.Entites;
using BlazingPizza.Api.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace BlazingPizza.Api.Repositories.Services
{
    public class ProdutoServices : IProdutoRepository
    {
        private readonly InjectServicesApi _services;
        public ProdutoServices(InjectServicesApi services)
        {
            _services = services;
        }


        public async Task<IEnumerable<Categoria?>> GetItensPorCategorias(int id)
        {
            var produto = await _services._dbContext.Categorias
                            .Include(p => p.Produtos)
                                  .ThenInclude(p => p.Dimensoes)
                            .Include(p => p.Produtos)
                                      .ThenInclude(p => p.Avaliacao)
                                                    .ThenInclude(a => a.Revisao)
                            .Include(p => p.Produtos)
                                   .ThenInclude(p => p.Atributos)
                            .Include(p => p.Produtos)
                                  .ThenInclude(p => p.Imagem)
                            .Where(c => c.Id == id).ToListAsync();
            return produto;
        }

        public async Task<IEnumerable<Produto?>> GetItens()
        {
            var produtosComDetalhes = await _services._dbContext.Produtos
                            .Include(p => p.Dimensoes)
                            .Include(p => p.Avaliacao)
                                      .ThenInclude(p => p.Revisao)
                            .Include(p => p.Atributos)
                            .Include(a => a.Imagem).ToListAsync();

            return produtosComDetalhes;
        }
        public async Task<Produto?> GetItem(int id)
        {
            var produto = await _services._dbContext.Produtos
                            .Include(p => p.Dimensoes)
                            .Include(p => p.Avaliacao)
                                      .ThenInclude(p => p.Revisao)
                            .Include(p => p.Atributos)
                            .Include(a => a.Imagem).SingleOrDefaultAsync(c => c.Id == id);

            return produto;

        }
    }
}


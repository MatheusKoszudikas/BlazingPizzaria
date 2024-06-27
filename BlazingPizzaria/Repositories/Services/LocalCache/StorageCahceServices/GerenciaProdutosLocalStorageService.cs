using BlazingPizza.Dependencias;
using BlazingPizza.Repositories.Interface;
using BlazingPizza.Repositories.Interface.LocalCache.StorageCahceServices;
using BlazingPizzaria.Models.DTOs;
using Blazored.LocalStorage;

namespace BlazingPizza.Repositories.Services.LocalCache.StorageCahceServices
{
    public class GerenciaProdutosLocalStorageService : IGerenciaProdutosLocalStorageService
    {
        private const string _key = "produtosDTos";

        private readonly ILocalStorageService _localStorageService;

        private readonly InjectServicesWeb _injectServicesWeb;

        private readonly IProdutoServices _produtoServices;
        public GerenciaProdutosLocalStorageService(ILocalStorageService localStorageService,InjectServicesWeb InjectServicesWeb, 
            IProdutoServices ProdutoServices)
        {
            _localStorageService = localStorageService;
            _injectServicesWeb = InjectServicesWeb;
            _produtoServices = ProdutoServices;
        }

        public async Task<IEnumerable<ProdutoDtos>> GetCollectionItem()
        {
            return await this._localStorageService.GetItemAsync<IEnumerable<ProdutoDtos>>(_key)
                ?? await AddCollectionItem();
        }


        public async Task RemoveCollectionItem()
        {
           
            await this._localStorageService.RemoveItemAsync(_key);
        }

        public async Task <IEnumerable<ProdutoDtos>> AddCollectionItem()
        {
            var produtoCollection = await this._produtoServices.GetItens();
            if (produtoCollection != null)
            {
                await this._localStorageService.SetItemAsync(_key, produtoCollection);
            }
            return produtoCollection;
        }
    }
}

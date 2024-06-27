using BlazingPizza.Repositories.Interface;
using BlazingPizza.Repositories.Services;

namespace BlazingPizza.Dependencias
{
    public static class ConfigServiceCollectionsExtensios
    {
        public static IServiceCollection AddConfigWeb(
           this IServiceCollection Services, IConfiguration Config)
        {
            Services.AddScoped<InjectServicesWeb>();
            Services.AddScoped<IProdutoServices, ProdutoServices>();

            var baseUrl = "http://localhost:5206";

            Services.AddScoped(HttpClient => new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            });

            return Services;
        }
    }
}

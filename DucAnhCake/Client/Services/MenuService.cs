using DucAnhCake.Shared;
using System.Net.Http.Json;


namespace DucAnhCake.Client.Services
{
    public class MenuService : IMenuService
    {
        private readonly HttpClient httpClient;
        public MenuService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async ValueTask<Menu> GetMenu()
        {
            var cakes = await httpClient
                .GetFromJsonAsync<Cake[]>("/cakes");
            return new Menu { Cakes = cakes!.ToList() };
        }
    }
}

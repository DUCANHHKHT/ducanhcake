using Microsoft.AspNetCore.Components;
using DucAnhCake.Shared;

namespace DucAnhCake.Client.Pages
{
    partial class ShoppingBasket
    {
        [Parameter]
        public IEnumerable<int> Orders { get; set; } = default!;
        [Parameter]
        public EventCallback<int> Selected { get; set; } = default!;
        [Parameter]
        public Func<int, Cake> GetCakeFromId { get; set; }
        = default!;
        private IEnumerable<(Cake cake, int pos)> Cakes { get; set; } = default!;
        private decimal TotalPrice { get; set; } = default!;
        protected override void OnParametersSet()
        {
            Cakes = Orders.Select((id, pos)
            => (cake: GetCakeFromId(id), pos: pos));
            TotalPrice = Cakes.Select(tuple
            => tuple.cake.Price).Sum();
        }
    }
}

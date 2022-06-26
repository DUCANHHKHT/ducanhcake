using Microsoft.AspNetCore.Components;
using DucAnhCake.Shared;

namespace DucAnhCake.Client.Pages
{
    partial class CakeItem
    {
        [Parameter]
        public Cake Cake { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public EventCallback<Cake> Selected { get; set; }
        private string SugarImage(Sugar sugar)
        => $"images/{sugar.ToString().ToLower()}.png";
    }
}

using Microsoft.AspNetCore.Components;
using DucAnhCake.Shared;

namespace DucAnhCake.Client.Pages
{
    partial class CakeList
    {
        [Parameter]
        public string Title { get; set; } = default!;
        [Parameter]
        public IEnumerable<Cake> Items { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public EventCallback<Cake> Selected { get; set; }
    }
}

using DucAnhCake.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using DucAnhCake.Client.Services;
using DucAnhCake.Shared;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjUxMDQ0QDMyMzAyZTMxMmUzME5UQU9qNXVocmp3b2wyL2pCb0k5MWF4WSs5UjU5d243aHMvRnZ3dHE4bEk9");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
builder.Services
    .AddTransient<IMenuService, MenuService>();
builder.Services
    .AddTransient<IOrderService, OrderService>();

await builder.Build().RunAsync();

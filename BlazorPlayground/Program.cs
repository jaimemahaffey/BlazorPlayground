using BlazorPlayground;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazorise.Material;
using Blazorise.Icons.Material;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

AddBlazorise(builder.Services, builder.Configuration);

await builder.Build().RunAsync();


void AddBlazorise(IServiceCollection services, IConfiguration configuration)
{
    services
        .AddBlazorise();
    services
        .AddSingleton(configuration)
        .AddMaterialProviders()
        .AddMaterialIcons();
}
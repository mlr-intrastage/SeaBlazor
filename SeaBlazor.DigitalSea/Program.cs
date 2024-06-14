using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MysticIsland;
using SeaBlazor.Archipelago.WebServices;
using SeaBlazor.CoralReef;
using SeaBlazor.DigitalSea;
using ThunderIsland;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//Register services from Archipelago core services module
builder.Services.AddHttpClient<UserSecurityService>(client => client.BaseAddress = new Uri("http://some-made-up-api-address.net"));

// Register JsInterop service from CoralReef module
builder.Services.AddScoped<CoralReefJsInterop>();

// Register JsInterop services from Island modules
builder.Services.AddScoped<ThunderIslandJsInterop>();
builder.Services.AddScoped<MysticIslandJsInterop>();

await builder.Build().RunAsync();

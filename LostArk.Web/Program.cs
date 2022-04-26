using LostArk.Web;
using LostArk.Web.Services;
using LostArk.Web.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7134") });
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ICharacterTaskService, CharacterTaskService>();

await builder.Build().RunAsync();

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.SessionStorage;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();

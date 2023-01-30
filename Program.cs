using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Fluxor;
using FluxorSample;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


builder.Services.AddFluxor(o =>
{
    o.UseRouting();
    o.ScanAssemblies(typeof(Program).Assembly);
    #if DEBUG
        o.UseReduxDevTools(rdt =>
        {
            rdt.Name = "FluxorSample";
            rdt.EnableStackTrace();
        });
    #endif
});


await builder.Build().RunAsync();

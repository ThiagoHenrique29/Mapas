using Mapas;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<IProvedorMapa, MapsHere>();

using var host = builder.Build();

host.Run();
return;

void MinhaAplicacao(IServiceProvider servicos)
{
    var provedorMapas = servicos.GetRequiredService(typeof(IProvedorMapa)) as IProvedorMapa;
    Console.WriteLine(provedorMapas.NomeProvedor);
    Console.WriteLine(provedorMapas.Rota(origem:"IFSP", destino:"Casa"));
}
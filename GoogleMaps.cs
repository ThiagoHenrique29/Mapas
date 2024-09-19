namespace Mapas;

public class GoogleMaps : IProvedorMapa
{
    public string NomeProvedor { get; } = "Google Maps";

    public string Mapa(string coordenada)
    {
        return $"Este é um mapa do Google Maps para" + $"as coordenadas: {coordenada}";
    }

    public string Rota(string origem, string destino)
    {
        return $"Está a rota: {origem} e {destino}"+$"usando Google Maps";
    }
}
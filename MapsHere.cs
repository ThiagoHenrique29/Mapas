namespace Mapas;

public class MapsHere : IProvedorMapa
{
    
    public string NomeProvedor { get; } = "MapsHere";

    public string Mapa(string coordenada)
    {
        return $"Este é um mapa do MapsHere para" + $"as coordenadas: {coordenada}";
    }

    public string Rota(string origem, string destino)
    {
        return $"Está a rota: {origem} e {destino}"+$"usando MapsHere";
    }
}
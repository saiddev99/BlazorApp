namespace Blazor.Client.Models;

public class Boek
{
    public string ImgName { get; set; }
    public string Auteur { get; set; }
    public string Titel { get; set; }
    public string Taal { get; set; }
    public string Afwerking { get; set; }
    public string ISBN { get; set; }
    public DateOnly UitgifteDatum { get; set; }
    public ushort AantalPaginas { get; set; }
    public string Beschrijving { get; set; }


}

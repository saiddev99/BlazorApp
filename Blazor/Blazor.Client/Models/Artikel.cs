namespace Blazor.Client.Models;

public class Artikel
{
    public int Id { get; set; }
    public required string Naam { get; set; }
    public required string Omschrijving { get; set; }
    public decimal Prijs { get; set; }

}

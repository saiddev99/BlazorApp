namespace Blazor.Client.Models;

public class Persoon
{
    public int Id { get; set; }
    public string Voornaam { get; set; }
    public string Familienaam { get; set; }

    public override string ToString()
    {
        return $"{Id}. {Voornaam} {Familienaam}";
    }
}

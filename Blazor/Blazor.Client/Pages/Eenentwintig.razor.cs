using Blazor.Client.Components;

namespace Blazor.Client.Pages;

public partial class Eenentwintig
{
    private int currentScore = 0;
    private List<string> kaarten = new List<string>();
    private static readonly string[] Soorten = { "H", "D", "C", "S" };
    private static readonly string[] Beelden = { "7", "8", "9", "10",
 "J", "Q", "K", "A" };
    private static readonly byte[] Waarden = { 7, 8, 9, 10, 1, 2, 3, 11 };
    private string GetRandomCard()
    {
        Random random = new Random();
        var soort = Soorten[random.Next(0, 4)];
        var kaart = random.Next(0, 8);
        var beeld = Beelden[kaart];
        var waarde = Waarden[kaart];
        currentScore += waarde;
        return $"{beeld}{soort}";
    }
    private void TrekKaart()
    {
        kaarten.Add(GetRandomCard());

        if (currentScore > 21)
        {
            throw new InvalidOperationException("Je bent verbrand!");
        }
    }

    private Dictionary<string, object> footerAttributes =

     new Dictionary<string, object>()
     {
         {
         "auteur", "Steven"
         },
         {
         "cursus", "Blazor"
         },
         {
         "jaartal", 2020
         },
         {
         "doelgroep", ".NET ontwikkeling met C#"
         },
     };

    private bool veranderd = false;
    private string oldAuteur = "";

    private void Verander()
    {
        if (!veranderd)
        {
            oldAuteur = (string)footerAttributes["auteur"];
            footerAttributes["auteur"] = "Jantje";
            veranderd = true;
        }
        else
        {
            footerAttributes["auteur"] = oldAuteur;
            veranderd = false;
        }
    }

    private CopyrightFooter? cfdynamic;

    private string? cursus;
    private string? info;
    private void InfoOphalen()
    {
        cursus = cfdynamic?.Cursus;
        info = cfdynamic?.AlleInfo();
    }
}

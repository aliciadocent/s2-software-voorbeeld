namespace InstrumentenBeheerLogic;

public class Gebruiker
{
    public string Voornaam { get; }
    public string Achternaam { get; }
    public string Wachtwoord { get; }
    public string Emailadres { get; }
    public bool Instrumentenbeheerder { get; }

    public Gebruiker(string voornaam, string achternaam, string wachtwoord, string emailadres,
        bool instrumentenbeheerder)
    {
        this.Voornaam = voornaam;
        this.Achternaam = achternaam;
        this.Wachtwoord = wachtwoord;
        this.Emailadres = emailadres;
        this.Instrumentenbeheerder = instrumentenbeheerder;
    }
}
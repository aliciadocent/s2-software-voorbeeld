namespace InstrumentenBeheerLogic;

public class Instrument
{
    public string Serienummer { get; }
    public string Merk { get; }
    public Type Type { get; }
    public Status Status { get; }

    public Instrument(string serienummer, string merk, Type type, Status status)
    {
        this.Serienummer = serienummer;
        this.Merk = merk;
        this.Type = type;
        this.Status = status;
    }
}
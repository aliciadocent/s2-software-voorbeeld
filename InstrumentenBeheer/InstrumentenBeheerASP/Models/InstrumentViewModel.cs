using InstrumentenBeheerLogic;
using Type = InstrumentenBeheerLogic.Type;


namespace InstrumentenBeheer.Models;

public class InstrumentViewModel
{
    public string Serienummer { get; set; }
    public string Merk { get; set; }
    public Type Type { get; set; }
    public Status Status { get; set; }
    
    public InstrumentViewModel()
    {
        
    }

    public InstrumentViewModel(Instrument instrument)
    {
        this.Serienummer = instrument.Serienummer;
        this.Merk = instrument.Merk;
        this.Type = instrument.Type;
        this.Status = instrument.Status;
    }
}
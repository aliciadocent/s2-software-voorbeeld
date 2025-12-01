using InstrumentenBeheerInterface.DTO;
using InstrumentenBeheerInterface.Interface;

namespace InstrumentenBeheerLogic;

public class InstrumentContainer
{
    private IInstrumentContainer iInstrumentContainer;

    public InstrumentContainer(IInstrumentContainer iInstrumentContainer)
    {
        this.iInstrumentContainer = iInstrumentContainer;
    }
    
    public List<Instrument> GetAllInstruments(int? type = null, int? status = null)
    {
        List<InstrumentDTO> instrumentDtos = iInstrumentContainer.GetAllInstruments(type, status);

        List<Instrument> instruments = new List<Instrument>();
        foreach (InstrumentDTO instrumentDto in instrumentDtos)
        {
            instruments.Add(this.instrumentDtoToInstrument(instrumentDto));
        }

        return instruments;
    }
    
    private Instrument instrumentDtoToInstrument(InstrumentDTO instrumentDto)
    {
        return new Instrument(instrumentDto.Serienummer, instrumentDto.Merk, (Type)instrumentDto.Type, (Status)instrumentDto.Status);
    }

}
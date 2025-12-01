using InstrumentenBeheerInterface.DTO;

namespace InstrumentenBeheerInterface.Interface;

public interface IInstrumentContainer
{
    public List<InstrumentDTO> GetAllInstruments(int? status = null, int? type = null);
}
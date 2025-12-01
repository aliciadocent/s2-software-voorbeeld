using InstrumentenBeheerInterface.DTO;
using InstrumentenBeheerInterface.Interface;

namespace InstrumentenBeheerDAL.Stub;

public class InstrumentDALStub : IInstrumentContainer
{
    public List<InstrumentDTO> GetAllInstruments(int? type = null, int? status = null)
    {
        List<InstrumentDTO> instrumentsDTO = new List<InstrumentDTO>();
        instrumentsDTO.Add(new InstrumentDTO()
        {
            Serienummer = "sdfs", 
            Merk = "3434blabla", 
            Type = 1,
            Status = 3
        });
        
        instrumentsDTO.Add(new InstrumentDTO()
        {
            Serienummer = "dsf", 
            Merk = "343blabla", 
            Type = 2,
            Status = 1
        });
        
        instrumentsDTO.Add(new InstrumentDTO()
        {
            Serienummer = "sdfsdsfgjdkl", 
            Merk = "bl32abla", 
            Type = 3,
            Status = 2
        });

        return instrumentsDTO;
    }
}
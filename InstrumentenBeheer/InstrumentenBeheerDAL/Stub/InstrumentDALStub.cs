using InstrumentenBeheerInterface.DTO;
using InstrumentenBeheerInterface.Interface;

namespace InstrumentenBeheerDAL.Stub;

public class InstrumentDALStub : IInstrumentContainer
{
    public List<InstrumentDTO> instrumentsDTO = new List<InstrumentDTO>(){
        new InstrumentDTO()
        {
            Serienummer = "sdfs", 
            Merk = "3434blabla", 
            Type = 1,
            Status = 3
        },
        new InstrumentDTO()
        {
            Serienummer = "dsf", 
            Merk = "343blabla", 
            Type = 2,
            Status = 1
        },
        new InstrumentDTO()
        {
            Serienummer = "sdfsdsfgjdkl", 
            Merk = "bl32abla", 
            Type = 3,
            Status = 2
        }
    };

    public List<InstrumentDTO> GetAllInstruments(int? type = null, int? status = null)
    {
        return instrumentsDTO;
    }
}
using InstrumentenBeheerDAL.Stub;
using InstrumentenBeheerLogic;
using Type = InstrumentenBeheerLogic.Type;

namespace InstrumentenBeheerTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetAllInstruments()
    {
        //arrange
        InstrumentDALStub instrumentDalStub = new InstrumentDALStub();
        InstrumentContainer instrumentContainer = new InstrumentContainer(instrumentDalStub);
        
        //act
        List<Instrument> instruments = instrumentContainer.GetAllInstruments();
        
        //assert
        Assert.AreEqual(instrumentDalStub.instrumentsDTO.Count, instruments.Count);
        for (int i = 0; i < instruments.Count; i++)
        {
            Assert.AreEqual(instrumentDalStub.instrumentsDTO[i].Serienummer, instruments[i].Serienummer);
            Assert.AreEqual(instrumentDalStub.instrumentsDTO[i].Merk, instruments[i].Merk);
            Assert.AreEqual((Type)instrumentDalStub.instrumentsDTO[i].Type, instruments[i].Type);
            Assert.AreEqual((Status)instrumentDalStub.instrumentsDTO[i].Status, instruments[i].Status);
        }
    }
}
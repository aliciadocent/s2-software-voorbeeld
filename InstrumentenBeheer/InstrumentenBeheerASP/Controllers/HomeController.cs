using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InstrumentenBeheer.Models;
using InstrumentenBeheerDAL.Stub;
using InstrumentenBeheerLogic;

namespace InstrumentenBeheer.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        InstrumentsViewModel instrumentsViewModel = new InstrumentsViewModel();
        instrumentsViewModel.Instruments = new List<InstrumentViewModel>();

        InstrumentContainer instrumentContainer = new InstrumentContainer(new InstrumentDALStub());
        List<Instrument> instruments = instrumentContainer.GetAllInstruments();

        foreach (Instrument instrument in instruments)
        {
            instrumentsViewModel.Instruments.Add(new InstrumentViewModel(instrument));
        }
            
        return View(instrumentsViewModel);

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
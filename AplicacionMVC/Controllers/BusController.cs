using AplicacionMVC.Models;
using AplicacionMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionMVC.Controllers
{
    public class BusController : Controller
    {
        private readonly BusServices busServices;

        public BusController(BusServices busServices)
        {
            this.busServices = busServices;
        }

        [HttpGet]

        public async Task<IActionResult> Index()
        {
            var estaciones = await busServices.GetAllBuses();
            return View(estaciones);
        }

        [HttpPost]

        public async Task<IActionResult> Crear(string nombreRuta, string placa, string marca, string modelo, Guid estacionId)
        {
            var bus = Bus.Build(Guid.NewGuid(), nombreRuta, placa, marca, modelo, estacionId);
            await this.busServices.Crear(bus);

            return View();
        }

        [HttpGet]

        public IActionResult Crear()
        {
            return View();
        }
    }
}

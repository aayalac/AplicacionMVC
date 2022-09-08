using AplicacionMVC.Models;
using AplicacionMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionMVC.Controllers
{
    public class EstacionController : Controller
    {
        private readonly EstacionServices estacionServices;

        public EstacionController(EstacionServices estacionServices)
        {
            this.estacionServices = estacionServices;
        }

        [HttpGet]

        public async Task<IActionResult> Index()
        {
            var estaciones = await estacionServices.GetAllEstaciones();
            return View(estaciones);
        }

        [HttpPost]

        public async Task<IActionResult> Crear(string nombre, string troncal, string direccion, int numeroVagones)
        {
            var estacion = Estacion.Build(Guid.NewGuid(), nombre, direccion, troncal, numeroVagones);
            await this.estacionServices.Crear(estacion);

            return View();
        }

        [HttpGet]

        public IActionResult Crear()
        {
            return View();
        }
    }
}

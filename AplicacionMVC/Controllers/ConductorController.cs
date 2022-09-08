using AplicacionMVC.Models;
using AplicacionMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionMVC.Controllers
{
    public class ConductorController : Controller
    {
        private readonly ConductorServices conductorServices;

        public ConductorController(ConductorServices conductorServices)
        {
            this.conductorServices = conductorServices;
        }

        [HttpGet]

        public async Task<IActionResult> Index()
        {
            var conductores = await conductorServices.GetAllConductores();
            return View(conductores);
        }

        [HttpPost]

        public async Task<IActionResult> Crear(string nombre, string apellido, int identificacion, string ruta, Guid busId)
        {
            var conductor = Conductor.Build(Guid.NewGuid(), nombre, apellido, identificacion, ruta, busId);
            await this.conductorServices.Crear(conductor);

            return View();
        }

        [HttpGet]

        public IActionResult Crear()
        {
            return View();
        }
    }
}

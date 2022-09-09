using AplicacionMVC.Models;
using AplicacionMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
            var estacion = Estacion.Build(Guid.NewGuid(), nombre, troncal, direccion, numeroVagones);
            await this.estacionServices.Crear(estacion);
            return RedirectToAction(nameof(Index));

            return View();
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Update(Guid id, string nombre, string troncal, string direccion, int numeroVagones)
        {
            if (ModelState.IsValid)
            {
                var estacion = Estacion.Build(id, nombre, troncal, direccion, numeroVagones);
                await this.estacionServices.Editar(estacion);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var estacion = await estacionServices.GetById(id);
            return View(estacion);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var consulta = await estacionServices.GetById(id);            
            await this.estacionServices.Delete(consulta);
            return Content("1");
        }

    }
}
using AplicacionMVC.Data;
using AplicacionMVC.Models;

namespace AplicacionMVC.Services
{
    public class BusServices
    {
        private readonly IRepository repository;

        public BusServices(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Crear(Bus bus)
        {
            if (bus is null)
                throw new Exception("El bus tiene valores null");

            await this.repository.Save(bus);
            await this.repository.Commit();
        }

        public async Task Editar(Bus bus)
        {
            if (bus is null)
                throw new Exception("El bus no tiene que tener valores null");

            this.repository.Update(bus);
            await this.repository.Commit();
        }

        public async Task Borrar(Bus bus)
        {
            this.repository.Delete(bus);
            await this.repository.Commit();
        }

        public async Task<List<Bus>> GetAllBuses()
        {
            return await this.repository.GetAll<Bus>();
        }
    }
}

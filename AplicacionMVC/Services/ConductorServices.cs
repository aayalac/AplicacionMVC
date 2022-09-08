using AplicacionMVC.Data;
using AplicacionMVC.Models;

namespace AplicacionMVC.Services
{
    public class ConductorServices
    {
        private readonly IRepository repository;

        public ConductorServices(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Crear(Conductor conductor)
        {
            if (conductor is null)
                throw new Exception("El conductor tiene valor null");

            await this.repository.Save(conductor);
            await this.repository.Commit();
        }

        public async Task Editar(Conductor conductor)
        {
            if (conductor is null)
                throw new Exception("El conductor tiene valor null");

            this.repository.Update(conductor);
            await this.repository.Commit();
        }

        public async Task Borrar(Conductor conductor)
        {
            this.repository.Delete(conductor);
            await this.repository.Commit();
        }

        public async Task<List<Conductor>> GetAllConductores()
        {
            return await this.repository.GetAll<Conductor>();
        }
    }
}
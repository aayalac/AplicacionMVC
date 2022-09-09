using AplicacionMVC.Data;
using AplicacionMVC.Models;

namespace AplicacionMVC.Services
{
    public class EstacionServices
    {
        private readonly IRepository repository;

        public EstacionServices(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Crear(Estacion estacion)
        {
            if (estacion is null)
                throw new Exception("El valor de estacion es null");

            await this.repository.Save(estacion);
            await this.repository.Commit();
        }

        public async Task Editar(Estacion estacion)
        {
            if (estacion is null)
                throw new Exception("El valor de estacion es null");

            this.repository.Update(estacion);
            await this.repository.Commit();
        }
        public async Task Delete(Estacion estacion)
        {    
            this.repository.Delete(estacion);
            await this.repository.Commit();
        }

        public async Task<List<Estacion>> GetAllEstaciones()
        {
            return await this.repository.GetAll<Estacion>();
        }
        public async Task<Estacion> GetById(Guid id)
        {
            return await this.repository.GetById<Estacion>(id);
        }        
    }
}

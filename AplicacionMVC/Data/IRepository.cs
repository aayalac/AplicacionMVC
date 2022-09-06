using AplicacionMVC.Models;
namespace AplicacionMVC.Data
{
    public interface IRepository
    {
        public Task Save<T>(T obj) where T : Entity; // salvar (Asincrono)

        public Task Commit(); // sentencia de guardado

        public void Delete<T>(T obj) where T : Entity; // borrar

        public void Update<T>(T obj) where T : Entity; // actualizar

        public Task<List<T>> GetAll<T>() where T : Entity; // editar (Asincrono)
    }
}
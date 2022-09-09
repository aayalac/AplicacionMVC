using AplicacionMVC.Models;
namespace AplicacionMVC.Data
{
    public interface IRepository
    {
        public Task Save<T>(T obj) where T : Entity;         

        public void Delete<T>(T obj) where T : Entity; 

        public void Update<T>(T obj) where T : Entity; 

        public Task<List<T>> GetAll<T>() where T : Entity;

        public Task<T> GetById<T>(Guid id) where T : Entity;

        public Task Commit();
    }
}
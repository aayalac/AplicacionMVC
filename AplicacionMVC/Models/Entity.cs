namespace AplicacionMVC.Models
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }

        protected Entity()
        {
        }

        public Entity(Guid id)
        {
            Id = id;
        }
    }
}

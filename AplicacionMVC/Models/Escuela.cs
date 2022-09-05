namespace AplicacionMVC.Models
{
    public class Escuela : Entity
    {
        public string Name { get; private set; }

        public string Direccion { get; private set; }

        public string Tipo { get; private set; }

        public List<Estudiante> Estudaintes { get; private set; } 

        private Escuela(Guid id, string name, string direccion, string tipo) : base()
        {
            Name = Name;
            Direccion = Direccion;
            Tipo = Tipo;
        }

        public Escuela Build(Guid id, string name, string direccion, string tipo)
        {
            return new Escuela(id, name, direccion, tipo);
        }
    }
}
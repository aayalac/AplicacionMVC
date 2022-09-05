namespace AplicacionMVC.Models
{
    public class Estacion : Entity
    {
        // atributos
        public string Nombre { get; private set; }

        public string Troncal { get; private set; }

        public string Direccion { get; private set; }

        public int NumeroVagones { get; private set; }

        // lista buses
        public List<Bus> Buses { get; private set; } 

        private Estacion(Guid id, string nombre, string troncal, string direccion, int numeroVagones) : base()
        {
            Nombre = nombre;
            Troncal = troncal;
            Direccion = direccion;
            NumeroVagones = numeroVagones;
        }

        public Estacion Build(Guid id, string nombre, string troncal, string direccion, int numeroVagones)
        {
            return new Estacion(id,nombre,troncal,direccion,numeroVagones);
        }
    }
}
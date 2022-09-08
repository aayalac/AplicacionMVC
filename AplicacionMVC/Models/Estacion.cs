namespace AplicacionMVC.Models
{
    public class Estacion : Entity
    {
        // atributos
        public string Nombre { get; private set; }

        public string Troncal { get; private set; }

        public string Direccion { get; private set; }

        public int NumeroVagones { get; private set; }

        public List<Bus> Buses { get; private set; } // lista buses

        private Estacion(Guid id, string nombre, string troncal, string direccion, int numeroVagones) : base(id)
        {
            Nombre = nombre;
            Troncal = troncal;
            Direccion = direccion;
            NumeroVagones = numeroVagones;
        }

        public static Estacion Build(Guid id, string nombre, string troncal, string direccion, int numeroVagones)
        {
            return new Estacion(id, nombre, troncal, direccion, numeroVagones);
        }
    }
}
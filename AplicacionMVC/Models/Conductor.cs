namespace AplicacionMVC.Models
{
    public class Conductor
    {
        public string Nombre { get; private set; }

        public string Apellido { get; private set; }

        public int Identificacion { get; private set; }

        public string Ruta { get; private set; }

        public Bus Bus { get; private set; }

        public Guid BusId { get; private set; } // foreing key

        public Conductor(Guid id, string nombre, string apellido, int identificacion, string ruta, Guid busId)
        {
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
            Ruta = ruta;
            BusId = busId;
        }

        public Conductor Build(Guid id, string nombre, string apellido, int identificacion, string ruta, Guid busId)
        {
            return new Conductor(id, nombre, apellido, identificacion, ruta, busId);
        }
    }
}

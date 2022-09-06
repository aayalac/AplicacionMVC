namespace AplicacionMVC.Models
{
    public class Bus
    {
        public string NombreRuta { get;  private set; }

        public string Placa { get; private set; }

        public string Marca { get; private set; }

        public string Modelo { get; private set; }

        public Guid EstacionId { get; private set; } // foreing key

        public List<Conductor> Conductores { get; private set; } // listado de Conductores

        public Estacion Estacion { get; private set; }

        private Bus(Guid id, string nombreRuta, string placa, string marca, string modelo, Guid estacionId)
        {
            NombreRuta = nombreRuta;
            Placa = placa;
            Marca = marca;
            EstacionId = estacionId;
            Modelo = modelo;
        }

        public Bus Build(Guid id, string nombreRuta, string placa, string marca, string modelo, Guid estacionId)
        {
            return new Bus(id,nombreRuta,placa,marca,modelo,estacionId);
        }
    }
}
namespace AplicacionMVC.Models
{
    public class Estudiante
    {
        public string Name { get;  private set; }

        public string DocumentoIdentidad { get; private set; }

        public DateTime FechaDeNacimiento { get; private set; }

        public Guid EscuelaId { get; private set; } // foreing key

        public Escuela Escuela { get; private set; }

        private Estudiante(Guid id,string name, string documentoIdentidad, DateTime fechaDeNacimiento, Guid escuelaId)
        {
            Name = name;
            DocumentoIdentidad = documentoIdentidad;
            FechaDeNacimiento = fechaDeNacimiento;
            EscuelaId = escuelaId;
        }

        public Estudiante Build(Guid id, string name, string documentoIdentidad, DateTime fechaDeNacimiento, Guid escuelaId)
        {
            return new Estudiante(id,name,documentoIdentidad,fechaDeNacimiento,escuelaId);
        }
    }
}
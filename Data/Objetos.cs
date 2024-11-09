public class Detencion
{
    public int Id { get; set; }
    public DateTime FechaDetencion { get; set; } = DateTime.Now;
    public string Nombre { get; set; } = "";
    public string Apellido { get; set; } = "";
    public string Pasaporte { get; set; } = "";
    public DateTime? FechaNacimiento { get; set; }
    public double Latitud { get; set; } = 0;
    public double Longitud { get; set; } = 0;
}
namespace DirectorioMAUI.Models;

public class Empleado
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Puesto { get; set; }
    public string ImagenUri { get; set; }
    public int DepartamentoId { get; set; }

    public string ImagenCompleta
    {
        get
        {
            if (string.IsNullOrEmpty(ImagenUri))
                return null;

            string rutaSinBarra = ImagenUri.TrimStart('/');
            string rutaEscapada = Uri.EscapeDataString(rutaSinBarra).Replace("%2F", "/");

            return $"http://localhost:8000/{rutaEscapada}";
        }
    }
}

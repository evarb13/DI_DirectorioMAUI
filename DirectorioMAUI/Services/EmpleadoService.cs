using DirectorioMAUI.Models;
using MauiEmpresaApi.Services;
using System.Net.Http.Json;
using System.Text.Json;

namespace DirectorioMAUI.Services;

public class EmpleadoService : IRestService<Empleado>
{
    HttpClient _client = new HttpClient();
    JsonSerializerOptions _serializerOptions = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower };

    Uri baseUri = new Uri(string.Format("http://localhost:8000/"));
    public async Task<List<Empleado>> GetAllAsync()
    {
        return (await _client.GetFromJsonAsync<List<Empleado>>($"{baseUri}empleados", _serializerOptions));
    }

    public Empleado Get(int id)
    {
        return _client.GetFromJsonAsync<Empleado>(baseUri + $"/empleados/{id}").Result;
    }
}

using DirectorioMAUI.Models;
using MauiEmpresaApi.Services;
using System.Net.Http.Json;
using System.Text.Json;

namespace DirectorioMAUI.Services;

public class DepartamentoService : IRestService<Departamento>
{
    HttpClient _client = new HttpClient();
    JsonSerializerOptions _serializerOptions = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower };

    Uri baseUri = new Uri(string.Format("http://localhost:8000/"));
    public async Task<List<Departamento>> GetAllAsync()
    {
        return (await _client.GetFromJsonAsync<List<Departamento>>($"{baseUri}departamentos", _serializerOptions));
    }

    public Departamento Get(int id)
    {
        return _client.GetFromJsonAsync<Departamento>(baseUri + $"/departamentos/{id}").Result;
    }
}

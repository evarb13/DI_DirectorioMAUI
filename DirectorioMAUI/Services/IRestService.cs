namespace MauiEmpresaApi.Services;

interface IRestService<T>
{
    public Task<List<T>> GetAllAsync();
}

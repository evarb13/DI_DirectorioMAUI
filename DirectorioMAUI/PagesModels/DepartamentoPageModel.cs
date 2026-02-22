using CommunityToolkit.Mvvm.ComponentModel;
using DirectorioMAUI.Models;
using DirectorioMAUI.Services;

namespace DirectorioMAUI.PagesModels;

public partial class DepartamentoPageModel : ObservableObject
{
    [ObservableProperty]
    private List<Departamento> _departamentos;

    [ObservableProperty]
    private string _departments = Properties.Resources.Departamentos;

    public DepartamentoPageModel(DepartamentoService departamentoService)
    {
        InitializeDataAsync(departamentoService);
    }

    private async void InitializeDataAsync(DepartamentoService departamentoService)
    {
        Departamentos = await departamentoService.GetAllAsync();
    }
}

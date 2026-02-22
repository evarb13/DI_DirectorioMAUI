using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DirectorioMAUI.Models;
using DirectorioMAUI.Services;

namespace DirectorioMAUI.PagesModels;

public partial class EmpleadoPageModel : ObservableObject
{

    [ObservableProperty]
    private List<Empleado> _empleados;

    [ObservableProperty]
    private string _employees = Properties.Resources.Empleados;

    public EmpleadoPageModel(EmpleadoService empleadoService)
    {
        InitializeDataAsync(empleadoService);
    }

    private async void InitializeDataAsync(EmpleadoService empleadoService)
    {
        Empleados = await empleadoService.GetAllAsync();
    }

    [RelayCommand]
    private async Task VerDetalles(Empleado empleado) // Recibe el empleado seleccionado
    {
        if (empleado == null) return;

        var parametros = new Dictionary<string, object>
    {
        { "Data", empleado } // Enviamos el empleado bajo la llave "Data"
    };

        await Shell.Current.GoToAsync("details", parametros);
    }
}

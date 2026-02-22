using DirectorioMAUI.Models;
using DirectorioMAUI.PagesModels;

namespace DirectorioMAUI.Pages;

public partial class EmpleadoPage : ContentPage
{
	public EmpleadoPage(EmpleadoPageModel empleadoPageModel)
	{
        BindingContext = empleadoPageModel;
        InitializeComponent();
	}

    private async void OnEmpleadoSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Empleado empleado)
        {
            await Navigation.PushAsync(new DetailPage(empleado));
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}
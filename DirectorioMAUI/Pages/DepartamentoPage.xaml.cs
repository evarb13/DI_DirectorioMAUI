using DirectorioMAUI.Models;
using DirectorioMAUI.PagesModels;

namespace DirectorioMAUI.Pages;

public partial class DepartamentoPage : ContentPage
{
    public DepartamentoPage(DepartamentoPageModel departamentoPageModel)
	{
        BindingContext = departamentoPageModel;
        InitializeComponent();
	}
    private async void OnDepartamentoSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Departamento departamento)
        {
            await Navigation.PushAsync(new DetailPage(departamento));
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}
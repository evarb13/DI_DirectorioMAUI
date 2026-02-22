using DirectorioMAUI.Models;

namespace DirectorioMAUI.Pages;

public partial class DetailPage : ContentPage
{
    public DetailPage(object item)
    {
        InitializeComponent();
        BindingContext = item;

        if (item is Departamento)
        {
            FramePuesto.IsVisible = false;
            FrameDepartamento.IsVisible = false;
            FrameImagen.IsVisible = false;
        }
    }
}
using DirectorioMAUI.PagesModels;

namespace DirectorioMAUI.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageModel mainPageModel)
    {
        BindingContext = mainPageModel;
        InitializeComponent();
    }
}

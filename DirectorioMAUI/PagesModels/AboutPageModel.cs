using CommunityToolkit.Mvvm.ComponentModel;

namespace DirectorioMAUI.PagesModels;

public partial class AboutPageModel : ObservableObject
{
    [ObservableProperty]
    private string _title = Properties.Resources.MAUI;

    [ObservableProperty]
    private string _texto = Properties.Resources.Texto;

    [ObservableProperty]
    private string _develop = Properties.Resources.Desarrollado;

    [ObservableProperty]
    private string _version = Properties.Resources.Version;
}

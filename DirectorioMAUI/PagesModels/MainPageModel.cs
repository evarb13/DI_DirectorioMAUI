using CommunityToolkit.Mvvm.ComponentModel;

namespace DirectorioMAUI.PagesModels;

public partial class MainPageModel : ObservableObject
{
    [ObservableProperty]
    private string _title = Properties.Resources.Menu;
}

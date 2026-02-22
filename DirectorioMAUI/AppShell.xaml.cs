using DirectorioMAUI.Pages;

namespace DirectorioMAUI;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        InitializeRouting();
    }
    private static void InitializeRouting()
    {
        Routing.RegisterRoute("details", typeof(DetailPage));
    }
}

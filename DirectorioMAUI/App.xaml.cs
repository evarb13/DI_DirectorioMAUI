using System.Globalization;

namespace DirectorioMAUI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        var savedLanguage = Preferences.Get("Locale", "es");
        var culture = new CultureInfo(savedLanguage);
        CultureInfo.DefaultThreadCurrentCulture = culture;
        CultureInfo.DefaultThreadCurrentUICulture = culture;
        DirectorioMAUI.Properties.Resources.Culture = culture;

        MainPage = new AppShell();
    }
}
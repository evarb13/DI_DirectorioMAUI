using CommunityToolkit.Mvvm.ComponentModel;
using System.Globalization;
using System.Collections.ObjectModel;

namespace DirectorioMAUI.PagesModels;

public partial class SettingsPageModel : ObservableObject
{

    [ObservableProperty]
    private string _settings = Properties.Resources.Ajustes;

    [ObservableProperty]
    private string _language = Properties.Resources.Ajustes;
    public class Idioma
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
    }

    public ObservableCollection<Idioma> Idiomas { get; } = new()
    {
        new Idioma { Nombre = "Español", Codigo = "es" },
        new Idioma { Nombre = "English", Codigo = "en" }
    };

    [ObservableProperty]
    private Idioma _idiomaSeleccionado;

    public SettingsPageModel()
    {
        // Cargar idioma guardado
        var savedCode = Preferences.Get("Locale", "es");
        IdiomaSeleccionado = Idiomas.FirstOrDefault(x => x.Codigo == savedCode) ?? Idiomas[0];
    }

    partial void OnIdiomaSeleccionadoChanged(Idioma value)
    {
        if (value == null || string.IsNullOrEmpty(value.Codigo)) return;

        var cultura = new CultureInfo(value.Codigo);
        Thread.CurrentThread.CurrentCulture = cultura;
        Thread.CurrentThread.CurrentUICulture = cultura;

        CultureInfo.DefaultThreadCurrentCulture = cultura;
        CultureInfo.DefaultThreadCurrentUICulture = cultura;

        DirectorioMAUI.Properties.Resources.Culture = cultura;

        Preferences.Set("Locale", value.Codigo);

        Application.Current.MainPage.DisplayAlert(
            "Idioma cambiado",
            "Reinicia la aplicación para aplicar los cambios",
            "OK");
    }
}
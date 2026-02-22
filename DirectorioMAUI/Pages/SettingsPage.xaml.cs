using DirectorioMAUI.PagesModels;

namespace DirectorioMAUI.Pages;

public partial class SettingsPage : ContentPage
{
	public SettingsPage(SettingsPageModel settingsPageModel)
	{
		BindingContext = settingsPageModel;
        InitializeComponent();
	}
}
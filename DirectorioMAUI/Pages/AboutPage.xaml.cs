using DirectorioMAUI.PagesModels;

namespace DirectorioMAUI.Pages;

public partial class AboutPage : ContentPage
{
	public AboutPage(AboutPageModel aboutPageModel)
	{
		BindingContext = aboutPageModel;
        InitializeComponent();
	}
}
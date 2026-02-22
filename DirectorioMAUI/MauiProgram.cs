using DirectorioMAUI.Pages;
using DirectorioMAUI.PagesModels;
using DirectorioMAUI.Services;
using Microsoft.Extensions.Logging;

namespace DirectorioMAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<AboutPage>();
            builder.Services.AddTransient<AboutPageModel>();
            builder.Services.AddTransient<SettingsPage>();
            builder.Services.AddTransient<SettingsPageModel>();
            builder.Services.AddTransient<EmpleadoPage>();
            builder.Services.AddTransient<EmpleadoPageModel>();
            builder.Services.AddTransient<EmpleadoService>();
            builder.Services.AddTransient<DepartamentoPage>();
            builder.Services.AddTransient<DepartamentoPageModel>();
            builder.Services.AddTransient<DepartamentoService>();
            builder.Services.AddTransient<MainPageModel>();
            builder.Services.AddTransient<MainPage>();

            return builder.Build();
        }
    }
}

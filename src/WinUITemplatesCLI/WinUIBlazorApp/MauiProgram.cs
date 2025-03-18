using WinUIBlazorApp._1.Data;
using Microsoft.Extensions.Logging;
#if Net9OrLater
using Microsoft.Maui.Controls.Embedding;
#else
using Microsoft.Maui.Embedding;
#endif

namespace WinUIBlazorApp._1
{
    public static partial class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
#if Net9OrLater
            builder.UseMauiEmbeddedApp<MyApp>()
#else
            builder.UseMauiEmbedding<MyApp>()
#endif
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
                   });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSingleton(AppInfo.Current);
            builder.Services.AddSingleton<WeatherForecastService>();

//-:cnd:noEmit
#if DEBUG
            // Caution: Recommended to enable Developer Tools only for development!!!
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif
//+:cnd:noEmit

            return builder.Build();
        }
    }
}

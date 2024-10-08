﻿using WinUIBlazorApp._1.Data;
#if Net7OrLater
using Microsoft.Extensions.Logging;
#endif
#if Net9
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
#if Net9
            builder.UseMauiEmbeddedApp<App>()
#else
            builder.UseMauiEmbedding<App>()
#endif
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
                   });

            builder.Services.AddMauiBlazorWebView();
#if Net7OrLater
//-:cnd:noEmit
#if DEBUG
            // Caution: Recommended to enable Developer Tools only for development!!!
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif
//+:cnd:noEmit
#else
//-:cnd:noEmit
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif
//+:cnd:noEmit
#endif
            builder.Services.AddSingleton(AppInfo.Current);
            builder.Services.AddSingleton<WeatherForecastService>();

            return builder.Build();
        }
    }
}

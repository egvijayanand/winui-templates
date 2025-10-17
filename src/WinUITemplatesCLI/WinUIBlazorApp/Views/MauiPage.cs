using Microsoft.AspNetCore.Components.WebView.Maui;
//using VijayAnand.MauiBlazor.Markup;

namespace WinUIBlazorApp._1.Views
{
    public partial class MauiPage : ContentPage
    {
        public MauiPage()
        {
#if Mvvm
            BindingContext = new MauiViewModel();

#endif
            ControlTemplate = (ControlTemplate)Application.Current!.Resources[nameof(VersionTemplate)];

            // For a much simplified initialization
            // Add reference to the VijayAnand.MauiBlazor.Markup NuGet package
            // dotnet add package VijayAnand.MauiBlazor.Markup
            // Then uncomment the using statement at the top of this file and the line below
            //var bwv = new BlazorWebView().Configure(typeof(Main), "/counter");

            var bwv = new BlazorWebView()
            {
#if Mvvm
                HostPage = "wwwroot/index.html"
#else
                StartPath = "/counter",
                HostPage = "wwwroot/index.html"
#endif
            };

            bwv.RootComponents.Add(new RootComponent()
            {
                Selector = "#app",
                ComponentType = typeof(Main),
                Parameters = null
            });

#if Mvvm
#if Net9OrLater
            this.SetBinding(TitleProperty, static (MauiViewModel vm) => vm.Title);
            bwv.SetBinding(BlazorWebView.StartPathProperty, static (MauiViewModel vm) => vm.StartPath);

#else
            this.SetBinding(TitleProperty, nameof(MauiViewModel.Title));
            bwv.SetBinding(BlazorWebView.StartPathProperty, nameof(MauiViewModel.StartPath));

#endif
#endif
            Content = bwv;
        }
    }
}

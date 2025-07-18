using Microsoft.AspNetCore.Components.WebView.Maui;
using System.Reflection;
//using VijayAnand.MauiBlazor.Markup;
using Grid = Microsoft.Maui.Controls.Grid;

namespace WinUIBlazorApp._1.Views
{
    public partial class MauiPage : ContentPage
    {
        //private static readonly Color DotNetPurple = Color.Parse("#512BD4");

        public MauiPage()
        {
#if Mvvm
            BindingContext = new MauiViewModel();
#endif
            Resources["DotNetPurple"] = Color.Parse("#512BD4");
            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;

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

            // Uncomment the following line to use the much simplified initialization
            // Add reference to the VijayAnand.MauiBlazor.Markup NuGet package
            //var bwv = new BlazorWebView().Configure(typeof(Main), "/counter");
#if Mvvm
#if Net9OrLater
            this.SetBinding<MauiViewModel, string>(TitleProperty, static vm => vm.Title);
            bwv.SetBinding<MauiViewModel, string>(BlazorWebView.StartPathProperty, static vm => vm.StartPath);
#else
            this.SetBinding(TitleProperty, nameof(MauiViewModel.Title));
            bwv.SetBinding(BlazorWebView.StartPathProperty, nameof(MauiViewModel.StartPath));
#endif
#endif
            bwv.SetValue(Grid.RowProperty, 0);

            var footer = new Grid()
            {
                BackgroundColor = (Color)Resources["DotNetPurple"],
                Children =
                {
                    new Label()
                    {
                        Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}",
                        TextColor = Colors.White,
                        VerticalOptions = LayoutOptions.Center,
                        HorizontalOptions = LayoutOptions.Center
                    }
                }
            };

            footer.SetValue(Grid.RowProperty, 1);

            Content = new Grid()
            {
                RowDefinitions = [new(), new(40)],
                Children =
                {
                    bwv,
                    footer
                }
            };
        }
    }
}

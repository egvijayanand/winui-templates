using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Maui.Platform;

namespace WinUIBlazorApp._1.WinUI
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Content = new MainPage().ToPlatform(new MauiContext(MauiWinUIApplication.Current.Services));
        }
    }
}

using Microsoft.Maui.Platform;

namespace WinUIBlazorApp._1.Views
{
    /// <summary>
    /// A simple page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public partial class MainPage : HybridPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            // This step is essential to ensure access to global resources before initializing any MAUI controls.
            var mauiContext = MauiContext;
            // Platform-neutral - Windowless API
            Content = new MauiPage().ToPlatform(mauiContext);
            // Updated Window inclusive API
            //Content = new MauiPage().ToPlatformEmbedded(mauiContext);
        }
    }
}

using System.Reflection;

namespace WinUIBlazorApp._1.Views
{
    public partial class MauiPage : ContentPage
    {
        public MauiPage()
        {
            InitializeComponent();

            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
            lblVersion.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
        }
    }
}

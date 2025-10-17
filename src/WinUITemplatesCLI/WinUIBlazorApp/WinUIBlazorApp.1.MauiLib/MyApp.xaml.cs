using System.Reflection;

namespace WinUIBlazorApp._1
{
    public partial class MyApp : Application
    {
        public MyApp() => InitializeComponent();

        public static string MauiVersion
        {
            get
            {
                var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()!.InformationalVersion;
                return $".NET MAUI ver. {version[..version.IndexOf('+')]}";
            }
        }
    }
}

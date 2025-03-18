namespace WinUIBlazorApp._1.Views
{
    public partial class HybridPage : Microsoft.UI.Xaml.Controls.Page
    {
        private readonly Lazy<MauiContext> mauiContext = new(InitializeMauiContext);

        protected MauiContext MauiContext => mauiContext.Value;

        private static MauiContext InitializeMauiContext()
        {
            var mauiApp = MauiProgram.CreateMauiApp();
            return new MauiContext(mauiApp.Services);
        }
    }
}

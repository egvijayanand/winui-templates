namespace WinUIBlazorApp._1.Views
{
    public partial class HybridPage : Microsoft.UI.Xaml.Controls.Page
    {
        private readonly Lazy<MauiContext> mauiContext = new(InitializeMauiContext);

        protected MauiContext MauiContext => mauiContext.Value;

        private static MauiContext InitializeMauiContext()
        {
            var mauiApp = MauiProgram.CreateMauiApp();
#if Net8
            // This call is needed to ensure that the Application instance is 
            // resolved for accessing global resources.
            var _ = mauiApp.Services.GetRequiredService<IApplication>();
#endif
            return new MauiContext(mauiApp.Services);
        }
    }
}

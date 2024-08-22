namespace WinUIBlazorApp._1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
#if (!Net9)

            MainPage = new MainPage();
#endif
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
#if Net9
            return new Window(new MainPage()) { Title = "WinUIBlazorApp._1" };
#else
            var window = base.CreateWindow(activationState);
            window.Title = "WinUIBlazorApp._1";
            return window;
#endif
        }
    }
}

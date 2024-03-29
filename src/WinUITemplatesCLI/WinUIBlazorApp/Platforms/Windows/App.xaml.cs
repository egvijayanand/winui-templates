﻿using Microsoft.UI.Xaml;

namespace WinUIBlazorApp._1.WinUI
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : MauiWinUIApplication
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            //base.OnLaunched(args);
            var mauiApp = CreateMauiApp();
            var mauiContext = new MauiContext(mauiApp.Services);
            Services = mauiContext.Services;
            new MainWindow().Activate();
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}

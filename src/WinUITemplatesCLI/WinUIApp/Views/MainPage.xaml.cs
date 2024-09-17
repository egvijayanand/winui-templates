namespace WinUIApp._1.Views
{
    /// <summary>
    /// A simple page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public partial class MainPage : Page
    {
#if (!Mvvm)
        int count = 0;

#endif
        public MainPage()
        {
            this.InitializeComponent();
        }

#if Mvvm
        public MainViewModel ViewModel => new();
#else
        private void OnCountClicked(object sender, RoutedEventArgs e)
            => txtCount.Text = $"Current count: {count++}";
#endif
    }
}

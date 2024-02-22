namespace WinUIApp._1
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
#if (!Mvvm)
        int count = 0;

#endif
        public MainWindow()
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

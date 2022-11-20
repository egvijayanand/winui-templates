using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUIApp._1
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        int count = 0;

        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void OnCountClicked(object sender, RoutedEventArgs e)
        {
            count++;
            btnCount.Content = count switch
            {
                1 => $"Clicked {count} time",
                _ => $"Clicked {count} times",
            };
        }
    }
}

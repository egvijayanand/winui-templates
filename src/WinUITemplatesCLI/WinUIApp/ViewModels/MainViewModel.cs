namespace WinUIApp._1.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private int count = 0;

        public MainViewModel()
        {
            Title = "Home";
        }

        [ObservableProperty]
        private string _countText = "Current count: 0";

        [RelayCommand]
        private void Increment()
        {
            count++;
            CountText = $"Current count: {count}";
        }
    }
}

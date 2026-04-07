namespace WinUIApp._1.ViewModels
{
    public partial class MainViewModel() : BaseViewModel("Home")
    {
        private int _count;

        [ObservableProperty]
#if Net10OrLater
        public partial string CountText { get; set; } = "Current count: 0";
#else
        private string _countText = "Current count: 0";
#endif

        [RelayCommand]
        private void Increment()
        {
            _count++;
            CountText = $"Current count: {_count}";
        }
    }
}

namespace WinUIApp._1.ViewModels
{
    public partial class BaseViewModel(string title = "") : ObservableObject
    {
        [ObservableProperty]
#if Net10OrLater
        public partial string Title { get; set; } = title;
#else
        private string _title = title;
#endif
    }
}

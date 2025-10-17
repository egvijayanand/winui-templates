namespace WinUIBlazorApp._1.ViewModels
{
    public partial class BaseViewModel(string title = "") : ObservableObject
    {
#if Net10OrLater
        [ObservableProperty]
        public partial string Title { get; set; } = title;
#elif (MauiLib || Net8)
        [ObservableProperty]
        private string _title = title;
#else
        private string _title = title;

        // .NET MAUI SG is yet to support source-generated properties.
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
#endif
    }
}

namespace WinUIBlazorApp._1.ViewModels
{
    public partial class MauiViewModel() : BaseViewModel("Home")
    {
#if Net10OrLater
        [ObservableProperty]
        public partial string StartPath { get; set; } = "/counter";
#elif (MauiLib || Net8)
        [ObservableProperty]
        private string _startPath = "/counter";
#else
        private string _startPath = "/counter";

        // .NET MAUI SG is yet to support source-generated properties.
        public string StartPath
        {
            get => _startPath;
            set => SetProperty(ref _startPath, value);
        }
#endif
    }
}

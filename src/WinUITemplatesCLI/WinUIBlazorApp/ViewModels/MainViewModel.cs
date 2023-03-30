namespace WinUIBlazorApp._1.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        public MainViewModel() => Title = "Home";
#if Net8

        [ObservableProperty]
        private string _startPath = "/counter";
#endif
    }
}

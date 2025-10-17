namespace WinUIBlazorApp._1.Views
{
    public partial class VersionTemplate : ContentView
    {
        public VersionTemplate()
        {
            var footer = new Grid()
            {
                BackgroundColor = (Color)Application.Current!.Resources["Primary"],
                Children =
                {
                    new Label
                    {
                        HorizontalOptions = LayoutOptions.Center,
                        Text = MyApp.MauiVersion,
                        TextColor = Colors.White,
                        VerticalOptions = LayoutOptions.Center,
                    }
                }
            };

            Grid.SetRow(footer, 1);

            Content = new Grid()
            {
                RowDefinitions = [new(), new(40)],
                Children =
                {
                    new ContentPresenter(),
                    footer
                }
            };
        }
    }
}

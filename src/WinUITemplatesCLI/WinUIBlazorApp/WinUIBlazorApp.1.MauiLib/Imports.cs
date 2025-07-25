#if AddMvvmToolkit
global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;
global using CommunityToolkit.Mvvm.Messaging;

#endif
global using WinUIBlazorApp._1;
#if Mvvm
global using WinUIBlazorApp._1.ViewModels;
#endif
global using WinUIBlazorApp._1.Views;

// Static
global using static Microsoft.Maui.Graphics.Colors;

#if Net10OrLater
[assembly: XmlnsDefinition("http://schemas.microsoft.com/dotnet/maui/global", "WinUIBlazorApp._1")]
#if Mvvm
[assembly: XmlnsDefinition("http://schemas.microsoft.com/dotnet/maui/global", "WinUIBlazorApp._1.ViewModels")]
#endif
[assembly: XmlnsDefinition("http://schemas.microsoft.com/dotnet/maui/global", "WinUIBlazorApp._1.Views")]
#endif

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

// Implicit Namespace option
#if ImplicitNamespace
[assembly: System.Runtime.Versioning.RequiresPreviewFeatures]
[assembly: Microsoft.Maui.Controls.Xaml.Internals.AllowImplicitXmlnsDeclaration]
#else
// To enable, uncomment the below two lines.
//[assembly: System.Runtime.Versioning.RequiresPreviewFeatures]
//[assembly: Microsoft.Maui.Controls.Xaml.Internals.AllowImplicitXmlnsDeclaration]
#endif
// Alternatively, this can be done in the project file also.
// Set the EnablePreviewFeatures node and assign its value to true.
// And then define this constant: MauiAllowImplicitXmlnsDeclaration

[assembly: XmlnsDefinition("http://schemas.microsoft.com/dotnet/maui/global", "WinUIBlazorApp._1")]
#if Mvvm
[assembly: XmlnsDefinition("http://schemas.microsoft.com/dotnet/maui/global", "WinUIBlazorApp._1.ViewModels")]
#endif
[assembly: XmlnsDefinition("http://schemas.microsoft.com/dotnet/maui/global", "WinUIBlazorApp._1.Views")]
#endif

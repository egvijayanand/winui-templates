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
#else
// To enable, uncomment the line below.
//[assembly: System.Runtime.Versioning.RequiresPreviewFeatures]
#endif
// Alternatively, this can be done in the project file also.
// Set the EnablePreviewFeatures node and assign its value to true.
#endif

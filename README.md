## CLI Project and Item Templates for developing WinUI 3 based Windows Desktop Apps

CLI project template for developing `WinUI 3` App and Class Library and is named as `winui` and `winuilib` respectively.

Both of the project templates takes the target framework as an input parameter, can be specified with `--framework` / `-f`.

And the supported values are:

* net6.0
* net7.0 (the default value)
* net8.0

CLI item template for `WinUI 3` Page, UserControl, and Window and is named as `winui-page`, `winui-usercontrol`, and `winui-window` respectively.

Join me on [**Developer Thoughts**](https://egvijayanand.in/ "Developer Thoughts"), an exclusive blog for .NET MAUI and Blazor.

[![VijayAnand.WinUITemplates - NuGet Package](https://badgen.net/nuget/v/VijayAnand.WinUITemplates/)](https://www.nuget.org/packages/VijayAnand.WinUITemplates/ "WinUI CLI Templates")

To install the template NuGet package, use the below .NET CLI command:

```shell
dotnet new install VijayAnand.WinUITemplates
```

If you've already installed this package, then it can be updated to the latest version with the below command:

```shell
dotnet new update --check-only
```
```shell
dotnet new update
```

Use the below .NET CLI command to create the projects out these template:

App:
```shell
dotnet new winui -n MyApp
```

```shell
dotnet new winui -f net8.0 -n MyApp
```

Library:
```shell
dotnet new winuilib -n MyLib
```

```shell
dotnet new winuilib -f net8.0 -n MyLib
```

Both the project templates take the below optional parameter to include the officially supported CommunityToolkit.Mvvm NuGet package.

* `-imt` | `--include-mvvm-toolkit` - Default value is false

```shell
dotnet new winui -n MyApp -imt
```

```shell
dotnet new winuilib -n MyLib -imt
```

Use the below .NET CLI command to create the items out these template:

All of these item templates take two parameters:

* `-n` | `--name` - Name of the item
* `-na` | `--namespace` - Namespace for the item being created

*Note: While working with .NET 7 or higher SDK, the namespace parameter in short notation needs to be prefixed with `-p:` and hence this need to be mentioned as `-p:na`.*

Page:
```shell
dotnet new winui-page -n OrderPage -na MyApp.Pages
```

UserControl:
```shell
dotnet new winui-usercontrol -n CardView -na MyApp.Views
```

Window:
```shell
dotnet new winui-window -n MainWindow -na MyApp
```

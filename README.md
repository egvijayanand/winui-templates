## CLI Project and Item Templates for developing WinUI 3 based Desktop Apps

CLI project template for developing `WinUI 3` App and Class Library and is named as `winui` and `winuilib` respectively.

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

```shell
dotnet new winui -n MyWinUIApp
```

```shell
dotnet new winuilib -n MyWinUILib
```

Both the project templates take the below optional parameter to include the officially supported CommunityToolkit.Mvvm NuGet package.

* `-imt` | `--include-mvvm-toolkit` - Default value is false

```shell
dotnet new winui -n MyWinUIApp -imt
```

```shell
dotnet new winuilib -n MyWinUILib -imt
```

Use the below .NET CLI command to create the items out these template:

All of these item templates take two parameters:

* `-n` | `--name` - Name of the item
* `-na` | `--namespace` - Namespace for the item being created

*Note: While working with .NET 7 SDK, the namespace parameter in short notation needs to be prefixed with `-p:` and hence this need to be mentioned as `-p:na`.*

Page:
```shell
dotnet new winui-page -n OrderPage -na MyWinUIApp.Pages
```

UserControl:
```shell
dotnet new winui-usercontrol -n CardView -na MyWinUIApp.Views
```

Window:
```shell
dotnet new winui-window -n MainWindow -na MyWinUIApp
```

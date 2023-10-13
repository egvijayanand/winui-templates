### CLI Project and Item Templates for developing WinUI 3 based Windows Desktop Apps

Join me on [**Developer Thoughts**](https://egvijayanand.in/ "Developer Thoughts"), an exclusive blog for .NET MAUI and Blazor.

#### Package Status:

|Channel|Version|
|:---:|:---:|
|Stable|[![VijayAnand.WinUITemplates - NuGet Package](https://badgen.net/nuget/v/VijayAnand.WinUITemplates/?icon=nuget)](https://www.nuget.org/packages/VijayAnand.WinUITemplates/ "WinUI CLI Templates (Stable)")|
|Preview|[![VijayAnand.WinUITemplates - NuGet Package](https://badgen.net/nuget/v/VijayAnand.WinUITemplates/latest?icon=nuget)](https://www.nuget.org/packages/VijayAnand.WinUITemplates/absoluteLatest "WinUI CLI Templates (Preview)")|

<!-- CLI project template for developing `WinUI 3` App and Class Library and is named as `winui` and `winuilib` respectively. -->

|Item|Template Name|Type|
|:---:|:---:|:---:|
|WinUI 3 App|winui|Project|
|WinUI 3 Blazor App|winui-blazor|Project|
|WinUI 3 Class Library|winuilib|Project|
|WinUI 3 Page|winui-page|Item|
|WinUI 3 UserControl|winui-usercontrol|Item|
|WinUI 3 Window|winui-window|Item|

All three project templates takes the target framework as an input parameter, can be specified with `--framework` / `-f`.

And the supported values are:

* net6.0
* net7.0
* net8.0 (the default value)

All three project templates take the below optional parameter to include the officially supported [CommunityToolkit.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm) NuGet package.

* `-imt` | `--include-mvvm-toolkit` - Default value is `false`

Both the **App** project takes another optional parameter thus allowing it to be created as MVVM supported solution using the same Microsoft MVVM Toolkit.

* `-mvvm` | `--use-mvvm` - Default value is `false`

<!-- CLI item template for `WinUI 3` Page, UserControl, and Window and is named as `winui-page`, `winui-usercontrol`, and `winui-window` respectively. -->

To install the template NuGet package, use the below .NET CLI command:

Latest stable version:

```shell
dotnet new install VijayAnand.WinUITemplates
```

Latest preview version:

```shell
dotnet new install VijayAnand.WinUITemplates::2.2.0-preview.4
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
.NET 7 solution:
```shell
dotnet new winui -n MyApp -f net7.0
```
MVVM based solution:
```shell
dotnet new winui -n MyApp -mvvm
```
Option to include only the MVVM NuGet package:
```shell
dotnet new winui -n MyApp -imt
```

Blazor App:
```shell
dotnet new winui-blazor -n MyApp
```
.NET 7 solution:
```shell
dotnet new winui-blazor -n MyApp -f net7.0
```
MVVM based solution:
```shell
dotnet new winui-blazor -n MyApp -mvvm
```
Option to include only the MVVM NuGet package:
```shell
dotnet new winui-blazor -n MyApp -imt
```

Library:
```shell
dotnet new winuilib -n MyLib
```
.NET 7 solution:
```shell
dotnet new winuilib -n MyLib -f net7.0
```
Option to include only the MVVM NuGet package:
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

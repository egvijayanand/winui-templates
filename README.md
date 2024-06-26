### CLI Project and Item Templates for developing WinUI 3 based Windows Desktop Apps

Join me on [**Developer Thoughts**](https://egvijayanand.in/ "Developer Thoughts"), an exclusive blog for .NET MAUI and Blazor.

#### Package Status:

|Channel|Version|
|:---:|:---:|
|Stable|[![VijayAnand.WinUITemplates - NuGet Package](https://badgen.net/nuget/v/VijayAnand.WinUITemplates/?icon=nuget)](https://www.nuget.org/packages/VijayAnand.WinUITemplates/ "WinUI CLI Templates (Stable)")|
<!--
|Preview|[![VijayAnand.WinUITemplates - NuGet Package](https://badgen.net/nuget/v/VijayAnand.WinUITemplates/latest?icon=nuget)](https://www.nuget.org/packages/VijayAnand.WinUITemplates/absoluteLatest "WinUI CLI Templates (Preview)")|
-->

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
* net8.0 _(the default value)_
* net9.0

Note: The default value for the framework parameter remains as `net8.0` (the latest stable channel), which means to create a project for .NET 9 (the preview channel), an explicit value of `net9.0` is to be passed.

All three project templates take the below optional parameter to include the officially supported [CommunityToolkit.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm) NuGet package.

* `-imt` | `--include-mvvm-toolkit` - Default value is `false`

Both the **App** project takes another optional parameter thus allowing it to be created as MVVM supported solution using the same Microsoft MVVM Toolkit.

* `-mvvm` | `--use-mvvm` - Default value is `false`

Starting with [v3.1.0](https://www.nuget.org/packages/VijayAnand.WinUITemplates/3.1.0), all three project templates take the below optional parameter support NuGet's Central Package Management (CPM) feature.

Starting with [v3.3.0](https://www.nuget.org/packages/VijayAnand.WinUITemplates/3.3.0), added the ability to use the NuGet Central Package Management (CPM) feature within Visual Studio IDE.

* `-cpm` | `--central-pkg-mgmt` - Default value is `false`

Note: This can also be used in combination with other options.

<!-- CLI item template for `WinUI 3` Page, UserControl, and Window and is named as `winui-page`, `winui-usercontrol`, and `winui-window` respectively. -->

To install the template NuGet package, use the below .NET CLI command:

Latest stable version:

```shell
dotnet new install VijayAnand.WinUITemplates
```

<!--
Latest preview version:

```shell
dotnet new install VijayAnand.WinUITemplates::2.2.0-preview.4
```
-->

If you've already installed this package, then it can be updated to the latest version with the below command:

```shell
dotnet new update --check-only
```

```shell
dotnet new update
```

Use the below .NET CLI command to create the projects out these template:

**WinUI 3 App:**

```shell
dotnet new winui -n MyApp
```

.NET 7:
```shell
dotnet new winui -n MyApp -f net7.0
```

.NET 9 Preview:
```shell
dotnet new winui -n MyApp -f net9.0
```

MVVM based solution:
```shell
dotnet new winui -n MyApp -mvvm
```

Option to include only the MVVM NuGet package:
```shell
dotnet new winui -n MyApp -imt
```

Option to use the CPM feature:
```shell
dotnet new winui -n MyApp -cpm
```

**Blazor Hybrid App:**

```shell
dotnet new winui-blazor -n HybridApp
```

.NET 7:
```shell
dotnet new winui-blazor -n HybridApp -f net7.0
```

.NET 9 Preview:
```shell
dotnet new winui-blazor -n HybridApp -f net9.0
```

MVVM based solution:
```shell
dotnet new winui-blazor -n HybridApp -mvvm
```

Option to include only the MVVM NuGet package:
```shell
dotnet new winui-blazor -n HybridApp -imt
```

Option to use the CPM feature:
```shell
dotnet new winui-blazor -n HybridApp -cpm
```

**Library:**

```shell
dotnet new winuilib -n MyLib
```

.NET 7:
```shell
dotnet new winuilib -n MyLib -f net7.0
```

.NET 9 Preview:
```shell
dotnet new winuilib -n MyLib -f net9.0
```

Option to include only the MVVM NuGet package:
```shell
dotnet new winuilib -n MyLib -imt
```

Option to use the CPM feature:
```shell
dotnet new winuilib -n MyLib -cpm
```

Use the below .NET CLI command to create the items out these template:

All these item templates require one mandatory parameter:

* `-n` | `--name` - Name of the item

Auto suffixing of the Type name is supported for the files created with the `Page` and `Window` item templates.

Page:
```shell
dotnet new winui-page -n Order
```

UserControl:
```shell
dotnet new winui-usercontrol -n CardView
```

Window:
```shell
dotnet new winui-window -n Home
```

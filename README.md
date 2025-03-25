### CLI Project and Item Templates for developing WinUI 3 based Windows Desktop Apps

Join me on [**Developer Thoughts**](https://egvijayanand.in/ "Developer Thoughts"), an exclusive blog for .NET MAUI and Blazor.

#### Package Status:

|Channel|Version|
|:---:|:---:|
|Stable|[![VijayAnand.WinUITemplates - NuGet Package](https://badgen.net/nuget/v/VijayAnand.WinUITemplates/?icon=nuget&foo=bar)](https://www.nuget.org/packages/VijayAnand.WinUITemplates/ "WinUI CLI Templates (Stable)")|
<!--
|Preview|[![VijayAnand.WinUITemplates - NuGet Package](https://badgen.net/nuget/v/VijayAnand.WinUITemplates/latest?icon=nuget)](https://www.nuget.org/packages/VijayAnand.WinUITemplates/absoluteLatest "WinUI CLI Templates (Preview)")|
-->

<!-- CLI project template for developing `WinUI 3` App and Class Library and is named as `winui` and `winuilib` respectively. -->

#### Install Package:

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

#### Templates Included

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

* net8.0
* net9.0 *(the default value)*
* net10.0

Note: The default value for the framework parameter remains as `net9.0` (the latest stable channel), which means to create a project for .NET 10 (the preview channel), an explicit value of `net10.0` is to be passed.

All three project templates take the below optional parameter to include the officially supported [CommunityToolkit.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm) NuGet package.

* `-imt` | `--include-mvvm-toolkit` - Default value is `false`

Both the **App** project takes another optional parameter thus allowing it to be created as MVVM supported solution using the same Microsoft MVVM Toolkit.

* `-mvvm` | `--use-mvvm` - Default value is `false`

Starting with [v3.1.0](https://www.nuget.org/packages/VijayAnand.WinUITemplates/3.1.0), all three project templates take the below optional parameter support NuGet's Central Package Management (CPM) feature.

* `-cpm` | `--central-pkg-mgmt` - Default value is `false`

Starting with [v3.3.0](https://www.nuget.org/packages/VijayAnand.WinUITemplates/3.3.0), added the ability to use the NuGet Central Package Management (CPM) feature within Visual Studio IDE.

Starting with [v3.4.0](https://www.nuget.org/packages/VijayAnand.WinUITemplates/3.4.0), introduced an option to support the XML-based solution file (slnx) format.

*This would be an explicit option since the SLNX feature is currently in the preview stage and is only supported on VS2022.*

Starting with [v4.0.0](https://www.nuget.org/packages/VijayAnand.WinUITemplates/4.0.0), added another option (`net10.0`) to the `framework` parameter to support .NET 10 Previews and revamped the WinUI Blazor project template.

* `-slnx` | `--use-slnx` - Default value is `false`

*Note: These options may also be combined.*

<!-- CLI item template for `WinUI 3` Page, UserControl, and Window and is named as `winui-page`, `winui-usercontrol`, and `winui-window` respectively. -->

Use the below .NET CLI command to create the projects out these template:

#### WinUI 3 App:

```shell
dotnet new winui -n MyApp
```

.NET 8:
```shell
dotnet new winui -n MyApp -f net8.0
```

.NET 10 Preview:
```shell
dotnet new winui -n MyApp -f net10.0
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

Option to create the SLNX solution file:
```shell
dotnet new winui -n MyApp -slnx
```

#### Blazor Hybrid App:

```shell
dotnet new winui-blazor -n HybridApp
```

.NET 8:
```shell
dotnet new winui-blazor -n HybridApp -f net8.0
```

.NET 10 Preview:
```shell
dotnet new winui-blazor -n HybridApp -f net10.0
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

Option to create the SLNX solution file:
```shell
dotnet new winui-blazor -n HybridApp -slnx
```

#### Library:

```shell
dotnet new winuilib -n MyLib
```

.NET 8:
```shell
dotnet new winuilib -n MyLib -f net8.0
```

.NET 10 Preview:
```shell
dotnet new winuilib -n MyLib -f net10.0
```

Option to include only the MVVM NuGet package:
```shell
dotnet new winuilib -n MyLib -imt
```

Option to use the CPM feature:
```shell
dotnet new winuilib -n MyLib -cpm
```

Option to create the SLNX solution file:
```shell
dotnet new winuilib -n MyLib -slnx
```

#### Item Templates:

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

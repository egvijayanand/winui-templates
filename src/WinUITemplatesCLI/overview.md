## CLI Project and Item Templates for developing WinUI 3 based Windows Desktop Apps

|Item|Template Name|Type|
|:---:|:---:|:---:|
|WinUI 3 App|winui|Project|
|WinUI 3 Blazor App|winui-blazor|Project|
|WinUI 3 Class Library|winuilib|Project|
|WinUI 3 Page|winui-page|Item|
|WinUI 3 UserControl|winui-usercontrol|Item|
|WinUI 3 Window|winui-window|Item|

All the project templates takes the target framework as an input parameter, can be specified with `--framework` / `-f`.

And the supported values are:

* net8.0
* net9.0
* net10.0 *(the default value)*

Note: The default value for the `framework` parameter remains as `net10.0` (the latest stable release), which means to create a project for `.NET 8` or `.NET 9`, an explicit value of `net8.0` / `net9.0` is to be passed.

Starting with [v3.1.0](https://www.nuget.org/packages/VijayAnand.WinUITemplates/3.1.0), all three project templates take the below optional parameter support NuGet's Central Package Management (CPM) feature.

* `-cpm` | `--central-pkg-mgmt` - Default value is `false`

Starting with [v3.3.0](https://www.nuget.org/packages/VijayAnand.WinUITemplates/3.3.0), added the ability to use the NuGet Central Package Management (CPM) feature within Visual Studio IDE.

Starting with [v3.4.0](https://www.nuget.org/packages/VijayAnand.WinUITemplates/3.4.0), introduced an option to support the XML-based solution file (slnx) format.

* `-slnx` | `--use-slnx` - Default value is `true` (from `v5.0` onwards)

Starting with [v4.0.0](https://www.nuget.org/packages/VijayAnand.WinUITemplates/4.0.0), added another option (`net10.0`) to the `framework` parameter to support .NET 10 Previews and revamped the WinUI Blazor project template.

Starting with [v4.2.0](https://www.nuget.org/packages/VijayAnand.WinUITemplates/4.2.0), introduced an option to abstract the Shared components as a separate .NET MAUI and/or Razor Class Library.

Starting with [v4.3.0](https://www.nuget.org/packages/VijayAnand.WinUITemplates/4.3.0), introduced an option to use Nightly builds with WinUI Blazor projects for .NET MAUI components, featuring automatic configuration of package feeds.

.NET MAUI XAML can be included within this .NET MAUI-specific class library.

* `-mcl` | `--maui-class-library` - Default value is `false`

This Razor Class Library allows code reuse with other projects such as ASP.NET Core.

* `-rcl` | `--razor-class-library` - Default value is `false`

Note: Use both options to segregate MAUI and Razor components into distinct libraries.

```shell
dotnet new winui-blazor -o MyApp -mcl
```

```shell
dotnet new winui-blazor -o SharedApp -rcl
```

```shell
dotnet new winui-blazor -o HybridApp -mcl -rcl
```

```shell
dotnet new winui-blazor -o NightlyApp -ni
```
*Note: These options may also be combined.*

All these item templates require one mandatory parameter:

* `-n` | `--name` - Name of the item

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

.NET 9:

```shell
dotnet new winui -n MyApp -f net9.0
```

.NET 8:

```shell
dotnet new winui -n MyApp -f net8.0
```

Option to use the CPM feature:

```shell
dotnet new winui -n MyApp -cpm
```

**Blazor Hybrid App:**

```shell
dotnet new winui-blazor -n HybridApp
```

.NET 9:

```shell
dotnet new winui-blazor -n HybridApp -f net9.0
```

.NET 8:

```shell
dotnet new winui-blazor -n HybridApp -f net8.0
```

Option to use the CPM feature:

```shell
dotnet new winui-blazor -n HybridApp -cpm
```

**Library:**

```shell
dotnet new winuilib -n MyLib
```

.NET 9:

```shell
dotnet new winuilib -n MyLib -f net9.0
```

.NET 8:

```shell
dotnet new winuilib -n MyLib -f net8.0
```

Option to use the CPM feature:

```shell
dotnet new winuilib -n MyLib -cpm
```

All three project templates take the below optional parameter to include the officially supported [CommunityToolkit.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm/) NuGet package.

* `-imt` | `--include-mvvm-toolkit` - Default value is false

```shell
dotnet new winui -n MyApp -imt
```

```shell
dotnet new winui-blazor -n HybridApp -imt
```

```shell
dotnet new winuilib -n MyLib -imt
```

Use the below .NET CLI command to create the items out these template:

Auto suffixing of the Type name is supported for the files created with the `Page` and `Window` item templates.

Page:

```shell
dotnet new winui-page -n Order
```

User Control:

```shell
dotnet new winui-usercontrol -n CardView
```

Window:

```shell
dotnet new winui-window -n Home
```

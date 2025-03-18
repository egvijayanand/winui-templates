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
* net9.0 *(the default value)*
* net10.0

Note: The default value for the framework parameter remains as `net9.0` (the latest stable channel), which means to create a project for .NET 9 (the preview channel), an explicit value of `net10.0` is to be passed.

Starting with [v3.1.0](https://www.nuget.org/packages/VijayAnand.WinUITemplates/3.1.0), all three project templates take the below optional parameter support NuGet's Central Package Management (CPM) feature.

* `-cpm` | `--central-pkg-mgmt` - Default value is `false`

Note: This can also be used in combination with other options.

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

```shell
dotnet new winui -n MyApp -f net8.0
```

.NET 10 Preview:

```shell
dotnet new winui -n MyApp -f net10.0
```

Option to use the CPM feature:
```shell
dotnet new winui -n MyApp -cpm
```

**Blazor Hybrid App:**

```shell
dotnet new winui-blazor -n HybridApp
```

```shell
dotnet new winui-blazor -n HybridApp -f net8.0
```

.NET 10 Preview:

```shell
dotnet new winui-blazor -n HybridApp -f net10.0
```

Option to use the CPM feature:
```shell
dotnet new winui-blazor -n HybridApp -cpm
```

**Library:**

```shell
dotnet new winuilib -n MyLib
```

```shell
dotnet new winuilib -n MyLib -f net8.0
```

.NET 10 Preview:

```shell
dotnet new winuilib -n MyLib -f net10.0
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

UserControl:
```shell
dotnet new winui-usercontrol -n CardView
```

Window:
```shell
dotnet new winui-window -n Home
```

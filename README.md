## CLI Project Templates for developing WinUI 3 based Desktop Apps

CLI project template for developing `WinUI 3` App and Class Library and is named as `winui` and `winuilib` respectively.

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

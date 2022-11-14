:: Installs the NuGet package
@echo off

if defined MyGetSource (set nugetSource=%MyGetSource%) else (set nugetSource=E:\Tasks\Projects\Templates\Release\NuGet)

:: Package Name

if not exist PackageName.txt (call Error "Package name file not available." & goto end)

set /P packageName=<PackageName.txt

if [%packageName%]==[] (call Error "Package name not configured." & goto end)

:: Package Version

if not exist PackageVersion.txt (call Error "Package version file not available." & goto end)

set /P packageVersion=<PackageVersion.txt

if [%packageVersion%]==[] (call Error "Package version # not configured." & goto end)

:: Existence Check

if not exist .\bin\Release\%packageName%.%packageVersion%.nupkg (call Error "NuGet package not avilable." & goto end)

:: Push the Package

call Info "Pushing %packageName% ver. %packageVersion% to My NuGet ..."

dotnet nuget push .\bin\Release\%packageName%.%packageVersion%.nupkg --source %nugetSource%\%packageName%

if %errorlevel% == 0 (call Success "Process completed.") else (call Error "Package push failed.")

:end
pause

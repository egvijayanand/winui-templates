:: Removes the installed project template
@echo off

:: Package Name

if not exist PackageName.txt (call Error "Package name file not available." & goto end)

set /P packageName=<PackageName.txt

if [%packageName%]==[] (call Error "Package name not configured." & goto end)

:: Package Version

if not exist PackageVersion.txt (call Error "Version file not available." & goto end)

set /P packageVersion=<PackageVersion.txt

if [%packageVersion%]==[] (call Error "Version # not configured." & goto end)

call Info "Uninstalling the %packageName% template ..."

dotnet new uninstall %packageName%

if %errorlevel% == 0 (call Success "Process completed.") else (call Error "Failed to uninstall the template package.")

:end
pause

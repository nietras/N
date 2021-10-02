dotnet remove src\NConsole\NConsole.csproj package N
$packageCache = $env:USERPROFILE + "\.nuget\packages\n"
if (Test-Path -Path $packageCache) {
    Write-Host "Deleting nuget cache " + $packageCache
    rmdir $packageCache -Recurse
}
dotnet add src\NConsole\NConsole.csproj package N  -- -no-cache
dotnet build -c Release
dotnet pack -c Release
cp "src\N\bin\Release\*.nupkg" .\ -Force
dotnet build -c Release
dotnet pack
cp "src\N\bin\Release\*.nupkg" .\ -Force
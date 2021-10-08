# N - *The* Library for World's Smallest C# Program "That Does Something"™
Tired of boilerplate? Then N is for you!

[![NuGet version (N)](https://img.shields.io/nuget/dt/N.svg?style=flat-square)](https://www.nuget.org/packages/N/)
[![NuGet version (N)](https://img.shields.io/nuget/v/N.svg?style=flat-square)](https://www.nuget.org/packages/N/)

## Blog Post
[World's Smallest C# Program (featuring `N`)](https://nietras.com/2021/10/09/worlds-smallest-csharp-program/)

## Small Programs
Install `N` and all you need for a full C# program in `Program.cs` is
(at 4 characters):
```csharp
N();
```
Want to increment?
```csharp
++I;
```
or
```csharp
I++;
```
Decrement?
```csharp
--I;
```
or
```csharp
I--;
```
Absolutely need to assign something?
```csharp
I=0;
```
or
```csharp
I=I;
```
Declare a variable for a reference type (with warning) - this doesn't really do much:
```csharp
O o;
```
or for a value type (with warning):
```csharp
S s;
```

In addition, `N` let's you write the smallest programs featuring
specific constructs:

Want to be asynchronous? **World's Smallest C# async/await Program** (8 characters)
```csharp
await T;
```
Want to return a code?  (9 characters)
```csharp
return I;
```
Need a while loop (9 characters):
```csharp 
while(B);
```
or for loop (9 characters):
```csharp 
for(;B;);
```
or do while loop (13 characters):
```csharp 
do{}while(B);
```
Need to new something up (7 characters).
```csharp
new O();
```
What about `args`? `N`s got you covered (8 characters).
```csharp
N(args);
```
Remember the `GetAwaiter()` loop hole? `N` let's you await an integer (8 characters).
```csharp
await 1;
```
Need to dispose with using:
```csharp
using(D);
```
Want to just return? You don't need `N` ;)
```csharp
return;
```
Want to do nothing? You don't need `N` ;)
```csharp
{}
```
This should be the world's smallest C# program out-of-the-box in .NET 5+ and C# 9+.

## Supported Frameworks and Language
.NET Standard 2.0+
C# 10+


namespace System;

public static class C
{
    public static Task T { get; set; } = Task.CompletedTask;

    public static int I { get; set; } = 42;

    public static void N(string[]? args = default)
    {
        Console.WriteLine($"Hello friend from nietras!\n{string.Join("\n", args ?? Array.Empty<string>())}");
    }

    public record O;
}
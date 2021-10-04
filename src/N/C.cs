using System.Runtime.CompilerServices;

namespace nietras;

public static class C
{
    public static Task T { get; set; } = Task.CompletedTask;

    public static int I { get; set; } = 42;

    public static void N(string[]? args = default)
    {
        Console.WriteLine($"Hello friend from nietras!\n{string.Join("\n", args ?? Array.Empty<string>())}");
    }

    public record O;

    public static Int32Awaiter GetAwaiter(this int i)
    {
        return new Int32Awaiter(i);
    }
    public readonly struct Int32Awaiter : INotifyCompletion
    {
        readonly int _i;

        public Int32Awaiter(int i) => _i = i;

        public bool IsCompleted { get; } = true;
        public int GetResult() => _i;
        public void OnCompleted(Action continuation) => continuation();
    }
}
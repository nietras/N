using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace nietras;

public static class C
{
    public static void N(string[]? args = default)
    {
        Console.WriteLine($"Hello friend from nietras!\n{string.Join("\n", args ?? Array.Empty<string>())}");
    }

    public static bool B { get; set; } = false;

    public static E D { get; set; } = new ();

    public record E : IDisposable
    {
        public void Dispose() { }
    }

    public static int I { get; set; } = 42;

    public unsafe static byte* P { get; set; } = (byte*)Marshal.AllocHGlobal(1);

    public record O;

    static int _r = 0;
    public static ref int R { get => ref _r; }

    public readonly record struct S;

    public static Task T { get; set; } = Task.CompletedTask;

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
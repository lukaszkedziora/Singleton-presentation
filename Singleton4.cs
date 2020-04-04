//Fifth version - fully lazy instantiation

namespace singleton
{
    public sealed class Singleton4
    {
    private Singleton4()
    {
    }

    public static Singleton4 Instance { get { return Nested.instance; } }

    private class Nested
    {
    // Explicit static constructor to tell C# compiler
    // not to mark type as beforefieldinit
    static Nested()
    {
    }

    internal static readonly Singleton4 instance = new Singleton4();
    }
    }
}
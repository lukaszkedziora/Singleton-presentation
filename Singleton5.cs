//Fifth version - fully lazy instantiation


namespace singleton
{
    public sealed class Singleton5
    {
    private Singleton5()
    {
    }

    public static Singleton5 Instance { get { return Nested.instance; } }

    private class Nested
    {
    // Explicit static constructor to tell C# compiler
    // not to mark type as beforefieldinit
    static Nested()
    {
    }

    internal static readonly Singleton5 instance = new Singleton5();
    }
    }
}
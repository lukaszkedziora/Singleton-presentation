//Fourth version - not quite as lazy, but thread-safe without using locks

namespace singleton

{
    public sealed class Singleton3
    {
    private static readonly Singleton3 instance = new Singleton3();

    // Explicit static constructor to tell C# compiler
    // not to mark type as beforefieldinit
    static Singleton3()
    {
    }

    private Singleton3()
    {
    }

    public static Singleton3 Instance
    {
    get
    {
    return instance;
    }
    }
    }
}

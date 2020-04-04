//Third version - attempted thread-safety using double-check locking
// Bad code! Do not use!

namespace singleton
{
    public sealed class Singleton2
    {
    private static Singleton2 instance = null;
    private static readonly object padlock = new object();

    Singleton2()
    {
    }

    public static Singleton2 Instance
    {
    get
    {
    if (instance == null)
    {
    lock (padlock)
    {
    if (instance == null)
    {
    instance = new Singleton2();
    }
    }
    }
    return instance;
    }
    }
    }
}
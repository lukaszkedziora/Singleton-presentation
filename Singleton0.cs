//First version - not thread-safe
// Bad code! Do not use!
namespace singleton
{
    public sealed class Singleton0
    {
    private static Singleton0 instance=null;

    private Singleton0()
    {
    }

    public static Singleton0 Instance
    {
    get
    {
    if (instance==null)
    {
    instance = new Singleton0();
    }
    return instance;
    }
    }
    }
}
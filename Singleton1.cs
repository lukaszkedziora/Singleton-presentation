//Second version - simple thread-safety

namespace singleton1
{
    public sealed class Singleton1
    {
    private static Singleton1 instance = null;
    private static readonly object padlock = new object();

    Singleton1()
    {
    }

    public static Singleton1 Instance
    { get {
        lock (padlock) // "The lock statement acquires the mutual-exclusion lock for a given object"
        { 
            if (instance == null) 
        {
        instance = new Singleton1();
         }
        return instance;
        }
        
    }
    }
    //Singleton test1 = new Singleton();
    //Singleton test2 = new Singleton();


    }

    
}
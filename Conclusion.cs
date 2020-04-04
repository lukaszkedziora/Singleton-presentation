namespace Singleton
{
    public class Conclusion
    {
    /*
    1. A single constructor, which is private and parameterless. This prevents other classes from instantiating it 
    (which would be a violation of the pattern). 
    2. Note that it also prevents subclassing - if a singleton can be subclassed once, it can be subclassed twice, and if each of those subclasses can create an instance, the pattern is violated. 
    The factory pattern can be used if you need a single instance of a base type, but the exact type isn't known until runtime.
    
    3. The class is sealed. This is unnecessary, strictly speaking, due to the above point, but may help the JIT to optimise things more.
    
    4. A static variable which holds a reference to the single created instance, if any.
    
    5.A public static means of getting the reference to the single created instance, creating one if necessary.


    --> https://en.wikipedia.org/wiki/Glen_Ord_Distillery

    */
    }
}
using System;

public delegate void AnonymousDele(int value);

class Exercise4
{
    public void Run()
    {
        AnonymousDele printValue = delegate (int value)
        {
            Console.WriteLine("Inside Anonymous method. Value: {0}", value);
        };
        printValue += delegate
        {
            Console.WriteLine("This is Anonymous Method. ");
        };
        printValue(100);
    }
}

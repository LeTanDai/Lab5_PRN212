using System;

public delegate void MessageDelegate(string msg);
class MyClass
{
    public static void Print(string message)
    {
        Console.WriteLine($"{message.ToUpper()}");
    }
    public static void Show(string message)
    {
        Console.WriteLine($"{message.ToLower()}");
    }
}
class Exercise2
{
    static void InvokeDelegate(MessageDelegate md, string msg) => md(msg);
    public void Run()
    {
        string msg = "Anh trai say hi";
        InvokeDelegate(MyClass.Print,msg);
        InvokeDelegate(MyClass.Show, msg);
    }
}

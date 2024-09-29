using System;

public delegate void MultiDelegate(string msg);

class Message
{
    public static void Print(string message)
    {
        Console.WriteLine($"{message.ToUpper()}");
    }
    public static void Show(string message)
    {
        Console.WriteLine($"{message.ToLower()}");
    }
    public static void Display(string message)
    {
        Console.WriteLine($"{message}");
    }
}
class Exercise3
{
    public void Run()
    {
        string msg = "Multicast Delegate";
        MultiDelegate MyDele01 = Message.Print;
        MultiDelegate MyDele02 = Message.Show;
        Console.WriteLine("***Combines MyDele01 + MyDele02");
        MultiDelegate MyDele = MyDele01 + MyDele02;
        MyDele(msg);
        Console.WriteLine("***Combines MyDele01 + MyDele02 + MyDele03");
        MultiDelegate MyDele03 = Message.Display;
        MyDele += MyDele03;
        MyDele(msg);
        Console.WriteLine("------------------");
        Console.WriteLine("***Remove MyDele02***");
        MyDele -= MyDele02;
        MyDele("Hello World!!!");
    }
}

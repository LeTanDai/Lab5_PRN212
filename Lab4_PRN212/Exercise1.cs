using System;

public delegate int MyDelegate(int numOne, int numTwo);
class Exercise1
{

    static int Add(int numOne, int numTwo) => numOne + numTwo;
    static int Subtract(int numOne, int numTwo) => numOne - numTwo;

    public void Run()
    {
        int n1 = 25;
        int n2 = 15;
        int result;

        MyDelegate obj1 = new MyDelegate(Add);
        result = obj1(n1, n2);
        Console.WriteLine($"{n1} + {n2} = {result}");

        MyDelegate obj2 = Subtract;
        result = obj2.Invoke(n1, n2);
        Console.WriteLine($"{n1} - {n2} = {result}");
    }
}

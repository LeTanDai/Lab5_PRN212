using System;
public delegate void SampleDelegate(int a, int b);

class MathOperations
{
    public void Add (int a, int b)
    {
        Console.WriteLine("Total: {0}", a + b);
    }
    public void Subtract (int a, int b)
    {
        Console.WriteLine("Subtract: {0}", a - b);
    }
    public void Multiple(int a, int b)
    {
        Console.WriteLine("Multiple: {0}", a*b);
    }
    public void Devision(int a, int b)
    {
        try
        {
            Console.WriteLine("Devision: {0}", a/b); 
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
class Exercise5
{
    public void Run() {
        Console.WriteLine("***Example of Delegate***");
        MathOperations mathOperations = new MathOperations();
        SampleDelegate sampleDelegate = mathOperations.Add;
        sampleDelegate += mathOperations.Subtract;
        sampleDelegate += mathOperations.Multiple;
        sampleDelegate += mathOperations.Devision;
        sampleDelegate(20,10);
    }
}
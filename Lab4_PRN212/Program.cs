using System;


class Program
{
    static void Main(string[] args)
    {
        bool check = true;
        while (check)
        {
            Console.WriteLine("************Lab4_PRN212************");
            Console.WriteLine("1. Declare delegate");
            Console.WriteLine("2. Pass delegate in parameter");
            Console.WriteLine("3. Multicast delegate");
            Console.WriteLine("4. Anonymous Method");
            Console.WriteLine("5. Generic Delegate");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            try
            {
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Exercise1 exercise1 = new Exercise1();
                        exercise1.Run();
                        break;
                    case 2:
                        Exercise2 exercise2 = new Exercise2();
                        exercise2.Run();
                        break;
                    case 3:
                        Exercise3 exercise3 = new Exercise3();
                        exercise3.Run();
                        break;
                    case 4:
                        Exercise4 exercise4 = new Exercise4();
                        exercise4.Run();
                        break;
                    case 5:
                        Exercise5 exercise5 = new Exercise5();
                        exercise5.Run();
                        break;
                    case 6:
                        check = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Input must be a number!!! Please re-enter");
            }
        }
    }
}

namespace csharp_playground._2_oop.part_1;

public class MethodPart1
{
    public static void Run()
    {
        int a, b, c, d;
        int addResult;
        
        a = 1;
        b = 2;
        addResult = a + b;
        Console.WriteLine($"{a} + {b} = {addResult}");
        displayMessage();
        
        c = 1;
        d = 2;
        addResult = c + d;
        Console.WriteLine($"{c} + {d} = {addResult}");
        displayMessage();
    }

    static void displayMessage()
    {
        Console.WriteLine("Process is done");
        Console.WriteLine("This process is run by ahmad");
    }
}
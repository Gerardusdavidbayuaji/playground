namespace csharp_playground._2_oop.part_1;

public class MethodPart2
{
    public static void Run()
    {
        int a, b, c, d;
        int addResult;
        
        a = 1;
        b = 2;
        addResult = PerformAddOperation(a, b);
        Console.WriteLine($"{a} + {b} = {addResult}");
        displayMessage();
        
        c = 1;
        d = 2;
        addResult = PerformAddOperation(c, d);
        Console.WriteLine($"{c} + {d} = {addResult}");
        displayMessage();
    }

    static int PerformAddOperation(int a, int b)
    {
        int addResult = 0;
        addResult = a + b;
        return addResult;
    }

    static void displayMessage()
    {
        Console.WriteLine("Process is done");
        Console.WriteLine("This process is run by ahmad");
    }
}
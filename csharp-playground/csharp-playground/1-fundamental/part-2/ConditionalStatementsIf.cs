namespace csharp_playground._1_fundamental.part_2;

public class ConditionalStatementsIf
{
    public static void Run()
    {
        int x = 0;
        int y = 0;
        
        Console.WriteLine("Enter a first number: ");
        x = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter a second number: ");
        y = int.Parse(Console.ReadLine());

        if (x > y)
        {
            Console.WriteLine($"Number {x} is greater than {y}");
        } 
        else if (x < y)
        {
            Console.WriteLine($"Number {x} is less than {y}");
        }
        else
        {
            Console.WriteLine("They are equal");
        }
    }
}
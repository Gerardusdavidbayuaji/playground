namespace csharp_playground._1_fundamental.part_2;

public class Readline
{
    public static void Run()
    {
        Console.WriteLine("What is your name?");
        
        var name = Console.ReadLine();
        
        Console.WriteLine($"Welcome {name}");
    }
}
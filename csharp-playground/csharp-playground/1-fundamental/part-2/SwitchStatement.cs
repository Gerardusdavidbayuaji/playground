namespace csharp_playground._1_fundamental.part_2;

public class SwitchStatement
{
    public static void Run()
    {
        Console.WriteLine("Are you enjoying learning? (Yes/No)");
        string input = Console.ReadLine();

        switch (input)
        {
            case "Yes": Console.WriteLine("This is very good"); break;
            case "No": Console.WriteLine("Ups, so sorry :("); break;
        }
    }
}
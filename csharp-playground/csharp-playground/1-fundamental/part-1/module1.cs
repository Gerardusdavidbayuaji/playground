namespace csharp_playground._1_fundamental.part_1;

public class module1
{
    public static void Run()
    {
        // tipe data integer => angka bulat standar
        // tipe data float => angka desimal dengan ukuran 4 byte 6-9 digit
        // tipe data double => angka desimal dengan ukuran 8 byte 15-17 digit
        // tipe data decimal => angka decimal dengan ukuran 16 byte 28-29 digit
        
        int x = 5; 
        double doubleNumber = 9.9;
        decimal decimalNumber = 1.000m;
        float floatNumber = 5.5f;

        string name = "Jose";
        
        bool isLearning = true;
        
        Console.WriteLine("Number x is " + x);
        Console.WriteLine("Number doubleNumber is " + doubleNumber);
        Console.WriteLine("Number decimalNumber is " + decimalNumber);
        Console.WriteLine("Number floatNumber is " + floatNumber);
        Console.WriteLine("Your name is " + name);
        Console.WriteLine("You are studying? " + isLearning);
    }
}
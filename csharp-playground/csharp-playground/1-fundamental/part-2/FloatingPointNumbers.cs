namespace csharp_playground._1_fundamental.part_2;

public class FloatingPointNumbers
{
    public static void Run()
    {
        // tipe data float => angka desimal dengan ukuran 4 byte 6-9 digit
        // tipe data double => angka desimal dengan ukuran 8 byte 15-17 digit
        // tipe data decimal => angka decimal dengan ukuran 16 byte 28-29 digit
        
        float floatNumber = 0.0f;
        double doubleNumber = 0.0f;
        decimal decimalNumber = 0.0m;

        floatNumber = 1 / 3f;
        doubleNumber = 1 / 3d;
        decimalNumber = 1 / 3m;
        
        Console.WriteLine($"Float no is {floatNumber}");
        Console.WriteLine($"Double no is {doubleNumber}");
        Console.WriteLine($"Decimal no is {decimalNumber}");
    }
}
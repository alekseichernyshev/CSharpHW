using static MyLibrary;
using static System.Console;

public class ThirdTask
{
    public static void Task38()
    {
        int[] ar = CreateArray(5);
        Fill2(ar);
        int diff = DiffMinMax(ar);
        Console.WriteLine($"{Print2(ar)} => {diff}");
    }
}
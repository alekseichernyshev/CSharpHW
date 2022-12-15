using static MyLibrary;
using static System.Console;

public class SecondTask
{
    public static void Task36()
    {
    int[] ar = CreateArray(5);
    Fill2(ar);
    int sum = SumNotEvenIndex(ar);
    Console.WriteLine($"{Print2(ar)} => {sum}");
    }
}
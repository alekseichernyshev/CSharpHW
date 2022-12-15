using static MyLibrary;
using static System.Console;

public class HW4
{
    public static void Task34()
    {
        //создать массив
        int[] ar = CreateArray(4);
        //заполнить массив трёхзначными числами
        Fill(ar);
        
        // отобразить количество чётных чисел в массиве
        int result = CountEven(ar);
        Console.WriteLine($"{Print2(ar)} => {result}");


    }
}


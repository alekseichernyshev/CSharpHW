
using static MyLibrary;
using static System.Console;

public class Hw3
{
  public static void Task29()
  {
    int[] ar = CreateArray(5);
    Fill(ar);
    // Console.WriteLine(Print(ar));
    int dec = ToDec(ar);
    WriteLine($"{Print(ar)} => {dec}");
  }
}
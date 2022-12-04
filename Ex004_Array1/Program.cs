//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int[] array = new int[3];
Console.WriteLine("Введите число по одной цифре, нажимая после каждой клавишу Enter");
for (int i =0; i<3; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("второй элемент числа");
Console.WriteLine(array[1]);


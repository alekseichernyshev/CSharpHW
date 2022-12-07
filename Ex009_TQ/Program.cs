//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Пожалуйста, введите число и нажмите клавишу Enter\t");
int number = int.Parse(Console.ReadLine());
Console.Write("Таблица кубов для числа\t");
Console.WriteLine(number);

for (int i = 1; i < number + 1; i++)
{
    Console.WriteLine(i * i * i);
}
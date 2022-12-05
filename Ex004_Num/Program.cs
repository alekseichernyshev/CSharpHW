// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Пожалуйста, введите трёхзначное число и нажмите клавишу Enter\t");
int number = int.Parse(Console.ReadLine());
if (number > 99 && number < 1000)
{
    Console.WriteLine((number / 10) % 10);
}
else
{
    Console.WriteLine("Error");
}
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Пожалуйста, введите пяти значное число и нажмите клавишу Enter\t");
int number = int.Parse(Console.ReadLine());

if(number > 999 && number < 100000)
{
    int numA = number / 10000 % 10;
    int numB = number / 1000 % 10;
    int numC = number / 10 % 10;
    int numD = number % 10;
    Console.WriteLine(numD);
    if(numA == numD && numB == numC)
    {
        Console.WriteLine("Данное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Данное число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Error");
}
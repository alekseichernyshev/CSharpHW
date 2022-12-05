// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Пожалуйста, число и нажмите клавишу Enter\t");
int number = int.Parse(Console.ReadLine());
if (number > 99)
{
    int num = (int)Math.Floor(Math.Log10(number))-2;
    int num2 = (int)Math.Pow(10, num);
    Console.WriteLine((number / num2 % 10) % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

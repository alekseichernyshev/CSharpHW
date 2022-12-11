// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Строки использовать нельззя

Console.WriteLine("Введите число\t");
int number = int.Parse(Console.ReadLine());
int sum = 0;
//if (number < 0)
//{
//    number *= -1;   // делаем число положительным
//}

while (number != 0)
{
    sum += number % 10;
    number /= 10;
}

Console.WriteLine(sum);
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow

Console.WriteLine("Введите первое натуральное число и нажмите клавишу Enter \t");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число и нажмите клавишу Enter \t");
int numberB = int.Parse(Console.ReadLine());
int result = numberA;
if(numberA>0 && numberB>0){
for (int count = 2; count <= numberB; count++)
{
    result = result * numberA;
}
Console.WriteLine(result);
}
else{
    Console.WriteLine("Вы ввели не натуральное число");
}
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Пожалуйста, введите количество знаков в Вашем числе, затем нажмите клавишу Enter\t");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];

for(int i = 0; i<array.Length; i++)
{
    Console.Write("Пожалуйста, введите цифру\t");
    array[i] = int.Parse(Console.ReadLine());
}

if(size>2)
{
    Console.WriteLine("Третья цифра заданного числа равна:");
    Console.WriteLine(array[2]);
}
else
{
    Console.WriteLine("В данном числе третьей цифры нет");
}
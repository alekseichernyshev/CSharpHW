


Console.WriteLine("Пожалуйста, введите цифру от 1 до 7 и нажмите клавишу Enter\t");
int number = int.Parse(Console.ReadLine());

if (number > 0 && number < 8)
{
    if (number > 5)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Будний день");
    }
}
else
{
    Console.WriteLine("Увы, такого дня недели не существует");
}
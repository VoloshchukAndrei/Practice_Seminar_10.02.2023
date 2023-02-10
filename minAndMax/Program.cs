Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);
if (numberA > numberB)
{
    Console.Write("Минимальное число: " + numberA + "Максимальное число: " + numberB);
}
else
{
    Console.Write("Минимальное число: " + numberB + "Максимальное число: " + numberA);
}

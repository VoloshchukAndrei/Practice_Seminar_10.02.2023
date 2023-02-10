Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);
if (numberA > numberB)
{
    Console.WriteLine("Минимальное число: " + numberB +", " + "Максимальное число: " + numberA);
}
else
{
    Console.WriteLine("Минимальное число: " + numberA +", " + "Максимальное число: " + numberB);
}

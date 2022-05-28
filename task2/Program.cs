Console.Write("Введите число numberA: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число numberB: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA == numberB * numberB) ;
{
    Console.Write("Да, первое число является квадратом второго");
}
else
{
    Console.Write("Нет, первое число не является квадратом второго");
}
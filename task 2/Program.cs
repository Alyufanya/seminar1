// проверять квадрат по двум заданным числам
Console.Write("Введите число numbera ");
int numbera = int.Parse(Console.ReadLine());
Console.Write("Введите число numberb ");
int numberb = int.Parse(Console.ReadLine());
if (numbera == numberb*numberb)
{
    Console.Write("Да, первое число является квадратом второго");
}
else
{
    Console.Write("Нет, первое число не является квадратом второго");
}
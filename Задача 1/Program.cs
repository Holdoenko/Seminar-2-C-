//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num > 99 && Num <1000)
{
Console.Write("Вторая цифра числа - ");
Console.WriteLine((Num / 10) % 10);
}
else if (Num > - 1000 && Num < -99)
{
    Console.Write("Вторая цифра числа ");
    Console.WriteLine((Num / 10) % 10);
}
else 
{
    Console.Write("Введено не трехзначное число");
}
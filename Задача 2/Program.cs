//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 | num < -99)
{
    {
        while (num >= 1000 | num <= -1000)
        {
            num = num / 10;
        }
    }
    Console.Write("Третья цифра: ");
    Console.Write((num) % 10);
}
else
    Console.Write("Третьей цифры нет");


// P.S. Не разобрался как при выводе третьей цифры отрицательного числа убрать знак "-"  ((((

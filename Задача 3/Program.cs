//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0 && number < 6)
{
    Console.WriteLine("Рабочий день, где 1-Понедельник, 2-Вторник, 3-Среда, 4-Четверг, 5-Пятница");
}
else if(number == 6)
{
    Console.WriteLine("Выходной день, Суббота");
}
else if(number == 7)
{
    Console.WriteLine("Выходной день, Воскресенье");
}                                                       
else
Console.WriteLine("Введено не верное число");

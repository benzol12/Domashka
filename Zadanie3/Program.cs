/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write ("Введите цифру, обозначающую день недели - ");
string number = Console.ReadLine();
int week = Convert.ToInt32(number);

if (week > 7)
{
    Console.Write("В неделе 7 дней");
}
else if (week == 0)
{
    Console.Write("В неделе нет нулевого дня");
}

else
{
    if (week == 6)
    {
        Console.Write("Суббота - Выходной");
    }
    else if (week==7)
    {
        Console.Write("Воскресенье - выходной");
    }
    else
    {
        Console.Write("Рабочий день");
    }
}

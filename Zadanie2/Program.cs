/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число: ");
string number = Console.ReadLine();
int a = Convert.ToInt32(number);
if (a < 100)
{
    Console.Write($"{a}->Третьей цифры нет");
}
else
{

    while (a > 999)
    {
        a /= 10;
    }

    int result = a % 10;

    Console.Write($"{number}->{result}");
}

/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();
int a = Convert.ToInt32(number);
if (a > 1000)
{
    Console.Write("Число не трехзанчное");
}
else if (a < 100)
{
    Console.Write("Число однозначное или двухзначное");
}
else 
{
    Console.Write($"Число '{number}'");
    int result = a / 10 % 10;
    Console.Write($"Второе число '{result}'");
}
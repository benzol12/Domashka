/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число ");
string str = Console.ReadLine();
int number1 = Convert.ToInt32(str);


int sum (int number1)
{
    int i = 0;
    while (number1 > 0)
    {
        i += number1 % 10;
        number1 /= 10; 
    }
    return i;
}
Console.Write(sum(number1));

// так и не понял в чем ошибка 



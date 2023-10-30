/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Write("Введите число ");
string string1 = Console.ReadLine();
int number1 = Convert.ToInt32(string1);
Console.Write("Введите степень ");
string string2 = Console.ReadLine();
int number2 = Convert.ToInt32(string2);

bool check (int number2)
{
    if (number2 <= 0)
    {
        Console.WriteLine ("Введите число больше нуля");
        return false;
    }
    
        return true;
    
}
//if (check == true) 

if (check(number2)) 
{
    double Power = Math.Pow (number1, number2);
    Console.Write($"Результат {Power}");
}



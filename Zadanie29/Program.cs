/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/*
int length = Console.ReadLine();
int[] array = new int[length]; 
Random random = new Random();
for (int i = 0; i < length; i++)
{
    Console.WriteLine("Введите минимальное число ");
    int min = Console.ReadLine();

    Console.WriteLine("Введите максимальное число ");
    int max = Console.ReadLine();

    array[i] = random.Next(min, max + 1);
}
Console.WriteLine (array);
*/



Console.WriteLine ("Укажите размер массива");
int len = int.Parse(Console.ReadLine());
int[] array = new  array(len);


 for (int i = 0; i < len; i++);
 {
    array[i] = new Random().Next(1, 10);
 }

 Console.Write (" ");

 for (int i = 0; i < array.Length-1; i++)
  {
    Console.Write($"{array[i]}, ");
  }
  Console.Write($"{array[array.Length-1]}");

  // Задача не решена. 
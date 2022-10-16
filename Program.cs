// Все задачи оформляем методами!! Задача 27 решается 
// без применения строковой типизации!
// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число
//  A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.WriteLine("Введите превое число:");
// int numA = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите превое число:");
// int numB = int.Parse(Console.ReadLine());
// ToDegree(numA,numB);

// // Функция возведения в степень
// void ToDegree(int a, int b)
// {
//  int result = 1;
//  for (int i = 1; i <= b; i++)
//     {
//  result = result * a;
//     }
//  Console.WriteLine(result);
// }
 
//  Задача 27: Напишите программу, которая принимает на вход число 
//  и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Console.WriteLine("Введите число:");
// int number = int.Parse(Console.ReadLine());
// int len = NumberLen(number);
// SumNumbers(number, len);
// // Функция подсчета цифр в числе
// int NumberLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }
// // Функция вывода суммы цифр в числе
// void SumNumbers(int n, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine(sum);
// }
// Задача 29: Напишите программу, которая задаёт массив из 8 
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
// 6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]
int[] Array01 = new int[8];
int length = Array01.Length;
for (int i = 0; i < length; i++)
{
    Array01[i] = new Random().Next(0,999);
    Console.Write($"{Array01[i]},");
}
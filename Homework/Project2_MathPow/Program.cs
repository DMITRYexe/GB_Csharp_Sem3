// 33. Возведите число А в натуральную степень B используя цикл
using System;
Console.WriteLine("Привет! Данная программа возводит одно число в степень другого, пока вы не нажмете любую клавишу");
Console.WriteLine("Введите число: ");
double A = Convert.ToDouble(Console.ReadLine());
Start:
Console.WriteLine("Введите натуральную степень: ");
int B = Convert.ToInt32(Console.ReadLine());
if (B < 0)
{
   Console.WriteLine("Степень должна быть целым числом больше нуля");
   goto Start;
}
do
{
   Console.WriteLine($"{Math.Pow(A,B)}"); // довольно странное условие, можно интерпретировать его по разному. Решил сделать так.
} while (!Console.KeyAvailable) ; // остановка по нажатию клавиши
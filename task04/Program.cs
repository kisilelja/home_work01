﻿// Показать четные числа от 1 до N
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int min = 2;
while (min <= N)
{
    Console.Write(min);
    Console.Write(", ");
    min = min + 2 ;
}

﻿//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
/*
for(int i = 0; i <= number; i++)
{
    sum = i;
}
Console.WriteLine("Otvet: " + sum); */

 while (number > 0)
{
    sum = sum + number % 10;
    number = number /10 ;
}
 Console.WriteLine(sum);
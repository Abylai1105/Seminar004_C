// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for(int i = 1; i <= number; i++)
{
    sum += i;
}

Console.WriteLine("Otvet: " + sum);
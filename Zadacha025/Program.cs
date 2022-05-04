// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
 
Console.Write("Введите число   : ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень : ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 1;
for(int i=0; i<n; i++)
{
     sum *= num;
}
Console.WriteLine($"{num} ^ {n} = {sum}");

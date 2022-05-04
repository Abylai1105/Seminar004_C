// Задача 29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] mas = new int[8];
Random n = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = n.Next(0, 100);
    Console.Write(mas[i] + " ");
}

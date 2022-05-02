// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе
Console.Write("Введите число ");
string number = Console.ReadLine();
/*
int count = number.Length;
Console.WriteLine(count);
*/

int result = 0;
for(int i = 0; i < number.Length; i++)
{
    result++;
}

Console.WriteLine("Otvet: " + result);

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе
Console.Write("Введите число ");
/*
string number = Console.ReadLine();
/*
int count = number.Length;   // Первый способ
Console.WriteLine(count);
*/

/*
string number = Console.ReadLine();
int result = 0;
for(int i = 0; i < number.Length; i++)  // Второй способ
{
    result++;
}

Console.WriteLine("Otvet: " + result);
*/

int number = Convert.ToInt32(Console.ReadLine());
int index = 0;
while (number != 0)
{
    number = number / 10;
    index++;
}
Console.WriteLine(index);
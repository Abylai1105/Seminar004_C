Console.Write("Введите число ");
int fact = Convert.ToInt32(Console.ReadLine());

int sum = 1;

for(int i = 1; i <= fact; i++)
{
    sum *= i;
}

Console.WriteLine("Otvet: " + sum);
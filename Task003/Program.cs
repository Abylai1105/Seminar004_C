Console.Write("Введите число ");
int fact = Convert.ToInt32(Console.ReadLine());
// Первое решение
/*
int sum = 1;

for(int i = 1; i <= fact; i++)
{
    sum *= i;
}
Console.WriteLine("Otvet: " + sum);*/

// Второе решение

int result =1;
int index = 1;
while (index <= fact)
{
    result = result * index;
    index++;
}
Console.WriteLine(result);

// Третье решение
/*
int result =1;
int index = 1;
do
{
    result = result * index;
    index++;
}  while (index <= fact);
Console.WriteLine(result); */
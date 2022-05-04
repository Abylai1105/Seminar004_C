// int[] numbers;
// int[] nums = new int[8];

int[] mas = new int[8];
Random n = new Random();
for (int i = 0; i < mas.Length; i++)
{
mas[i] = n.Next(0, 100);
Console.Write(mas[i] + " ");
}

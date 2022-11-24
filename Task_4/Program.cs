Console.Write("Введите число: ");
int one = Convert.ToInt32(Console.ReadLine());
int two = 0;
for (int count = 1; count < one; count++)
{
    B = count;
    if (count % 2 == 0)
    {
        Console.Write($"{count}, ");
    }
}
if (two < 2)
{
    Console.Write($"Четных чисел перед числом {one} нет!");
}

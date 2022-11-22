Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = 0;
for (int count = 1; count < A; count++)
{
    B = count;
    if (count % 2 == 0)
    {
        Console.Write($"{count}, ");
    }
}
if (B < 2)
{
    Console.Write($"Четных чисел перед числом {A} нет!");
}
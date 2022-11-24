Console.Write("Введите число: ");
int one = Convert.ToInt32(Console.ReadLine());

if (Convert.ToBoolean(one % 2)==false)
{
    Console.WriteLine($"Число {one} четное.");
}
else
{
    Console.WriteLine($"Число {one} не четное.");
}

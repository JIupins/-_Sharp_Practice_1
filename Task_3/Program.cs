Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

if (Convert.ToBoolean(A%2)==false)
{
    Console.WriteLine($"Число {A} четное.");
}
else
{
    Console.WriteLine($"Число {A} не четное.");
}
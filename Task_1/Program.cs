Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine());
int T = Math.Max(A,B);
Console.WriteLine($"Максимальным из чисел {A} и {B} является: {T}");
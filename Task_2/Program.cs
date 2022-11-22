Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int C = int.Parse(Console.ReadLine());
int T = Math.Max(Math.Max(A,B),C);
Console.WriteLine($"Максимальным из чисел {A}, {B} и {C} является: {T}");

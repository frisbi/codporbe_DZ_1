Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    Console.Write($"Число {numA} является максимальным, а число {numB} минимальным");
}
else
{
    Console.Write($"Число {numB} является максимальным, а число {numA} минимальным");
}

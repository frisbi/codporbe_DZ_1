Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());

if (numA % 2 == 0 )
{
    Console.Write($"Число {numA} является четным числом");
}
else
{
    Console.Write($"Число {numA} является не четным числом");
}

Console.Write("Введите число больше 1, до которого включительно ведем перечисление четных чисел: ");
int numA = Convert.ToInt32(Console.ReadLine());

int count = 1;

if (numA < 1)
{
  Console.WriteLine($"Введено неверное число");  
}

else
{

    while (count <= numA)
    {
        if(count % 2 == 0)

        Console.WriteLine($"Четные числа до {numA} включительно: {count}");
        count++;
    }
}

void InterNumbers(int m, int n)
{    
    if(m <= n)
    {
        Console.Write(m + " ");
        InterNumbers(m + 1, n);
    }
}

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.Write("Натуральные числа от {0} до {1}: ", numberM, numberN);
InterNumbers(numberM, numberN);

int Ackermann(int m, int n)
{    
    if(m == 0) return n + 1;
    if(m > 0 && n == 0) return Ackermann(m - 1, 1);
    return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("A({0},{1}) = {2}", numberM, numberN, Ackermann(numberM, numberN));

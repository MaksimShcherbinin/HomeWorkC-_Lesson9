﻿int InterNumbers(int m, int n)
{    
    int resoult = 0;
    if(m <= n)
        resoult = m + InterNumbers(m + 1, n);
    return resoult;
}

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(InterNumbers(numberM, numberN));

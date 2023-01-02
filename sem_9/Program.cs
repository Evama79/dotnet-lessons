/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
using System;

public class Program
{
    public static long Ackermann(long m, long n)
    {
        if(m > 0)
        {
            if (n > 0)
                return Ackermann(m - 1, Ackermann(m, n - 1));
            else if (n == 0)
                return Ackermann(m - 1, 1);
        }
        else if(m == 0)
        {
            if(n >= 0) 
                return n + 1;
        }

        throw new System.ArgumentOutOfRangeException();
    }
	public static int PrintNumber(int m, int n)
	{
		if(m == n+1) {
			return 0;	
		}

		int start = m;
		int end = n;
		if (start > end)
		{
			start = n;
			end = m;
		}

		// 1 -> 5
		Console.WriteLine("{0}", end);
		if (start <= end + 1)
		{
			end--;
			PrintNumber(start, end);
		}
        return 0;
    }

	public static void Sum(int m, int n, int sum)
	{
		if(m == n+1) {
			Console.WriteLine("Current sum: {0}", sum);	
		}

		int start = m;
		int end = n;
		// 1 -> 5
        //Console.WriteLine($"{start}, {end}");
		if (start <= end + 1)
		{
            //Console.WriteLine("Hit the condition");
			sum += end;
            //Console.WriteLine("Current sum: {0}", sum);
			end--;
            Sum(start, end, sum);
		}
	}

	public static void Main(string[] args)
	{
		//PrintNumber(1, 10);
        Sum(1,10,0);
        Console.WriteLine(Ackermann(3,2));
	}
}
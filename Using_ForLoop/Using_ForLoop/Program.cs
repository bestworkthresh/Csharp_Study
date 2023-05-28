// See https://aka.ms/new-console-template for more information




//Console.WriteLine("Hello, World!");




//原本作法

//int sum = 1+2+3+4+5+6+7+8+9+10;
//int sum = 0;
//sum += 1;
//sum += 2;
//sum += 3;
//sum += 4;
//sum += 5;
//sum += 6;
//sum += 7;
//sum += 8;
//sum += 9;
//sum += 10;
//Console.WriteLine(sum);

using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    { 
        int i;
        int sum = 0;
        for (i = 1; i <= 100; ++i) 
        {
            sum += i ; 
        }
        Console.WriteLine("1~100的總和為"+sum);
    }
}


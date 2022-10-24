
/*
 * UsingMathOperator
 * Thresh
 * 20221024
 */


using System;
namespace usingvarvables;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("請輸入第一個整數值x：");
        double x = double.Parse(Console.ReadLine()); //Parse可以稱做剖析
        
        Console.WriteLine("請輸入第二個整數值Y：");
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine("x + y = {0}",x + y);
        Console.WriteLine("x + y = ", x + y);

        Console.WriteLine("x - y = {0}", x - y);
        Console.WriteLine("x * y = {0}", x * y);
        Console.WriteLine("x / y = {0} 兩個整數如果相除，得到商", x / y);// 兩個整數如果相除，得到商
        Console.WriteLine("x % y = {0} 兩個整數如果相除，得到餘數", x % y);//兩個整數如果相除，得到餘數

        //錯誤示範
        byte bValue = 254;
        bValue = bValue*2;
    }

}


/*
 * UsingMathFunctions
 * Thresh
 * 20221024
 */


using System;
namespace usingvarvables;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("sqrt(2) = " + Math.Sqrt(2.0));
        Console.WriteLine("PI = " + Math.PI);
        Console.WriteLine("Sin(PI/6.0) = " + Math.Sin(Math.PI / 6.0));
        Console.WriteLine("Pow(2.0 , 0.5) = " + Math.Pow(2.0, 0.5)); //密次方 
        Console.WriteLine("Exp(1) = " + Math.Exp(1.0));
        Console.WriteLine("In (e) = " + Math.Log(Math.E));
        Console.WriteLine("Log10(100) = " + Math.Log10(100.0));




        //常數
        const double G = 9.8; //const 可以幫你抓出任何地方要去異動G的值，他就會報錯。
        Console.WriteLine("常數G = {0} ", G);
        double t = 1.0;
        double y = -(1.0/2.0)* G * t * t ;
        G = 9.8 / 6; //Error! 

    }

}

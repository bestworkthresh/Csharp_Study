/*
 * UsingVariable
 * Thresh
 * 20221023
 */


using System;
namespace usingvarvables;

class Program
{
    static void Main(string[] args)
    {
        int a  = 10;
        double b = 0;
        Console.WriteLine(b = a);

        //Console.WriteLine(a = b);

        b = 20.5;
        a = (int)b;

        float c = 20;
        c = 20.5f;
        c = (float)20.5;
        Console.WriteLine(c = a);

        char d = (char)65;




    }

}

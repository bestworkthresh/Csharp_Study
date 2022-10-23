/*
 * UsingVariable
 * Thresh
 * 20221014
 */


using System;
namespace usingvarvables;
 
    class Program
    {
        static void Main(string[] args)
        { 
        char aChar = 'a';
        Console.WriteLine(aChar);

        int anInt = 123123;
        Console.WriteLine(anInt);

        //double aDouble ;
        //aDouble = 1231.123;
        double aDouble = 1231.123;
        Console.WriteLine(aDouble);

        bool aBool = true;
        Console.WriteLine(aBool);

        int x = 256;
        Console.WriteLine("x："+x);

        int y = 255;
        Console.WriteLine("y："+y);

        double z = 123.45;
        Console.Write("z：" + z);

        float f = 123.45f;
        Console.WriteLine("f：" + f);

        decimal d = 123.45m;
        Console.WriteLine("d：" + d);

        char c1 =  'a';
        Console.WriteLine("c1：" + c1);

        char c2 = '文';
        Console.WriteLine("c2：" + c2);

        char c3 = '\x0059';
        Console.WriteLine("c3：" + c3);

        char c4= '\u0059';
        Console.WriteLine("c4：" + c4);

        char c5 = '\n';
        Console.WriteLine("c5：" + c5);

        char c6 = '\'';
        Console.WriteLine("c6：" + c6);

        char c7 = '\\';
        Console.WriteLine("c7：" + c7);


    }

}

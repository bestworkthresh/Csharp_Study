
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

        //錯誤示範，因為byte最大只能放到255，所以放254沒問題，但下面*2就會溢位了。
        byte bValue = 254;
        bValue = bValue*2;


        // 關於位元錯誤，INT是64位元，但BYTE只有8位元。
        byte bValue;
        int aa = 0;
        bValue = aa + 0;

        //第三種也是類似情況，但老師講的0.1那段有夠難懂，真的要去找資料來看，
        //簡單來說0.1就是一個無窮小數所以會完整佔滿64位元(因為他是浮點數)，但F那邊宣告為float 是32位元的。

        float f = 0;
        f = 0.1 + 0.1;



    }

}

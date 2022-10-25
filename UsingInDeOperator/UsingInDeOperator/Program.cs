
/*
 * UsingInDeOperator
 * Thresh
 * 20221025
 */


using System;
namespace usingvarvables;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("請輸入整數變數x初值");
        int x0 = int.Parse(Console.ReadLine());
        Console.WriteLine("請輸入所要加總的整數值add");
        int add = int.Parse(Console.ReadLine());

        //沒有優化的結果
        int x = x0; //取上面的值
        x = x + add; // 變數邏輯，塞回原位會比較快，跟機器語言底層運行有關。

        //稍加優化的結果
        x = x0;
        x += add;//+= 等於x= x+add的意思
        Console.WriteLine("x = x + add結果為" + x);
        Console.WriteLine("x += add結果為" + x + "\n");

        int post;
        x = x0;
        post = x++; //把x的內容+1 然後再放回post裡面去。

        Console.WriteLine("post = x++後，post結果為" + post);
        Console.WriteLine("post = x++後，x結果為" + x + "\n");
        
        
        int pre;
        x = x0;
        pre = ++x; // 把x的內容 + 1 然後再放回pre裡面去。
        Console.WriteLine("pre = ++x後，pre結果為" + x);
        Console.WriteLine("pre = ++x後，x結果為" + x);


    }

}

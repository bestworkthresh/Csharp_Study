﻿/*
 * 20221030 使用IF判斷
 * Thresh 
 */

Console.WriteLine("請輸入小於100的小數整數(第一種");
int core = int.Parse(Console.ReadLine());

if (core < 60)
{
   core = core + 10 ;
   Console.WriteLine("調整後成績為" + core);
}
Console.WriteLine("原始分數" + core);

Console.WriteLine("\n");

Console.WriteLine("請輸入小於100的小數整數(第二種");
int score = int.Parse(Console.ReadLine());
//IF的另外一種寫法，但藉由true跟false的方式來讓程式操作
int result = score < 60 ?  50 : score;
//調分
Console.WriteLine("調分後分數為"+ result);


//bool是一個可以儲存判斷結果的定義 

bool x = 3 > 4;
Console.WriteLine(x+ " = 3 > 4");

bool y = 3< 4;
Console.WriteLine(y+ "= 3< 4");

bool xORy = x | y;
Console.WriteLine(xORy+ "= x | y");

bool xANDy = x & y;
Console.WriteLine(xANDy+ "=xANDy");

bool xOy = (x & y) | (x | y);
Console.WriteLine(xOy+ "= (x & y) | (x | y)");

bool xNy = (x & y) | (x | y);
Console.WriteLine(xNy+ "= (x & y) | (x | y)");

//Short-Circuit 邏輯運算
//主要就是為了節省機器運算成本，只要第一個邏輯是False，就不做後面邏輯的判斷

bool xSCx = x && y;
Console.WriteLine(xSCx);

bool xSC2x = x || y;
Console.WriteLine(xSC2x);
//需要考慮到程式執行的副作用，這樣貿然使用Short-Circuit就有可能出現非預期情況


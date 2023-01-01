/*
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
//IF的另外一種寫法 
int result = score < 60 ?  50 : score;
//調分
Console.WriteLine("調分後分數為"+ result);


//bool是一個可以儲存判斷結果的定義 

bool x = 3 > 4;
bool y = 3< 4;

Console.WriteLine(x);
Console.WriteLine(y);


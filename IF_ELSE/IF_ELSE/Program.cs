
Console.WriteLine("Hello, World!");

int score = 70;
int FALL_THRESHOLD = 60;
int GOOG_THRESHOLD = 90;


if (score < FALL_THRESHOLD)
{
    Console.WriteLine("請注意，成績不及格");
}
else
{
    if (score < GOOG_THRESHOLD)
    {
        Console.WriteLine("成績中等");
    }
    else
    {
        Console.WriteLine("成績優良");
    }
}



//注意下列兩者的Else位置，因為縮排的關係看起來對應的IF不一樣
//從人的解讀角度來看會有所不同但對於電腦來說就完全一樣 。C#的Else會看最近的IF

if (score >= 60)
    if (score >= 80)
        Console.WriteLine("成績優良");
else
        Console.WriteLine("請注意，成績不及格");

//======================================




if (score >= 60)
    if (score >= 80)
        Console.WriteLine("成績優良");
    else
        Console.WriteLine("請注意，成績不及格");


Console.WriteLine("請輸入西元年");
int y = int.Parse(Console.ReadLine());

bool isLeapYear = ((y % 4 == 0) && (y % 100 != 0)) ||
    ((y % 100 == 0) && (y % 400 != 0));
string result = (isLeapYear) ? "LeapYear" :"NotLeapYear";
Console.WriteLine(result);

// See https://aka.ms/new-console-template for more information
Console.WriteLine("請輸入成績：A,B,C,D,F：");
char grade = Console.ReadLine().ToCharArray()[0];
switch (grade)
{
    case 'A':
        Console.WriteLine("優異");
        break;
    case 'B':
        Console.WriteLine("良好");
        break;
    case 'C':
        Console.WriteLine("中等");
        break;
    case 'D':
        Console.WriteLine("尚可");
        break;
    case 'F':
        Console.WriteLine("不及格");
        break;
    default:
        Console.WriteLine("錯誤");
        break;
}



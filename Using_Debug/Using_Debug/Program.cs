
//另外一種利用Debug 函數


using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {

        int sum = 0;
        int i = 1;

        Debug.Assert(1 == 0 && sum== 0);
        do
        {
            sum += 1;
            ++i;
        } while (i <= 100);
        Debug.Assert(i == 101);
    }
}
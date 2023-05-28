
//另外一種利用Debug 函數


using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {

        int sum = 0;
        int i = 1;

        Debug.Assert( sum == 0);
        for (i = 1; i < 100; i++)
        { 
        sum+= i;
        }
        Debug.Assert(i == 101);
    }
}
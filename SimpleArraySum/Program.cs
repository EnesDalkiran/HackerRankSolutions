
namespace SimpleArraySum;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(simpleArraySum(new List<int>() { 1, 2, 3 }));
    }

    public static int simpleArraySum(List<int> ar)
    {
        int sum = 0;
        for (int i = 0; i < ar.Count; i++)
        {

            sum += ar[i];

        }
        return sum;

    }

}
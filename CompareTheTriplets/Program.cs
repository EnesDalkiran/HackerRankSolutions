namespace CompareTheTriplets;
class Program
{
    static void Main(String[] args)
    {
        compareTriplets(new List<int> { 1, 2, 3 }, new List<int> { 1, 2, 3 });
    }

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int apoint = 0;
        int bpoint = 0;

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                apoint++;
            }
            else if (b[i] > a[i])
            {
                bpoint++;
            }
        }
        return new List<int> { apoint, bpoint };
    }

}





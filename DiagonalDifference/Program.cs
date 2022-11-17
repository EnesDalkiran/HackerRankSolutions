namespace DiagonalDifference;
class Program
{

    public static int diagonalDifference(List<List<int>> arr)
    {
        int sum = 0;
        int sum2 = 0; ;
        for (int i = 0; i < arr.Count; i++)
        {
            sum += arr[i][i];
            sum2 += arr[i][(arr.Count - 1) - i];

        }
        return Math.Abs(sum - sum2);
    }
}

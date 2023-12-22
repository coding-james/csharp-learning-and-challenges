namespace Sandbox.Codewars.kyu8
{
    public class SumOfPositive
    {
        public static int PositiveSum(int[] arr)
        {
            int total = 0;
            foreach (int n in arr)
            {
                if (n > 0)
                {
                    total += n;
                }
            }

            return total;
        }
    }
}
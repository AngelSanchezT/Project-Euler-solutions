namespace ProjectEulerSolutions.EulerProblems
{
    public class Problem001
    {
        public static int Solution(int len)
        {
            int sum = 0;
            for (int i = 0; i < len; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }
            return sum;
        }
    }
}

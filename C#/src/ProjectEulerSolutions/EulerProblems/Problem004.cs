namespace ProjectEulerSolutions.EulerProblems
{
    public class Problem004
    {
        public static long Solution(int len)
        {
            string num = new string('9', len);

            long palindrome = 0;
            for (long num1 = long.Parse(num); num1 > 0; num1--)
            {
                for (long num2 = long.Parse(num); num2 > 0; num2--)
                {
                    long product = num1 * num2;

                    if (IsPalindrome(product))
                    {
                        if (palindrome < product)
                        {
                            palindrome = product;
                        }
                    }
                }
            }

            return palindrome;
        }

        public static bool IsPalindrome(long num)
        {
            string strNum = num.ToString();

            for (int i = 0; i < strNum.Length / 2; i++)
            {
                if (strNum[i] != strNum[strNum.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

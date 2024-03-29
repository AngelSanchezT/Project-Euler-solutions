namespace ProjectEulerSolutions.EulerProblems
{
    public class Problem002
    {
        public static int Solution(int len)
        {
            int sum = 2;
            int num1 = 1;
            int num2 = 2;
            int fibonacci = num1 + num2;
            
            while (fibonacci < len)
            {
                num1 = num2;
                num2 = fibonacci;

                fibonacci = num1 + num2;

                if (fibonacci % 2 == 0)
                {
                    sum += fibonacci;
                }
            }

            return sum;
        }
    }
}

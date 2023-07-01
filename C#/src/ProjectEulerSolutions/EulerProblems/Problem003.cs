using System;
namespace ProjectEulerSolutions.EulerProblems
{
    public class Problem003
    {
        public static long Solution(double len)
        {
            long primeFactor = 0;
            double maxFactor = Math.Sqrt(len);
            
            for (long i = 1; i < maxFactor; i++)
            {
                if (len % i == 0)
                {
                    bool isPrime = true;
                    double maxFactorPrime = Math.Sqrt(i);
                    
                    for (long j = 2; j < maxFactorPrime; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    
                    if (isPrime && len % i == 0)
                    {
                        primeFactor = i;
                    }
                }
            }
            
            return primeFactor;
        }
    }
}

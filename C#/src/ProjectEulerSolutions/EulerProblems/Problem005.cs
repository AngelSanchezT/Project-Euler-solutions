using System;
using System.Collections.Generic;

namespace ProjectEulerSolutions.EulerProblems
{
    public class Problem005
    {
        public static Dictionary<long, long> Prime(long len)
        {
            Dictionary<long, long> listPrime = new Dictionary<long, long>();

            for (long i = 1; i < len; i++)
            {
                if (IsPrime(i))
                {
                    listPrime.Add(i, 0L);
                }
            }

            return listPrime;
        }

        public static bool IsPrime(long num)
        {
            if (num == 1L)
            {
                return true;
            }

            for (long i = 2; i <= num; i++)
            {
                if (num % i == 0 && i < num)
                {
                    return false;
                }
            }

            return true;
        }

        public static Dictionary<long, long> Factor(long num, long[] primes)
        {
            Dictionary<long, long> _primes = new Dictionary<long, long>();

            for (int i = 0; i < primes.Length; i++)
            {
                while (num % primes[i] == 0 && primes[i] != 1)
                {
                    long factor;
                    if (_primes.TryGetValue(primes[i], out factor))
                    {
                        factor++;
                    }
                    else
                    {
                        factor = 1L;
                    }

                    _primes[primes[i]] = factor;

                    num = num / primes[i];
                }
            }

            return _primes;
        }

        public static long Solution(long min, long max)
        {
            double factor = 1;
            Dictionary<long, long> _primes = Prime(max);
            long[] primes = new List<long>(_primes.Keys).ToArray();

            for (long i = min; i <= max; i++)
            {
                Dictionary<long, long> map = Factor(i, primes);

                for (int j = 0; j < primes.Length; j++)
                {
                    if (map.TryGetValue(primes[j], out long mapValue))
                    {
                        if (_primes.TryGetValue(primes[j], out long primeValue) && primeValue < mapValue)
                        {
                            _primes[primes[j]] = mapValue;
                        }
                    }
                }
            }

            Console.WriteLine("primes: " + string.Join(", ", _primes));

            for (int j = 0; j < primes.Length; j++)
            {
                if (_primes[primes[j]] != 0L)
                {
                    factor *= Math.Pow(Convert.ToDouble(primes[j]), Convert.ToDouble(_primes[primes[j]]));
                }
            }

            return Convert.ToInt64(factor);
        }

        public static bool IsPalindrome(long num)
        {
            string _num = num.ToString();

            for (int i = 0; i < _num.Length / 2; i++)
            {
                if (_num[i] != _num[_num.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

package io.angelsanchezt.euler;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;

/* 
 * Solution to Project Euler problem 5
 * 
 * TEST
 * 
 * https://github.com/AngelSanchezT/Project-Euler-solutions
 */
public class Problem005 {

	public static Map<Long, Long> prime(long len) {
		Map<Long, Long> listPrime = new HashMap<Long, Long>();

		for (long i = 1; i < len; i++) {
			if (isPrime(i)) {
				listPrime.put(new Long(i), new Long(0L));
			}
		}

		return listPrime;
	}

	public static boolean isPrime(long num) {

		if (num == 1L) {
			return true;
		}

		for (int i = 2; i <= num; i++) {
			if (num % i == 0 && i < num) {
				return false;
			}
		}

		return true;
	}

	public static Map<Long, Long> factor(long num, Long[] primes) {
		Map<Long, Long> _primes = new HashMap<Long, Long>();

		for (int i = 0; i < primes.length; i++) {
			while (num % primes[i] == 0 && primes[i] != 1) {
				Long factor = _primes.get(primes[i]);
				if (factor == null) {
					factor = new Long(0L);
				}

				factor++;

				_primes.put(primes[i], factor);

				num = num / primes[i];
			}
		}

		return _primes;
	}

	public static long solution(long min, long max) {
		Double factor = new Double(1);
		Map<Long, Long> _primes = prime(max);
		Long[] primes = (Long[]) _primes.keySet().toArray(new Long[_primes.keySet().size()]);

		for (long i = min; i <= max; i++) {
			Map<Long, Long> map = factor(i, primes);

			for (int j = 0; j < primes.length; j++) {
				if (map.get(primes[j]) != null) {
					if (_primes.get(primes[j]).compareTo(map.get(primes[j])) == -1) {
						_primes.put(primes[j], map.get(primes[j]));
					}

				}

			}
		}

		System.out.println("primes: "+_primes);
		for (int j = 0; j < primes.length; j++) {
			if (!_primes.get(primes[j]).equals(new Long(0L))) {
				factor = factor
						* Math.pow(Double.parseDouble("" + primes[j]), Double.parseDouble("" + _primes.get(primes[j])));
			}
		}

		
		return factor.longValue();

	}

	/**
	 * 
	 * @param num
	 * @return
	 */
	public static boolean isPalindrome(long num) {
		String _num = String.valueOf(num);

		for (int i = 0; i < _num.length() / 2; i++) {
			// System.out.println(_num.charAt(i) + "==" + _num.charAt(_num.length() - 1 -
			// i));
			if (!(_num.charAt(i) == _num.charAt(_num.length() - 1 - i))) {
				return false;
			}
		}

		return true;
	}

}

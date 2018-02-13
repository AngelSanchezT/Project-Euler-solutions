package io.angelsanchezt.euler;

/* 
 * Solution to Project Euler problem 3
 * 
 * TEST
 * 
 * https://github.com/AngelSanchezT/Project-Euler-solutions
 */
public class Problem003 {

	public static long solution(double len) {

		long primeFactor = 0;
		double maxFactor = Math.sqrt(len);
		for (long i = 1; i < (maxFactor); i++) {

			if (len % i == 0) {
				boolean isPrime = true;
				double maxFactorPrime = Math.sqrt(i);
				for (long j = 2; j < maxFactorPrime; j++) {
					if (i % j == 0) {
						isPrime = false;
					}
				}

				if (isPrime && len % i == 0) {
					// System.out.println(i);
					primeFactor = i;
				}

				//System.out.println(i);

			}

		}
		return primeFactor;
	}

}

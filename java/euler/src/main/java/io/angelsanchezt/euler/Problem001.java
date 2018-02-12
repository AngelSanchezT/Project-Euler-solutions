package io.angelsanchezt.euler;


/* 
 * Solution to Project Euler problem 1
 * 
 * https://github.com/AngelSanchezT/Project-Euler-solutions
 */
public class Problem001 {

	public static int solution(int len) {
		int sum = 0;
		for (int i = 0; i < len; i++) {
			if (i % 3 == 0 || i % 5 == 0)
				sum += i;
		}
		return sum;
	}

}

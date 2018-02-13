package io.angelsanchezt.euler;

/* 
 * Solution to Project Euler problem 2
 * 
 * TEST
 * 
 * https://github.com/AngelSanchezT/Project-Euler-solutions
 */
public class Problem002 {

	public static int solution(int len) {
		int sum = 2;
		int num1 = 1;
		int num2 = 2;
		int fibonacci = num1 + num2;
		while (fibonacci < len) {
			num1 = num2;
			num2 = fibonacci;
			
			fibonacci = num1 + num2;
			
			if (fibonacci % 2 == 0) {
				sum += fibonacci;
			}
		}

		return sum;
	}

}

package io.angelsanchezt.euler;

/* 
 * Solution to Project Euler problem 4
 * 
 * TEST
 * 
 * https://github.com/AngelSanchezT/Project-Euler-solutions
 */
public class Problem004 {

	public static long solution(int len) {
		String _num = "";
		for(int i = 0; i<len; i++) {
			_num += "9";
		}
		
		long palindrome = 0; 
		for (long num1 = Long.parseLong(_num); num1 > 0; num1--) {
		
			for(long num2 = Long.parseLong(_num); num2 > 0; num2--) {
				long product = num1 * num2;

				if (isPalindrome(product)) {
					// System.out.println(num1 + " * " + num2 + " = " + product);
					if(palindrome < product) {
						palindrome = product;						
					}
				}
			}
		}
		
		return palindrome;

	}

	/**
	 * 
	 * @param num
	 * @return
	 */
	public static boolean isPalindrome(long num) {
		String _num = String.valueOf(num);

		for (int i = 0; i < _num.length() / 2; i++) {
			//System.out.println(_num.charAt(i) + "==" + _num.charAt(_num.length() - 1 - i));
			if (!(_num.charAt(i) == _num.charAt(_num.length() - 1 - i))) {
				return false;
			}
		}

		return true;
	}

}

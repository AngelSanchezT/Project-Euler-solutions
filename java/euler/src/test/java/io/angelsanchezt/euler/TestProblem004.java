package io.angelsanchezt.euler;

import junit.framework.TestCase;

public class TestProblem004 extends TestCase {

	public void testProblem004Palindrome001() {
		assertEquals(Problem004.isPalindrome(9009L), true);
	}
	
	public void testProblem004Palindrome002() {
		assertEquals(Problem004.isPalindrome(998001L), false);
	}
	
	public void test001Problem004() {
		assertEquals(Problem004.solution(2), 9009);
	}
	
	public void test002Problem004() {
		//System.out.println("Resultado: " + Problem004.solution(3));
		assertEquals(Problem004.solution(3), 906609);
	}
	
}

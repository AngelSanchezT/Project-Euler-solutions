package io.angelsanchezt.euler;

import junit.framework.TestCase;

public class TestProblem003 extends TestCase {

	public void testProblem003_1() {
		long solution = Problem003.solution(13195L);
		System.out.println(solution);
		assertEquals(solution, 29L);
	}
	
	public void testProblem003_2() {
		long solution = Problem003.solution(600851475143L);
		System.out.println(solution);
		assertEquals(solution, 6857L);
	}
}

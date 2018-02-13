package io.angelsanchezt.euler;

import junit.framework.TestCase;

public class TestProblem002 extends TestCase {

	public void testProblem002() {
		int solution = Problem002.solution(4000000);
		assertEquals(solution, 4613732);
	  }
}

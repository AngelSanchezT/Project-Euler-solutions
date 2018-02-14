package io.angelsanchezt.euler;

import java.util.Map;

import junit.framework.TestCase;

public class TestProblem005 extends TestCase {
	
	public void test001Problem005() {
		//System.out.println(Problem005.solution(1,20));
		assertEquals(232792560L, Problem005.solution(1,20));
	}
	
	public void test002Problem005() {
		//System.out.println(Problem005.solution(1,10));
		assertEquals(2520L, Problem005.solution(1,10));
	}

	public void test001isPrime() {
		assertTrue(Problem005.isPrime(1));
	}

	public void test002isPrime() {
		assertTrue(Problem005.isPrime(2));
	}

	public void test003isPrime() {
		assertTrue(Problem005.isPrime(7));
	}

	public void test004isPrime() {
		assertFalse(Problem005.isPrime(10));
	}

	public void test005isPrime() {
		assertFalse(Problem005.isPrime(12));
	}

	public void test001Factor12() {
		Map<Long, Long> map = Problem005.prime(20);
		System.out.println(map.toString());

		Map<Long, Long> factor = Problem005.factor(1, (Long[]) map.keySet().toArray(new Long[map.keySet().size()]));
		System.out.println(factor.toString());
		factor = Problem005.factor(2, (Long[]) map.keySet().toArray(new Long[map.keySet().size()]));
		System.out.println(factor.toString());
		factor = Problem005.factor(3, (Long[]) map.keySet().toArray(new Long[map.keySet().size()]));
		System.out.println(factor.toString());
		factor = Problem005.factor(4, (Long[]) map.keySet().toArray(new Long[map.keySet().size()]));
		System.out.println(factor.toString());
		factor = Problem005.factor(5, (Long[]) map.keySet().toArray(new Long[map.keySet().size()]));
		System.out.println(factor.toString());
		factor = Problem005.factor(6, (Long[]) map.keySet().toArray(new Long[map.keySet().size()]));
		System.out.println(factor.toString());
		factor = Problem005.factor(7, (Long[]) map.keySet().toArray(new Long[map.keySet().size()]));
		System.out.println(factor.toString());
		factor = Problem005.factor(8, (Long[]) map.keySet().toArray(new Long[map.keySet().size()]));
		System.out.println(factor.toString());
		factor = Problem005.factor(9, (Long[]) map.keySet().toArray(new Long[map.keySet().size()]));
		System.out.println(factor.toString());
		factor = Problem005.factor(10, (Long[]) map.keySet().toArray(new Long[map.keySet().size()]));
		System.out.println(factor.toString());
		factor = Problem005.factor(11, (Long[]) map.keySet().toArray(new Long[map.keySet().size()]));
		System.out.println(factor.toString());
		factor = Problem005.factor(12, (Long[]) map.keySet().toArray(new Long[map.keySet().size()]));
		System.out.println(factor.toString());

	}

}

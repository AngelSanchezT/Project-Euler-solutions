const largestPalindromeProduct = require('../problems/problem004');

describe('Problem 1: Largest Palindrome Product', () => {
    test('Should largest palindrome made from the product of two 3-digit numbers.', () => {
        const expectLastgestPalindrome = 906609;
        const expectFactorA = 913;
        const expectFactorB = 993;
        const [largestPalindrome, largestPalindromeA, largestPalindromeB] = largestPalindromeProduct();

        expect(largestPalindrome).toBe(expectLastgestPalindrome);
        expect(largestPalindromeA).toBe(expectFactorA);
        expect(largestPalindromeB).toBe(expectFactorB);
        
    })
});
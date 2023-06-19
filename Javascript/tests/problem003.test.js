const largestPrimeFactor = require('../problems/problem003');

describe('Problem 3: Largest Prime Factor', () => {
    test('Should return the lasgest prime factor of the number 600851475143', () => {
        const target = 600851475143;
        const valueExpect = 6857;
        expect(largestPrimeFactor(target)).toBe(valueExpect);
    });
});
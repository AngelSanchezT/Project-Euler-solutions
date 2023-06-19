const evenFibonacciNumbers = require('../problems/problem002');

describe('Problem 2: Even Fibonacci Numbers', () => {

    test('Should return the of the even-valued terms the Fibonacci sequence.', () => {
        const target = 4000000;
        const valueExpect = 4613732;
        expect(evenFibonacciNumbers(target)).toBe(valueExpect);
    });
});
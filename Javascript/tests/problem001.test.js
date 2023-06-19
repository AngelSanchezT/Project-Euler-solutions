// import { problem001 } from '../problems/problem001';
const multiplesOf3And5 = require('../problems/problem001');


describe('Problem 1: Multiples of 3 and 5', () => {
    test('should return the sum of all multiples of 3 and 5 below the given limit 10', () => {
        const limit = 10;
        const valueExpect = 23;
        expect(multiplesOf3And5(limit)).toBe(valueExpect);
    });
    test('should return the sum of all multiples of 3 and 5 below the given limit 1000', () => {
        const limit = 1000;
        const valueExpect = 233168;
        expect(multiplesOf3And5(limit)).toBe(valueExpect);
    });
})


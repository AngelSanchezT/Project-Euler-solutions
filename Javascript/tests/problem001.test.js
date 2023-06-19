// import { problem001 } from '../problems/problem001';
const multiplesOf3And5 = require('../problems/problem001');
const limit = 10;
const valueExpect = 23;

test('Problem 1 - Sample Test Case', () => {
    expect(multiplesOf3And5(limit)).toBe(valueExpect);
});
function problem002(target) {
    let sum = 0;
    let a = 1;
    let b = 1;
    let c = a + b;

    while(c < target) {
        sum += c;
        a = b + c;
        b = c + a;
        c = a + b;
    }
    
    return sum;
}

module.exports = problem002;
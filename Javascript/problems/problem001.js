function problem001(limit) {
    let sum = 0;
    for(let i = 1; i <= limit; i ++) {
        if(i % 3 === 0 || i % 5 === 0) {
            sum += i;
        }
    }
    return sum;
}

module.exports = problem001;
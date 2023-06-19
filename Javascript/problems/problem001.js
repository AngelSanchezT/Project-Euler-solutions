function problem001(target) {
    let sum = 0;
    for(let i = 1; i < target; i ++) {
        if((i % 3 === 0) || (i % 5 === 0)) {
            sum += i;
        }
    }
    return sum;
}

module.exports = problem001;
function problem003(target) {
    let lastFactor = 1;
    if(target % 2 === 0) {
        lastFactor = 2;
        target = target / 2;
        while(n % 2 === 0){
            target = target / 2;
        }
    }
    
    let factor = 3;
    let maxFactor  = Math.sqrt(target);

    while(target > 1 && factor <= maxFactor) {
        if(target % factor === 0) {
            target = target / factor;
            lastFactor = factor;
            while(target % factor === 0) {
                target = target / factor;
            }
            maxFactor = Math.sqrt(target);
        }
        factor = factor + 2;
    }

    if(target === 1) {
        return lastFactor;
    } else {
        return target;
    }
}

module.exports = problem003;
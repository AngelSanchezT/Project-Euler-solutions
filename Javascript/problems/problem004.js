function problem004() {
    let largestPalindrome = 0;
    let largestPalindromeA = 0;
    let largestPalindromeB = 0;
    let a = 999;
    while (a >= 100) {
        b = 999;
        while (b >= a) {
            if (a * b <= largestPalindrome) {
                break; // Since a*b is always going to be too small 
            }

            if (isPalindrome(a * b)) {
                largestPalindrome = a * b;
                largestPalindromeA = a;
                largestPalindromeB = b;
            }

            b--;
        }
        a--;
    }

    return [largestPalindrome, largestPalindromeA, largestPalindromeB];
}

function isPalindrome(numberValidate) {
    let strNumber = numberValidate.toString();
    let re = /[\W_]/g;
    let lowRegStr = strNumber.toLowerCase().replace(re, '');
    let reverseStr = lowRegStr.split('').reverse().join('');
    return reverseStr === lowRegStr;

}

module.exports = problem004;
function reverseString(s: string[]): void {
    // L and R indices
    let left: number = 0;
    let right: number = s.length - 1;

    // While L < R, swap characters in string
    while (left < right) {
        let temp = s[left];
        s[left] = s[right];
        s[right] = temp;
        left++;
        right--;
    }
};
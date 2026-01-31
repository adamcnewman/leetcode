function twoSum(nums: number[], target: number): number[] {
    if (nums.length == 2) {
        return [0, 1];
    }

    let map: Map<number, number> = new Map(); // <value, index>
    for (let i: number = 0; i < nums.length; i++) {

        let temp = target - nums[i];
        if (map.has(temp)) {
            return [map.get(temp) || 0, i];
        }
        map.set(nums[i], i);
    }

    return [0, 0];
};
/**
 * @param {number[]} nums
 * @param {number} n
 * @return {number[]}
 */
var shuffle = function (nums, n) {
  let shuffled = [];
  for (let i = 0; i < n; i++) {
    shuffled.push(nums[i]);
    shuffled.push(nums[n + i]);
  }

  return shuffled;
};

var answer = shuffle([1, 2, 3, 4, 4, 3, 2, 1], 4);

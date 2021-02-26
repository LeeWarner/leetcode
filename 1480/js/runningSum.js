/**
 * @param {number[]} nums
 * @return {number[]}
 */
var runningSum = function (nums) {
  let runningSum = 0;
  let answer = [];
  for (let i = 0; i < nums.length; i++) {
    runningSum += nums[i];
    answer[i] = runningSum;
  }
  return answer;
};

console.log(runningSum([1, 2, 3, 4]));

/**
 * @param {number[][]} accounts
 * @return {number}
 */
var maximumWealth = function (accounts) {
  let max = -1;
  accounts.forEach((customer) => {
    let customerWealth = customer.reduce((a, b) => a + b, 0);
    if (customerWealth > max) {
      max = customerWealth;
    }
  });
  return max;
};

var maxWealth = maximumWealth([
  [1, 2, 3],
  [3, 2, 1],
]);

console.log(`Max Wealth is: ${maxWealth}`);

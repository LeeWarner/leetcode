/**
 * @param {string} boxes
 * @return {number[]}
 */
var minOperations = function (boxes) {
  const costPerBox = [];

  for (let i = 0; i < boxes.length; i++) {
    costPerBox[i] = calculateCost(i, boxes);
  }

  return costPerBox;
};

function calculateCost(targetBox, boxes) {
  var cost = 0;
  for (let i = 0; i < boxes.length; i++) {
    if (boxes[i] == `1`) {
      cost += Math.abs(i - targetBox);
    }
  }
  return cost;
}

console.log(minOperations('001011'));

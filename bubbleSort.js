// bubble sorts array by comparing adjacent elements and swaps them if they are not in the intended order

/*
How Bubble-sort works
We have an unsorted array arr = [ 1, 4, 2, 5, -2, 3 ] the task is to sort the array using bubble sort. 

Bubble sort compares the element from index 0 and if the 0th index is greater than 1st index then the 
values get swapped and if the 0th index is less than the 1st index then nothing happens.

then, the 1st index compares to the 2nd index then the 2nd index compares to the 3rd, and so on…
*/


// Bubble sort Implementation using Javascript

function BBSort(arr) {

    var i, j;
    var len = arr.length;
    var isSwapped = false;

    for (i = 0; i < len; i++) {
        isSwapped = false;
        console.log({ i });

        for (j = 0; j < len; j++) {
            console.log({ j });

            if (arr[j] > arr[j + 1]) {

                var temp = arr[j]
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
                console.log(arr[j], arr[j + 1]); 
                console.log(arr);
                isSwapped = true;
            }
        }
        // IF no two elements were swapped by inner loop, then break
        if (!isSwapped) {
            break;
        }
    }
    // Print the array
    return arr;
}

var arr = [243, 45, 23, 356, 3, 5346, 35, 5];
console.log(
    BBSort(arr)
);
// VISUALIZATION 

// { i: 0 }
// { j: 0 }
// 45 243
// [
//    45, 243,   23,
//   356,   3, 5346,
//    35,   5
// ]
// { j: 1 }
// 23 243
// [
//    45, 23,  243,
//   356,  3, 5346,
//    35,  5
// ]
// { j: 2 }
// { j: 3 }
// 3 356
// [
//   45,  23,  243,
//    3, 356, 5346,
//   35,   5
// ]
// { j: 4 }
// { j: 5 }
// 35 5346
// [
//     45,  23, 243,
//      3, 356,  35,
//   5346,   5
// ]
// { j: 6 }
// 5 5346
// [
//   45,   23, 243,
//    3,  356,  35,
//    5, 5346
// ]
// { j: 7 }
// { i: 1 }
// { j: 0 }
// 23 45
// [
//   23,   45, 243,
//    3,  356,  35,
//    5, 5346
// ]
// { j: 1 }
// { j: 2 }
// 3 243
// [
//    23,   45,  3,
//   243,  356, 35,
//     5, 5346
// ]
// { j: 3 }
// { j: 4 }
// 35 356
// [
//    23,   45,   3,
//   243,   35, 356,
//     5, 5346
// ]
// { j: 5 }
// 5 356
// [
//    23,   45, 3,
//   243,   35, 5,
//   356, 5346
// ]
// { j: 6 }
// { j: 7 }
// { i: 2 }
// { j: 0 }
// { j: 1 }
// 3 45
// [
//    23,    3, 45,
//   243,   35,  5,
//   356, 5346
// ]
// { j: 2 }
// { j: 3 }
// 35 243
// [
//    23,    3, 45,
//    35,  243,  5,
//   356, 5346
// ]
// { j: 4 }
// 5 243
// [
//    23,    3,  45,
//    35,    5, 243,
//   356, 5346
// ]
// { j: 5 }
// { j: 6 }
// { j: 7 }
// { i: 3 }
// { j: 0 }
// 3 23
// [
//     3,   23,  45,
//    35,    5, 243,
//   356, 5346
// ]
// { j: 1 }
// { j: 2 }
// 35 45
// [
//     3,   23,  35,
//    45,    5, 243,
//   356, 5346
// ]
// { j: 3 }
// 5 45
// [
//     3,   23,  35,
//     5,   45, 243,
//   356, 5346
// ]
// { j: 4 }
// { j: 5 }
// { j: 6 }
// { j: 7 }
// { i: 4 }
// { j: 0 }
// { j: 1 }
// { j: 2 }
// 5 35
// [
//     3,   23,   5,
//    35,   45, 243,
//   356, 5346
// ]
// { j: 3 }
// { j: 4 }
// { j: 5 }
// { j: 6 }
// { j: 7 }
// { i: 5 }
// { j: 0 }
// { j: 1 }
// 5 23
// [
// { j: 6 }
// { j: 7 }
// [
//     3,    5,  23,
//    35,   45, 243,
//   356, 5346
// ]

// Thử sức với typeof

var crush = 'Hòa';
function checkName() {
    var crush = 'Hiền';
    if (crush === 'undifined') {
        console.log("Goodbye " + crush);
    }
    else {
        console.log('Hello ' + crush);
    }
}
// checkName();

// FUNCTION SEQUENCE
// function myDisplayer(value) {
//     console.log(value);
// }

// function myCalculator(num1, num2) {
//     let sum = num1 + num2;
//     myDisplayer(sum); // callback
// }
// myCalculator(10, 10)



// USING CALLBACK

function myDisplayer(value) {
    console.log(value);
}

function Total(sum1, sum2, callback) {
    let sum = sum1 + sum2;
    callback(sum)
}

// CALLBACK TO CALL MY CRUSH
function call(value = '...') {
    console.log('call to ' + value)
}

function findNumberToCall(listNumber, callback) {
    let crush = listNumber.filter(item => item === 18);
    callback(crush);
}

findNumberToCall([19, 18, 20], call);


// CALLBACK TO REMOVE NEGATIVE NUMBER
// Create an Array
const myNumbers = [4, 1, -20, -7, 5, 9, -6];
function removeNegativeNumber(listNumber, callback) {
    let arrayPositiveNumber = [];
    for (let x of myNumbers) {
        if (callback(x)) {
            arrayPositiveNumber.push(x)
        }
    }
    return arrayPositiveNumber;
}
let positiveNumber = removeNegativeNumber(myNumbers, x => x >= 0);
console.log(positiveNumber.sort((a, b) => a - b));


function add() { //A closure is a function having access to the parent scope, even after the parent function has closed.
    let counter = 0; // private variable
    function plus() { counter += 1; return counter }
    return plus(); // call it but we also access to global scope
}

function everythingAboutMe(lastName, firstName) {
    let intro = 'Xin chào mình là: '; // private variable
    function fullName() { // closure function can use global var, params
        return intro + lastName + firstName;
    }
    return fullName();
};

let intro = everythingAboutMe('Nguyen', 'Huy');

console.log(intro);

// function as arguments

let isEven = x => x % 2 === 0;
result = [1, 2, 3, 4].filter(isEven); // function as arguments;
console.log('The even number is: ', result);


//Return Function
add = (x) => (y) => x + y;
console.log(add(10)(20))
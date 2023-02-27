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
function myDisplayer(value) {
    console.log(value);
}

function myCalculator(num1, num2) {
    let sum = num1 + num2;
    myDisplayer(sum); // callback
}
myCalculator(10, 10)

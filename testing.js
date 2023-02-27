

// apply, call, this
var person = {
    name: "James Smith",
    hello: function (thing) {
        console.log(this.name + " says hello " + thing);
    }
}

console.log(person.name);
person.hello.call({ name: 'Huy' }, 'I love you'); // call attach this to the function and call it immediately;


let helloCrush = person.hello.bind({ name: 'Hòa' }); // bind attach this into function
helloCrush('Hello');

function personContainer() {
    var person = {
        name: "James Smith",
        hello: function () {
            console.log(this.name + " says hello " + arguments[0]);
        }
    }
    person.hello.apply(person, arguments);
}
personContainer("world", "mars"); // output: "James Smith says hello mars", note: arguments[0] = "world" , arguments[1] = "mars"                                     

const smartphone = {
    brand: 'Samsung',
    run: function (version) {
        console.log(this.model + version || version[1]);
    }
}

// smartphone.run.call({ model: 'galaxy s22' }, "+");
smartphone.run.apply({ model: 'galaxy s22' }, ["1", 'hek']);

let modelSamsung = smartphone.run.bind({ model: 'xyz' }, '++');
modelSamsung();

// CLOSURE FUNCTION
const introAboutMe = () => {
    let theIntro = 'Hello mọi người: ';
    return function fullName(lastName, firstName) {
        return theIntro + lastName + firstName;
    }
}
let Intro = introAboutMe();
console.log(Intro('Nguyen', 'Huy'));



// Array

let listPerson = ['hiền', 'hòa', 'huy', 'thảo'];

// toString, join convert array to a string;
console.log(listPerson.toString());

console.log(listPerson.join('-'))

// duplicated array;
console.log(listPerson.concat(listPerson));

// remove element from the array
// const fruits = ["Banana", "Orange", "Apple", "Mango"];
// fruits.pop(); // return value from pop();
// console.log(fruits);

// const fruits = ["Banana", "Orange", "Apple", "Mango"];
// fruits.unshift("Lemon");
// console.log({ fruits });

const fruitsSplice = ["Banana", "Orange", "Apple", "Mango"];
let removefruitsSplice = fruitsSplice.splice(2, 0, 'Hello', 'Joo'); // change source array, if this has a second param the var will return the remove item;
console.log(fruitsSplice)

const fruitsSlice = ["Banana", "Orange", "Lemon", "Apple", "Mango"];
const citrus = fruitsSlice.slice(1); // create new array, don't change source array
console.log(citrus);

// SORT ARRAY

// 1- sort string

// let cars = ['Bmw', 'RollRoyce', 'Audi', 'Toyota'];
// console.log('Sorting', cars.sort());

let numberic = [10, 20, 3, 40.50, 5];
console.log(numberic.sort(function (a, b) { return b - a }));


console.log('huy'.toLowerCase() > 'boooo'.toLowerCase());

const cars = [
    { type: "Volvo", year: 2016 },
    { type: "Saab", year: 2001 },
    { type: "BMW", year: 2010 }
];

cars.sort(function (a, b) { return a.year - b.year });
console.log(cars);

const numbers = [10, 40, 30, 20, 5, 40, 3, 4, 5];
numbers.map(item => console.log(item)); // map method creates a new array by performing a function on each array elements.

let over18 = numbers.filter(item => item > 18);
console.log(over18); // creates a new array with array elements that pass a test;

let sum = numbers.reduce((total, item) => total + item, 0); // Empty array but it has initial value it will return initial value
console.log(sum);

const fruits = ["Apple", "Orange", "Apple", "Mango"];
let position = fruits.indexOf("Apple") + 1; // indexOf method searches an array for an element value and returns its position
// const fruits = ["Apple", "Orange", "Apple", "Mango"];
// let position = fruits.lastIndexOf("Apple") + 1;

const newFruits = ["Banana", "Orange", "Apple", "Mango"];
const keys = newFruits.entries();// return array itorator
for (let x of keys) {
    console.log(x);
}

function Person(first, last, age, eyecolor) {
    this.firstName = first;
    this.lastName = last;
    this.age = age;
    this.eyeColor = eyecolor;
}

Person.nationality = 'Viet Nam';

let xiaomi = {
    branch: 'Note 7',
    price: '100000',
    version: '++'
}
Person.prototype.name = function () {
    return this.firstName + " " + this.lastName;
};

const ps1 = new Person('huy', 'nguyen', 21, 'brown');

console.log(ps1.name());

// We can't add prototype in constructor function

let array1 = [1, 2, 3];
let array2 = [4, 5, 6];

Array.prototype.unshift.apply(array1, array2);
console.log({ array1 });

let array3 = [1, 2, 3];
let array4 = array3.slice();

console.log({ array4 });

// REVEAL FUNCTION
function Car(type, fuelType) {
    this.type = type;
    this.fuelType = fuelType;
}
function setBrand(brand) {
    Car.call(this, 'Convertible', 'petrol');
    this.brand = brand;
    console.log(`Car details = `, this);
}

function definePrice(price) {
    Car.call(this, 'Convertible', 'petrol');
    this.price = price;
    console.log(`Car details = `, this);
}

const newBrand = new setBrand('Audi A7 sportback');
const newPrice = new definePrice(1000000);


function mountEntity(obj) {
    this.entity = (obj) => console.log(obj);;
    console.log(`Entity ${this.entity} is mounted on ${this}`);
}

mountEntity.call(this, 'hello');



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
modelSamsung()

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


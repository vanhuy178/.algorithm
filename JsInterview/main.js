for (var i = 0; i < 6; i++) {
    console.log(i);
    setTimeout(() => {
        console.log(i)
    }, 1000);
}

console.log(new Number(3));

let a = 3;
let b = new Number(3);
let c = 3;


greetign = {}; // Giả sử bị lỗi đánh máy!
console.log(greetign);

console.log(a == b);
console.log(a === b);

function bark() {
    console.log("Woof!");
}

bark.animal = "dog";

console.log(bark);
function getPersonInfo(one, two, three) {
    console.log(one);
    console.log(two);
    console.log(three);
}

const person = "Lydia";
const age = 21;

// getPersonInfo`${person} is ${age} years old`;


function getAge(...args) {
    console.log(typeof args);
}

getAge(21); // ... will return an array


function myFunction(v, w, x, y, z) {
    console.log(v, w, x, y, z);
}
const args = [0, 1];
myFunction(-1, ...args, 2, ...[3]);


let hello = 'vui vẻ ko quạo';

hello = 'wow';

// oject key is the string type

const obj = { 1: "a", 2: "b", 3: "c" };
const set = new Set([1, 2, 3, 4, 5]);

obj.hasOwnProperty("1");
obj.hasOwnProperty(1);

set.has("1");
set.has(1);


// const obj = { a: "one", b: "two", a: "three" }; two key in object causes error
// console.log(obj); 



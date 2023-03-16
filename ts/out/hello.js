function greetter(fn) {
    fn("Hello world");
}
function printToConsole(s) {
    console.log(s);
}
greetter(printToConsole);
function doSomething(fn) {
    console.log(fn.description + " returned " + fn(6));
}
// function firstElement(arr: any[]) {
//     return arr[0];
// }
function firstElement(arr) {
    return arr[0];
}
// s is of type 'string'
const s = firstElement(["a", "b", "c"]);
// n is of type 'number'
const n = firstElement([1, 2, 3]);
// u is of type undefined
const u = firstElement([]);
function map(arr, func) {
    return arr.map(func);
}
// Parameter 'n' is of type 'string'
// 'parsed' is of type 'number[]'
const parsed = map(["1", "2", "3"], (n) => parseInt(n));
const merge = map(['2', '3', '44'], (n) => parseInt(n));
// specifying type argument
function combine(arr1, arr2) {
    return arr1.concat(arr2);
}
function comnine2(arr1, arr2) {
    return arr1.concat(arr2);
}
// const arr = combine([1,2,3], ['Hello']);
function ahihi(arr) {
    return arr;
}
function filter(arr, func) {
    return arr.filter(func);
}
function filter2(arr, func) {
    return arr.filter(func);
}
function f(x) {
    console.log(x);
}
f();
f(10);
// provide params defutl
function wowow(x = 10) {
    console.log(x);
}
fx();
fx(10);
f(undefined);
// optional params in callbacks
function myForEach(arr, callbacks) {
    for (let i = 0; i < arr.length; i++) {
        callbacks(arr[i], i);
    }
}
function myForEach_1(arr, callback) {
    for (let i = 0; i < arr.length; i++) {
        // I don't feel like providing the index today
        callback(arr[i]);
    }
}
function renderItem(arr, callback) {
    for (let i = 0; i < arr.length; i++) {
        callback(arr[i], i);
    }
}
function multipe(a, ...m) {
    return m.map(x => a * x);
}
class Shape {
    area() {
        return this.x * this.y;
    }
}
function paintShape(opts) {
    let xPos = opts.xPos === undefined ? 0 : opts.xPos;
    let yPos = opts.yPos === undefined ? 0 : opts.yPos;
}
;
function paintShape2({ shape, xPos = 0, yPos = 0 }) {
    console.log('x coornidate at', xPos);
    console.log('y coornidate at', yPos);
}
const shape = new Shape();
paintShape({ shape, xPos: 100, });
paintShape({ shape, yPos: 100, });
function doCC(obj) {
    console.log('the value is: ' + obj.prop);
    // But we can't re-assign it.
    //obj.prop = "hello"
}
function visitForBirthday(home) {
    // We can read and update properties from home.resident 
    console.log(`Happy birthday ${home.resident.age}`);
    home.resident.age++;
}
function evict(home) {
    // but we can't write to the 'resident' property itself on a "Home";
    // home.resident = {
    //     wow: 'wow',
    //     'meomeo': 'memeo'
    // }
}
let writablePerson = {
    name: "Nguyen Van Huy",
    age: 21
};
let readonlyPerson = writablePerson;
console.log(readonlyPerson.age); // prints '42'
writablePerson.age++;
console.log(readonlyPerson.age); // prints '43'
let array;
const cc = {
    color: 'red',
    radius: 42
};
// intersection types
function draw(circle) {
    console.log(`Color was ${circle.color}`);
    console.log(`Radius was ${circle.radius}`);
}
draw({ color: 'blue', radius: 42 });
let x = {
    contents: 'cc'
};
if (typeof x.contents === 'string') {
    console.log(x.contents.toLowerCase());
}
console.log(x.contents.toLocaleLowerCase());
function setContents(box, newContents) {
    box.contents = newContents;
}
let box2;
let box2a = { contents: 'hello' };
box2a.contents;
function doSt(value) {
    //
}
let myArray = ["hello", "world"];
// either of these work!
doSt(myArray);
doSt(new Array("hello", 'cc'));
//# sourceMappingURL=hello.js.map
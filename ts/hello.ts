// function type expression
type GreetFunction = (a: string) => void

function greetter(fn: GreetFunction) {
    fn("Hello world")
}

function printToConsole(s: string) {
    console.log(s);
}


greetter(printToConsole)

// call signature syntax
type DescribableFunction = {
    description: string,
    (someArg: number): boolean;
}

function doSomething(fn: DescribableFunction) {
    console.log(fn.description + " returned " + fn(6));
}

// construct signatures
interface CallOrConstruct {
    new(s: string): Date;
    (n?: number): number
}

// function firstElement(arr: any[]) {
//     return arr[0];
// }

function firstElement<Type>(arr: Type[]): Type | undefined {
    return arr[0];
}

// s is of type 'string'
const s = firstElement(["a", "b", "c"]);
// n is of type 'number'
const n = firstElement([1, 2, 3]);
// u is of type undefined
const u = firstElement([]);

function map<Input, Output>(arr: Input[], func: (arg: Input) => Output): Output[] {
    return arr.map(func);
}
// Parameter 'n' is of type 'string'
// 'parsed' is of type 'number[]'
const parsed = map(["1", "2", "3"], (n) => parseInt(n));

const merge = map(['2', '3', '44'], (n) => parseInt(n))

// specifying type argument

function combine<Type>(arr1: Type[], arr2: Type[]): Type[] {
    return arr1.concat(arr2);
}

function comnine2<Type>(arr1: Type[], arr2: Type[]): Type[] {
    return arr1.concat(arr2)
}

// const arr = combine([1,2,3], ['Hello']);

function ahihi<Type>(arr: Type[]): Type[] {
    return arr;
}

function filter<Type>(arr: Type[], func: (arg: Type) => boolean): Type[] {
    return arr.filter(func)
}

function filter2<Type, Func extends (arg: Type) => boolean>(
    arr: Type[],
    func: Func): Type[] {
    return arr.filter(func)
}

function f(x?: number) {
    console.log(x);

}

f();
f(10);


// provide params defutl

function wowow(x = 10) {
    console.log(x);
}

declare function fx(x?: number): void;
fx();
fx(10);
f(undefined);

// optional params in callbacks

function myForEach(arr: any[], callbacks: (arg: any, index?: number) => void) {
    for (let i = 0; i < arr.length; i++) {
        callbacks(arr[i], i)
    }
}

function myForEach_1(arr: any[], callback: (arg: any, index?: number) => void) {
    for (let i = 0; i < arr.length; i++) {
        // I don't feel like providing the index today
        callback(arr[i]);
    }
}

function renderItem(arr: any[], callback: (arg: any, index?: number) => void) {
    for (let i = 0; i < arr.length; i++) {
        callback(arr[i], i);
    }
}

function multipe(a: number, ...m: number[]) {
    return m.map(x => a * x);
}

class Shape {
    x: number
    y: number
    area(): number {
        return this.x * this.y;
    }
}

interface PaintOptions {
    shape: Shape;
    xPos?: number;
    yPos?: number;
}


function paintShape(opts: PaintOptions) {
    let xPos = opts.xPos === undefined ? 0 : opts.xPos;

    let yPos = opts.yPos === undefined ? 0 : opts.yPos;

};

function paintShape2({ shape, xPos = 0, yPos = 0 }: PaintOptions) {
    console.log('x coornidate at', xPos);
    console.log('y coornidate at', yPos);
}

const shape = new Shape()
paintShape({ shape, xPos: 100, })
paintShape({ shape, yPos: 100, })

interface SomeType {
    readonly prop: string; // can't be written to during type-checking
}

function doCC(obj: SomeType): void {
    console.log('the value is: ' + obj.prop);

    // But we can't re-assign it.
    //obj.prop = "hello"
}
// In other words, its internal contents can be changed. It just means the property itself can't be re-written

interface Home {
    readonly resident: { name: string, age: number }
}

function visitForBirthday(home: Home) {
    // We can read and update properties from home.resident 
    console.log(`Happy birthday ${home.resident.age}`);
    home.resident.age++;
}

function evict(home: Home) {
    // but we can't write to the 'resident' property itself on a "Home";

    // home.resident = {
    //     wow: 'wow',
    //     'meomeo': 'memeo'
    // }
}

interface Person {
    name: string;
    age: number;
}

interface ReadonlyPerson {
    readonly name: string;
    readonly age: number;
}

let writablePerson: Person = {
    name: "Nguyen Van Huy",
    age: 21
}


let readonlyPerson: ReadonlyPerson = writablePerson;
console.log(readonlyPerson.age); // prints '42'
writablePerson.age++;
console.log(readonlyPerson.age); // prints '43'

// index
interface ReadOnlyNumberDictionany {
    readonly [index: string]: number | string;
}

let array: ReadOnlyNumberDictionany

// extends

interface BasicAddress {
    name?: string,
    street: string,
    city: string,
    country: string,
    postalCode: string
}

interface AddressWithUnit extends BasicAddress {
    unit: string;
}

// interface can also extend from multiple types

interface Colorful {
    color: string
}

interface Circle {
    radius: number
}

interface ColorfulCircle extends Colorful, Circle { }

const cc: ColorfulCircle = {
    color: 'red',
    radius: 42
}


// intersection types
function draw(circle: Colorful & Circle) {
    console.log(`Color was ${circle.color}`)
    console.log(`Radius was ${circle.radius}`);
}

draw({ color: 'blue', radius: 42 })

// Interface and intersections
interface Box {
    contents: unknown
}

let x: Box = {
    contents: 'cc'
}

if (typeof x.contents === 'string') {
    console.log(x.contents.toLowerCase())
}

console.log((x.contents as string).toLocaleLowerCase());

interface NumberBox {
    contents: number;
}

interface StringBox {
    contents: string;
}

interface BooleanBox {
    contents: boolean
}
function setContents(box: StringBox, newContents: string): void;
function setContents(box: NumberBox, newContents: number): void;
function setContents(box: BooleanBox, newContents: boolean): void;
function setContents(box: { contents: any }, newContents: any) {
    box.contents = newContents;
}

interface Box2<Type> {
    contents: Type
}

let box2: Box2<string>;

let box2a: Box2<string> = { contents: 'hello' };
box2a.contents;

type OrNull<Type> = Type | null;

type OneOrMany<Type> = Type | Type[];

type OneOrManyOrNull<Type> = OrNull<OneOrMany<Type>>;

type OneOrManyOrNullStrings = OneOrManyOrNull<string>;

function doSt(value: Array<string>) {

}

let myArray: string[] = ["hello", "world"];

// either of these work!

doSt(myArray);
doSt(new Array("hello", 'cc'));


// Much like the type above, Array itself is a generic type
interface TheArrayOfMe<Type> {
    /**
     * Gets or sets the length of the array
     * 
     * 
     */
    length: number;

    /**
     * Removes the last element from an array and returns it
     * 
     * 
     */

    pop(): Type | undefined

    /**
     * 
     * 
     * Appends new elements to an array, and returns the new length of the array.
     */

    push(...item: Type[]): number;

}

function deStuff(values: ReadonlyArray<string>) {
    // we can read from value;

    const copy = values.slice();

    console.log(
        `The first value is ${values[0]}`
    );

    // ...but we can't mutate 'value'

    // values.push('hello!')

}


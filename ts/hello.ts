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

function len(s: string): number;
function len(arr: any[]): number;
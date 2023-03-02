# Reviwe data structure and algorithm.

## JavaScript

1. array
2. callback function, hof , closure
3. 4 ways to use function
- pass them to other function
- store a variable
- set them as property of object

3. OOP
- encapsulation
- inheritance
- polymorphism
- abstraction

4. Rest Api

- REST is (Representation Sate Transfer) is a basiclly convention for building http services
- A simple https principle includes: CREATE, READ, UPDATE, DELETE ---> CRUD operator
- All the address can start with http or https, if you want to be exchanged on a secure, you should use https
- architecture url: https://nguyenhuy.com/api/customers --> https: http protocol, nguyenhuy.com: domain, api: subdomain, customers: which refer to collection of customer in our application.
- To get endpoint using http method to request into a server: `GET`,`POST`, `PUT`, `DELETE`
    - GET `api/customers` --> send me list customers
    - GET `api/customers/1` --> send me a customer
    - UPDATE(PUT)`api/customers/1` --> update a customer
    - DELETE(PUT) `api/customers/1` --> delete a customer
    - CREATE{POST} `api/customres` includes data --> create a customer


## STACK
![stack image](./image/Stack.jpg)
### I am using C#
```
Stack.cs
class Stack<T>
{
    int current = -1; 
    T[] items; // craete an array

    public Stack(int size) // create constructor
    {
        items = new T[size]; // create the size of array
    }

    public bool Empty => current == -1; // check empty
    public bool Full => current == items.Length - 1; // the current

    public bool Push(T item)
    {
        if (!Full)
        {
            items[++current] = item; // ++items the value of x after the operator
            return true;
        }
        return false;
    }

    public T? Pop() => !Empty ? items[current--] : default(T); // --items the value of x before the operator
}
```
2. how to use the ` Stack<T>` class
```
class Program
{
    public static void Main(string[] args)
    {
        var colors = new Stack<string>(3);

        colors.Push("Red");
        colors.Push("Green");
        colors.Push("Blue");

        while (true)
        {
            var color = colors.Pop();

            if (color == null)
            {
                break;
            }

            Console.WriteLine(color);
        }

    }

}
```
3. How it works
- First, create a new instance of the Stack and specify the string as the type with the length of items.
```
var color = new Stack<string>(3);
```
- Second, call ```Push()``` method three times to push ```Green```,```Red```, and ```Blue``` strings into the stack.
```
colors.Push("Red");
colors.Push("Green");
colors.Push("Blue");
```
- Third, pop the string out of the stack until it is empty by calling the ```Pop()``` method.
```
while (true)
{
    var color = colors.Pop();

    if (color == null)
    {
        break;
    }

    Console.WriteLine(color);
}
```
### I am usting JavaScript
```

    class Stack {
        constructor() {
            this.items = [];
        }

        // isEmpty
        // Pop
        // Push

        // 1 - Push()

        push(element) {
            return this.items.push(element);
        }

        pop() {
            if (this.items.length === 0) { // if stack is empty 
                return "Underflow";
            }
            return this.items.pop(); // remove the last element --> top element in stack
        }

        peek() {
            return this.items[this.items.length - 1]; //Return the top most element without removing it from the stack.
        }

        isEmpty() { // return true if stack is empty
            return this.items.length == 0;
        }
        // printStack function
        printStack() {
            var str = "";
            for (var i = 0; i < this.items.length; i++)
                str += this.items[i] + " ";
            return str;
        }

    }
    // creating object for stack class
    var stack = new Stack();

    // testing isEmpty and pop on an empty stack

    // returns false
    console.log(stack.isEmpty());

    // returns Underflow
    console.log(stack.pop());

    // Adding element to the stack
    stack.push(10);
    stack.push(20);
    stack.push(30);

    // Printing the stack element
    // prints [10, 20, 30]
    console.log(stack.printStack());

    // returns 30
    console.log(stack.peek());

    // returns 30 and remove it from stack
    console.log(stack.pop());

    // returns [10, 20]
    console.log(stack.printStack());
```

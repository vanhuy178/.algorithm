// namespace _algorithm;
// class Stack<T>
// {
//     int current = -1; // index at last array
//     T[] items; // craete an array

//     public Stack(int size) // create constructor
//     {
//         items = new T[size]; // create the size of array
//     }

//     public bool Empty => current == -1; // check empty
//     public bool Full => current == items.Length - 1; // the current

//     public bool Push(T item)
//     {
//         if (!Full)
//         {
//             items[++current] = item; // ++items the value of x after the operator
//             return true;
//         }
//         return false;
//     }

//     public T? Pop() => !Empty ? items[current--] : default(T); // --items the value of x before the operator
// }


// class NewStack<T>
// {
//     public int current = -1;
//     T[] items;

//     public NewStack(int size)
//     {
//         items = new T[size];
//     }

//     public bool Empty => current == -1;
//     public bool Full => current == items.Length - 1;


//     public bool Push(T item)
//     {
//         if (!Full)
//         {
//             items[++current] = item;
//             return true;
//         }
//         return false;
//     }

//     public T? Pop() => !Empty ? items[current--] : default(T);
// }
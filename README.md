# Ôn lại thuật toán cho phỏng vấn cũng như cũng cố tư duy trong lập trình.

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
- To get endpoint using http method to request into a server: GET, POST, PUT, DELETE
    - GET api/customers --> send me list customers
    - GET api/customers/1 --> send me a customer
    - UPDATE(PUT) api/customers/1 --> update a customer
    - DELETE(PUT) api/customers/1 --> delete a customer
    - CREATE{POST} api/customres, includes data --> create a customer


## STACK
```
// I am using C#

class Stack
{
    int current = -1;
    string[] items;

    public Stack(int size)
    {
        items = new string[size];
    }

    public bool Empty => current == -1;
    public bool Full => current == items.Length - 1;

    public bool Push(string item)
    {
        if (!Full)
        {
            items[++current] = item;
            return true;
        }
        return false;
    }

    public string? Pop() => !Empty ? items[current--] : null;
}
```

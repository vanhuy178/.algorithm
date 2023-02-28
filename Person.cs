// class Person
// {
//     private string firstName;
//     private string lastName;
//     private int age;

//     public Person()
//     {
//         Console.WriteLine("Initialized the object");
//     }

//     public Person(string firstName, string lastName) : this()
//     {
//         this.firstName = firstName;
//         this.lastName = lastName;
//         Console.WriteLine("Initialized the first name & last name properties");
//     }
//     public Person(string firstName, string lastName, byte age) : this(firstName, lastName)
//     {
//         this.age = age;
//         Console.WriteLine("Initialized the age property");
//     }
//     public string getFullName()
//     {
//         return $"{this.firstName} {this.lastName}";
//     }

//     //HOW CAN WE ACCESS TO PRIVATE FIELD;

//     public string FirstName
//     {
//         get { return firstName; } // get, set is called the property accessors.
//         set
//         {
//             if (string.IsNullOrEmpty(value))
//             {
//                 throw new ArgumentException("The first name must not be empty or null");
//             }
//             firstName = value;
//         }
//     }
//     public string LastName
//     {
//         get { return lastName; }
//         set
//         {
//             if (string.IsNullOrEmpty(value))
//             {
//                 throw new ArgumentException("The last name must not be empty or null");
//             }
//             lastName = value;
//         }

//     }
//     public int Age
//     {
//         get { return age; }
//         set
//         {
//             if (value < 0 || value > 150)
//             {
//                 throw new ArgumentException("The age must be between 1 and 150");
//             }

//             age = value;
//         }
//     }


// }

class Person
{
    public string Name;

    public static int Count = 0;

    public static void MyMethod()
    {
        Console.WriteLine("params");
    }
    public Person(string name)
    {
        Name = name;

        Count++; // static field
        MyMethod(); // static method 
    }
}
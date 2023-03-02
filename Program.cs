namespace _algorithm;
using MyNameSpace;
using MyNameSpace.Abc;
using SanPham;
using static System.Console;
using System.Linq;
using MyLib;
using MyException;
static class Abc
{
    public static void Print(this string s, ConsoleColor color)
    {
        ForegroundColor = color;
        WriteLine(s);
    }
}
class Program
{
    // publisher --> class --> play events;
    public delegate void InputNumberEvent(int x);

    class InputData : EventArgs
    {
        public int data { set; get; }
        public InputData(int x) => data = x;
    }
    class UserInput
    {
        //public event InputNumberEvent inputNumberEvent; // +=, -= this is delegate, it can receive lamda expression
        public event EventHandler inputNumberEvent; //~ delegate void inputNumberEvent(object? sender, EventArgs args);
        public void Input()
        {
            do
            {
                string a = ReadLine();
                int x = Int32.Parse(a);
                inputNumberEvent?.Invoke(this, new InputData(x));
            }
            while (true);
        }
    }

    // subcriber --> class --> received events; 
    class SquareRoot
    {
        public void Sub(UserInput input)
        {
            input.inputNumberEvent += SquareRoott;
        }
        public void SquareRoott(object sender, EventArgs e)

        {
            InputData inputData = (InputData)e;
            int i = inputData.data;
            WriteLine($"The square root of {i} is: {Math.Sqrt(i)}");
        }
    }
    class Squaree
    {
        public void Sub(UserInput input)
        {
            input.inputNumberEvent += Squareee;
        }
        public void Squareee(object sender, EventArgs e)
        {
            InputData inputData = (InputData)e;
            int i = inputData.data;
            WriteLine($"The square of {i} is: {(i * i)}");
        }
    }

    // We define a class using static field, nethod.
    class CountNumber
    {
        public static int number = 0;
        public static void InfoStatic()
        {
            WriteLine("Hi Info");
        }
        public static void Count()
        {
            CountNumber.number++;
        }
    }

    // we use readonly
    class Student
    {
        public readonly string name; // this field just read only;

        public Student(string _name)
        {
            name = _name; // but we can aisign intial value for name;
        }
    }

    class Vector // overloaded operator
    {
        double x;
        double y;
        public Vector(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        public void Info() => WriteLine($"X: {x}, Y: {y}");

        // vector --> vector + vector;
        public static Vector operator +(Vector v1, Vector v2)
        {
            double x = v1.x + v2.x;
            double y = v1.y + v2.y;
            Vector v = new Vector(x, y);
            return v;
        }
        public static Vector operator +(Vector v1, double value)
        {
            double x = v1.x + value;
            double y = v1.y + value;
            Vector v = new Vector(x, y);
            return v;
        }

        // indexer

        public double this[int i]
        {
            set
            {
                switch (i)
                {
                    case 0:  //x
                        x = value;
                        break;
                    case 1: //x
                        y = value;
                        break;
                    default:
                        throw new Exception("Error Index");
                }
            }
            get
            {
                switch (i)
                {
                    case 0:  //x
                        return x;
                    case 1: //x
                        return y;
                    default:
                        throw new Exception("Error Index");
                }
            }
        }
        public double this[string s]
        {
            set
            {
                switch (s)
                {
                    case "x":  //x
                        x = value;
                        break;
                    case "y": //x
                        y = value;
                        break;
                    default:
                        throw new Exception("Error Index");
                }
            }
            get
            {
                switch (s)
                {
                    case "x":  //x
                        return x;
                    case "y": //y
                        return y;
                    default:
                        throw new Exception("Error Index");
                }
            }
        }
    }
    static void Register(string name, int age)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new NoNameException();
        }
        else if (age < 18 || age > 35)
        {
            throw new AgeException();
        }

        WriteLine("Register successfully!!");
    }
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string _name, int _age)
        {
            Name = _name;
            Age = _age;
        }
    }



    static void Main(string[] args)
    {

        LinkedList<string> listLesson = new LinkedList<string>();
        var lesson1 = listLesson.AddFirst("Lesson1");
        var lesson2 = listLesson.AddAfter(lesson1, "Lessin2");
        var lesson3 = listLesson.AddAfter(lesson2, "Lesson3");
        var lesson4 = listLesson.AddAfter(lesson3, "Lessin4");
        var lesson5 = listLesson.AddLast("Lessin5");

        // var node = lesson5;
        // node = node.Previous;
        // WriteLine("Element prev is: " + node.Value);

        // foreach (string data in listLesson)
        // {
        //     WriteLine("List lesson: " + data);
        // }

        var node = lesson5;
        while (node != null)
        {
            WriteLine(node.Value);
            node = node.Previous;
        }

        Dictionary<string, int> CounterSystem = new Dictionary<string, int>()
        {
            ["One"] = 1,
            ["Two"] = 2,
            ["Three"] = 3

        };

        CounterSystem.Add("Four", 4);
        CounterSystem["Five"] = 5;

        foreach (var data in CounterSystem)
        {
            WriteLine($"The key: {data.Key},  the value: {data.Value}");
        }

        // Hashset
        HashSet<int> evenNumbers = new HashSet<int>();
        HashSet<int> oddNumbers = new HashSet<int>();

        for (int i = 0; i < 5; i++)
        {
            // Populate numbers with just even numbers.
            evenNumbers.Add(i * 2);

            // Populate oddNumbers with just odd numbers.
            oddNumbers.Add((i * 2) + 1);
        }

        Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
        DisplaySet(evenNumbers);

        Console.Write("oddNumbers contains {0} elements: ", oddNumbers.Count);
        DisplaySet(oddNumbers);

        // Create a new HashSet populated with even numbers.
        HashSet<int> numbers = new HashSet<int>(evenNumbers);
        Console.WriteLine("numbers UnionWith oddNumbers...");
        numbers.UnionWith(oddNumbers);

        Console.Write("numbers contains {0} elements: ", numbers.Count);
        DisplaySet(numbers);

        void DisplaySet(HashSet<int> collection)
        {
            Console.Write("{");
            foreach (int i in collection)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }



        Stack<string> inventory = new Stack<string>();
        // Push into stack
        inventory.Push("product 1");
        inventory.Push("product 2");
        inventory.Push("product 3");

        WriteLine("Count inentory: " + inventory.Count());

        Queue<string> handleProfile = new Queue<string>();
        //ADD ELEMENT TO ENQUEUE
        handleProfile.Enqueue("Profile - 1");
        handleProfile.Enqueue("Profile - 2");
        handleProfile.Enqueue("Profile - 3");
        handleProfile.Enqueue("Profile - 4");
        handleProfile.Enqueue("Profile - 5");

        //REMOVE ELEMENT OUT OF QUEUE BY DEQUE
        var dequeueFirstElement = handleProfile.Dequeue();// REMOVE THE FIRST ITEM OF QUEUE AND RETURN VALUE OF THE ITEM
        Console.WriteLine("Browser Profile: " + dequeueFirstElement + " records " + handleProfile.Count());
        User user1 = new User("Nguyen Van Huy", 11);
        // Register(user1.Name, user1.Age);

        // HANDLE EVENT
        UserInput userInput = new UserInput(); // userinput play event --> publisher
        SquareRoot squareRoot = new SquareRoot(); // subcriber
        Squaree squaree = new Squaree();    // subcriber
                                            // squareRoot.Sub(userInput);
                                            // squaree.Sub(userInput);
                                            // userInput.Input();


        // EXTENSION METHOD
        int[] array = { 1, 2, 34, 5 };
        var max = array.Max();
        // WriteLine(max);

        // extension method 

        string s = "Hello world";
        s.Print(ConsoleColor.Green); // This is extension method
                                     // "Hello".Print(ConsoleColor.Blue);


        // Using extension method
        // int x = 105;
        // WriteLine(x.MySquare());
        // WriteLine(x.MySin());
        // WriteLine(x.MyCos());
        // WriteLine(x.MySquareRoot());



        // Now we can use static method that we don't need create an instance
        // CountNumber.InfoStatic();
        // CountNumber.Count();
        // CountNumber.Count();
        // CountNumber.Count();
        // WriteLine(CountNumber.number);


        // overloaded operator
        Vector vt1 = new Vector(10, 29);
        Vector vt2 = new Vector(11, 291);
        var vt3 = vt1 + vt2;
        var vt4 = vt1 + 20;


        // if you + vector with a number like this var vt3 = vt1 + 10;
        // Console.WriteLine($"Tọa độ X: {vt4[0]}, Tọa độ Y: {vt4[1]} by indexer index by number");
        // Console.WriteLine($"Tọa độ X: {vt4["x"]}, Tọa độ Y: {vt4["y"]} by indexer index by string");
        // vt1.Info();
        // vt2.Info();
        // vt3.Info();
        // vt4.Info();

    }
}

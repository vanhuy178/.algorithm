namespace _algorithm;
using MyNameSpace;
using MyNameSpace.Abc;
using SanPham;
using static System.Console;
using System.Linq;
using MyLib;
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





    static void Main(string[] args)
    {
        UserInput userInput = new UserInput(); // userinput play event --> publisher

        SquareRoot squareRoot = new SquareRoot(); // subcriber
        Squaree squaree = new Squaree();    // subcriber
        // squareRoot.Sub(userInput);
        // squaree.Sub(userInput);
        // userInput.Input();


        // EXTENSION METHOD
        int[] array = { 1, 2, 34, 5 };
        var max = array.Max();
        WriteLine(max);

        // extension method 

        string s = "Hello world";
        s.Print(ConsoleColor.Green); // This is extension method
        "Hello".Print(ConsoleColor.Blue);


        // Using extension method

        int x = 105;
        WriteLine(x.MySquare());
        WriteLine(x.MySin());
        WriteLine(x.MyCos());
        WriteLine(x.MySquareRoot());
    }
}

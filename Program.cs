namespace _algorithm;
using MyNameSpace;
using MyNameSpace.Abc;
using SanPham;
using static System.Console;


class Program
{
    class Animal
    {
        public virtual void AnimalSound() => WriteLine("The animal sounds");
    }

    class Pig : Animal
    {
        public override void AnimalSound() => WriteLine("wee wee");
    }

    class Dog : Animal
    {
        public override void AnimalSound() => WriteLine("Gâu gâu");
    }

    abstract class Product
    {
        protected double Price { get; set; }
        public abstract void ProductInfo();
        public void Test() => ProductInfo();
    }

    class Iphone : Product
    {
        public Iphone() => Price = 500;

        public override void ProductInfo()
        {
            WriteLine("Nhìn cc");
            WriteLine($"The pirce is: {Price}");
        }
    }

    public delegate void ShowLog(string message);


    // delegate 
    delegate int NumberChanger(int n);
    static int num = 10;
    public static int AddNum(int p)
    {
        num += p;
        return num;
    }
    public static int Multnum(int q)
    {
        num *= q;
        return num;
    }
    public static int GetNum()
    {
        return num;
    }
    public delegate void ShowLogg(string message);
    static void Info(string s)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(s);
        Console.ResetColor();
    }

    static void Warning(string s)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(s);
        Console.ResetColor();
    }

    static void Add(int a, int b, ShowLogg logg)
    {
        int result = a + b;
        logg?.Invoke($"The sum in logg is: {result}");
    }
    static int Minus(int a, int b) => a - b;
    static void Main(string[] args)
    {

        ShowLogg slgg = null;// delegate is reference type so it can be null, delegate can be reference to multiple method 
        WriteLine("The add with argument is: ");
        Add(10, 20, Info);
        slgg += Info;
        slgg += Info;
        slgg += Info;
        slgg += Info;
        slgg += Warning;
        slgg += Warning;

        slgg?.Invoke("Love everyone");

        NumberChanger nc;
        NumberChanger nc1 = new NumberChanger(AddNum);      // ref to AddNum method
        NumberChanger nc2 = new NumberChanger(Multnum);     // ref to Multnum method

        nc = nc1;   // multiple delegate
        nc += nc2;
        nc(5);
        WriteLine("The GetNum is");
        WriteLine(GetNum());
        Console.ReadKey();

        // Next we talk about Action and Func: this is two delegate build-in by .net, It has generic.
        Action ac1;     // --> delegate void ac1(no params);
        Action<string, int> ac2;    // --> delegate void ac2(string s, int i)
        Action<string> ac3; // delegate void ac3<string s> --> because it received string, and void so we can use two method Info, Warning. 

        ac3 = Warning;
        ac3 += Info;
        Console.WriteLine("Action 3:");
        ac3.Invoke("Love baby");

        // Func is the same action but it must have return value
        //Func<int> f1; // -> delegate int f1();
        //Func<int, string, int> f2; // -> delegate int (int i ,  string s); // the last params is the return value

        Func<int, int, int> calulator;
        int a = 10;
        int b = 10;
        // calulator = Add;
        // WriteLine($"Sum: {calulator(a, b)}");
        calulator = Minus;
        WriteLine($"Minus: {calulator(a, b)}");



        // Product p1 = new Product(); --> raise error
        // Iphone iphone12 = new Iphone();
        // iphone12.ProductInfo();


        // Animal animal = new();
        // Animal pig = new Pig();
        // Animal dog = new Dog();
        // animal.AnimalSound();
        // pig.AnimalSound();
        // dog.AnimalSound();

        // Abc a = new Abc();
        // a?.Hello(); // ---> it will be the same
        // if (a != null)
        // {
        //     a.Hello();
        // }

        // int? age; // age can assign nullable value
        // age = 21;

        // if (age.HasValue)
        // {
        //     int _age = age.Value;
        //     WriteLine("Your age is: " + _age);
        // }


        // Class1.Hello();
        // Class2.Hello();

        // WriteLine("Using Product namespace");

        // Product product1 = new Product();
        // product1.Name = "Smart phone";
        // product1.Price = 1200000;
        // product1.Description = "Nó là một cái điện thoại";
        // product1.menuFactory = new Product.MenuFactory();
        // product1.menuFactory.Address = "Tiền Giang";
        // product1.menuFactory.NameFactory = "NguyenHuyShop";
        // WriteLine("Get info menu factory: " + product1.menuFactory.GetInfoMenuFactory());
        // WriteLine("Get info is: " + product1.GetInfo());

        // var colors = new NewStack<string>(3);
        // colors.Push("Red");
        // colors.Push("Blue");
        // colors.Push("Green");
        // while (true)
        // {
        //     string popValue = colors.Pop();
        //     if (popValue == null)
        //     {
        //         break;
        //     }

        //     WriteLine(popValue);
        // }

        // THIS IS AN ANOMYNOUS TYPE WITH QUERRY DATA ;
        // List<Students> studentsList = new List<Students>() {
        //     new Students() {Name = "Nguyen Van Huy", YearOfBirth = 2002, PlaceOfBirth = "TIen Giang"},
        //     new Students() {Name = "Xuan Hien", YearOfBirth = 1994, PlaceOfBirth = "Binh Thuan"},
        //     new Students() {Name = "Hoa", YearOfBirth = 2002, PlaceOfBirth = "Binh Thuan"}
        // };

        // var result = from student in studentsList
        //              where student.Name.Contains("ien")
        //              select new
        //              {
        //                  Name = student.Name,
        //                  PlaceOfBirth = student.PlaceOfBirth
        //              };

        // foreach (var studentResult in result)
        // {
        //     WriteLine($"Full name is: {studentResult.Name}, Place is: : {studentResult.PlaceOfBirth} ");
        // }
    }
}

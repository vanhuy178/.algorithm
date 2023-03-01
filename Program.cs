namespace _algorithm;
using MyNameSpace;
using MyNameSpace.Abc;
using SanPham;
using static System.Console;


class Program
{
    // ANOMYNOUS TYPE
    // Object -> {properties = value, properties = value, ...} --> it is read only

    class Students
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
    }

    static string GetInfo(dynamic obj) // Dynamic
    {
        return $"{obj.Name}-{obj.PlaceOfBirth}";
    }

    class Abc
    {
        public void Hello() => WriteLine("nhìn cc");
    }
    static void Main(string[] args)
    {


        Abc a = new Abc();
        a?.Hello(); // ---> it will be the same
        if (a != null)
        {
            a.Hello();
        }

        int? age; // age can assign null value
        age = 21;

        if (age.HasValue)
        {
            int _age = age.Value;
            WriteLine("Your age is: " + _age);
        }


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
        List<Students> studentsList = new List<Students>() {
            new Students() {Name = "Nguyen Van Huy", YearOfBirth = 2002, PlaceOfBirth = "TIen Giang"},
            new Students() {Name = "Xuan Hien", YearOfBirth = 1994, PlaceOfBirth = "Binh Thuan"},
            new Students() {Name = "Hoa", YearOfBirth = 2002, PlaceOfBirth = "Binh Thuan"}
        };

        var result = from student in studentsList
                     where student.Name.Contains("ien")
                     select new
                     {
                         Name = student.Name,
                         PlaceOfBirth = student.PlaceOfBirth
                     };

        foreach (var studentResult in result)
        {
            WriteLine($"Full name is: {studentResult.Name}, Place is: : {studentResult.PlaceOfBirth} ");
        }
    }
}

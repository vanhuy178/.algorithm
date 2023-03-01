namespace _algorithm;
using MyNameSpace;
using MyNameSpace.Abc;
using SanPham;
using static System.Console;


class Program
{

    static void Main(string[] args)
    {
        Class1.Hello();
        Class2.Hello();

        WriteLine("Using Product namespace");

        Product product1 = new Product();
        product1.Name = "Smart phone";
        product1.Price = 1200000;
        product1.Description = "Nó là một cái điện thoại";
        product1.menuFactory = new Product.MenuFactory();
        product1.menuFactory.Address = "Tiền Giang";
        product1.menuFactory.NameFactory = "NguyenHuyShop";
        WriteLine("Get info menu factory: " + product1.menuFactory.GetInfoMenuFactory());
        WriteLine("Get info is: " + product1.GetInfo());
    }
}

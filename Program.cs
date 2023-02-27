namespace _algorithm;
class Program
{
    static void Main(string[] args)
    {
        Person ps2 = new();
        Person ps1 = new Person(); // initialize an object

        ps1.firstName = "Huy";
        ps1.lastName = "Nguyen";
        ps1.age = 21;

        Console.WriteLine(ps1.getFullName());
        Console.WriteLine(ps1.sayHi());

    }
}

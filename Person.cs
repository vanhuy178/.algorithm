class Person
{
    private string firstName;
    private string lastName;
    private byte age;

    public Person()
    {
        Console.WriteLine("Initialized the object");
    }

    public Person(string firstName, string lastName) : this()
    {
        this.firstName = firstName;
        this.lastName = lastName;
        Console.WriteLine("Initialized the first name & last name properties");
    }
    public Person(string firstName, string lastName, byte age) : this(firstName, lastName)
    {
        this.age = age;
        Console.WriteLine("Initialized the age property");
    }
    public string getFullName()
    {
        return $"{this.firstName} {this.lastName}";
    }


}
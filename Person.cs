class Person
{
    public string SSN { get; set; }
    public string Name { get; set; }
    public byte Age { get; set; }

    public Person(string ssn, string name, byte age)
    {
        SSN = ssn;
        Name = name;
        Age = age;
    }
}
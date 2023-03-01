
class Employee : Person
{
    public string JobTitle { get; set; }

    public new string Introduce() => $"Hi, I'm {Name}. I'm a {JobTitle}.";
}

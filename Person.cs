class Person
{
    public string firstName;
    public string lastName;
    public int age;

    public string getFullName()
    {
        return this.firstName + this.lastName;
    }
    public string sayHi()
    {
        return $"Hi, I'm {this.getFullName()}"; // this keyword reference to current object
    }
}
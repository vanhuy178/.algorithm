class Employee : Person
{
    public string JobTitle { get; set; }
    public decimal Salary { get; set; }
    public Employee(string firstName, string lastName, byte age, string jobTitle, decimal salary)
       : base(firstName, lastName, age)
    {
        JobTitle = jobTitle;
        Salary = salary;
    }


}
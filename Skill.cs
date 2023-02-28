class Skill
{
    private string name;
    private sbyte rating;

    public string Name
    {
        get { return name; }
        set { name = value; }

    }
    public sbyte Rating
    {
        get { return rating; } // get accessor excute when we reac the value from property
        set { rating = value; } // set accessor excutes when we assign value to it 
    }

}
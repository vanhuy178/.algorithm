class Stack
{
    int current = -1;
    string[] items;

    public Stack(int size)
    {
        items = new string[size];
    }

    public bool Empty => current == -1;
    public bool Full => current == items.Length - 1;

    public bool Push(string item)
    {
        if (!Full)
        {
            items[++current] = item;
            return true;
        }
        return false;
    }

    public string? Pop() => !Empty ? items[current--] : null;
}
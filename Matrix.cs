class Matrix
{
    private double[,] data;
    public Matrix(int row, int column)
    {
        data = new double[row, column];
    }
    public double this[int row, int column]
    {
        get { return data[row, column]; }
        set { data[row, column] = value; }
    }
}
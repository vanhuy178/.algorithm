class Result<T>
{
    T Data { get; set; }
    int Status { get; set; }
    public Result(T data, int status)
    {
        Data = data;
        Status = status;
    }
}
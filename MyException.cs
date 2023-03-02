using System;
namespace MyException
{
    public class NoNameException : Exception
    {
        public NoNameException() : base("No name!!!")
        {

        }
    }
    public class AgeException : Exception
    {
        public AgeException() : base("Too old or Unold!!!")
        {

        }
    }
}
namespace _algorithm;
class Program
{
    // enum Level
    // {
    //     Low, Medium, High
    // }
    // enum Status
    // {
    //     open,
    //     inProgress,
    //     resolved,
    //     closed,
    //     reopened
    // }
    static void Main(string[] args)
    {
        // We can access enum with dot access
        // int highLevelByInt = (int)Level.High;
        // Console.WriteLine("High Level is: ", highLevelByInt);


        // Status status = Status.open;
        // Status status1 = Status.inProgress;
        // bool isOpen = status1 == Status.open;

        // Console.WriteLine(isOpen); // True
        // var bmw = new Car() // drived class
        // {
        //     Type = "Car", // Type inheritence from Vehicle
        //     Brand = "BMW",
        //     TypeModal = "SUV",
        //     Version = "X7"
        // };

        // var riceHarvester = new Agrimotor()
        // {
        //     Type = "Agrimotor",
        //     Brand = "Agrimotor-1",
        //     TypeModal = "Big",
        //     Version = "Z"
        // };
        // Vehicle vehicle = bmw; // upcating  based class, we just obly use Type
        // Car car1 = (Car)vehicle; // downcasting

        // Vehicle vehicle1 = riceHarvester; // downcasting
        // Agrimotor agrimotor = vehicle1 as Agrimotor;  // downcasting fail

        // if (agrimotor != null)
        // {
        //     Console.WriteLine(agrimotor.Type);
        // }

        // Console.WriteLine(car1.Type);

        // var ps1 = new Person("545–57-1111", "John Doe", 25);

        // Console.WriteLine(ps1.ToString()); // GetHashCode() // IsEquals

        // Program.cs

        // Shape[] shapes =
        // {
        //     new Square(10),
        //     new Circle(100)
        // };

        // foreach (Shape shape in shapes)
        // {
        //     Console.WriteLine($"The area of the {shape} is {shape.Area():0.##}");
        // }

        // // Interface:
        // IReadable reader = new FileReader("C:\\Users\\ASUS\\Desktop\\nhap\\data.csv");
        // string readfile = reader.Read();

        // // Console.WriteLine(readfile);cls


        // var input = new Input();
        // input.Undo();
        // input.Redo();
        // // Program.cs

        // Message message = new();

        // message.Store("Hello");
        // Console.WriteLine(message.Retrieve());
        // message.Delete();
        // int amount = 100;
        // int qty = 0;

        // try
        // {
        //     int result = amount / qty;
        //     Console.WriteLine(result);
        // }
        // catch
        // {
        //     Console.WriteLine("The program was terminated due to an error.");
        // }

        // Console.WriteLine("Bye!");


        // Console.WriteLine("Start to read file");
        // StreamReader readerFile = null;

        // try
        // {
        //     readerFile = new StreamReader("C:\\Users\\ASUS\\Desktop\\nhap\\data.csv");
        //     string line = readerFile.ReadLine();
        //     while (line != null)
        //     {
        //         Console.WriteLine(line);
        //         line = readerFile.ReadLine();
        //     }
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine($"Error: {e.Message}");
        // }
        // finally // 
        // {
        //     if (readerFile != null)
        //     {
        //         readerFile.Close();
        //     }
        // }


        // TRY CATCH WITH INT TEST

        // int Test()
        // {
        //     int result = 100;
        //     try
        //     {
        //         return result;
        //     }
        //     catch (Exception e)
        //     {
        //         Console.WriteLine(e.Message);
        //     }
        //     finally
        //     {
        //         result = 200;
        //         Console.WriteLine("Execute the finally block...");
        //         Console.WriteLine($"The result in finally is: {result}");
        //     }

        //     // these statement won't execute
        //     Console.WriteLine("Bye!");
        //     return result;
        // }

        // Console.WriteLine(Test());

        {
            var colors = new Stack<string>(3); // array wiith size 3;

            colors.Push("Red");
            colors.Push("Green");
            colors.Push("Blue");
            colors.Push("HI"); // we can't push becasue it is over the size

            while (true)
            {
                var color = colors.Pop();

                if (color == null)
                {
                    break;
                }

                Console.WriteLine(color);
            }

        }


    }
}
// interface IReadable
// {
//     string Read();

// }

// class ConsoleReader : IReadable
// {
//     public string Read()
//     {
//         return Console.ReadLine() ?? string.Empty;
//     }
// }

// class FileReader : IReadable
// {
//     public string Filename { get; set; }

//     public FileReader(string filename)
//     {
//         Filename = filename;
//     }

//     public string Read()
//     {
//         return File.ReadAllText(Filename);
//     }
// }

// // C# support default params since c 8
// interface IUndoable
// {
//     void Undo();
// }
// interface IRedoable : IUndoable
// {
//     void Redo();
// }

// class Input : IRedoable
// {
//     public void Redo()
//     {
//         Console.WriteLine("Redo");
//     }

//     public void Undo()
//     {
//         Console.WriteLine("Undo");
//     }
// }

// interface IStore
// {
//     void Store(string data);
// }

// interface IRetrieve
// {
//     string? Retrieve();
// }
// interface IMessage : IStore, IRetrieve
// {
//     void Delete();
// }

// class Message : IMessage
// {
//     public string data = null;
//     public void Delete()
//     {
//         data = null;
//     }
//     public string Retrieve()
//     {
//         return data;
//     }
//     public void Store(string message)
//     {
//         data = message;
//     }
// }
namespace _algorithm;
class Program
{

    static void Main(string[] args)
    {

        var bmw = new Car() // drived class
        {
            Type = "Car", // Type inheritence from Vehicle
            Brand = "BMW",
            TypeModal = "SUV",
            Version = "X7"
        };

        var riceHarvester = new Agrimotor()
        {
            Type = "Agrimotor",
            Brand = "Agrimotor-1",
            TypeModal = "Big",
            Version = "Z"
        };
        Vehicle vehicle = bmw; // upcating  based class, we just obly use Type
        Car car1 = (Car)vehicle; // downcasting

        Vehicle vehicle1 = riceHarvester; // downcasting
        Agrimotor agrimotor = vehicle1 as Agrimotor;  // downcasting fail

        if (agrimotor != null)
        {
            Console.WriteLine(agrimotor.Type);
        }

        Console.WriteLine(car1.Type);

        var ps1 = new Person("545–57-1111", "John Doe", 25);

        Console.WriteLine(ps1.GetType());

    }
}

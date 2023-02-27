namespace _algorithm;
class Program
{
    static void Main(string[] args)
    {
        // with whitespace
        // bool isDark = false;
        // if (isDark)
        {
            // website.EnableDarkMode();
        }
        // statement 
        // int age = 9;
        // double weight = 10.99, height = 16.99;

        // Console.WriteLine($"The weight is {weight}kg and height is {height}m");
        // Console.WriteLine("Welcome to C#");

        // Identifiers

        //  For example, counter and Counter identifiers are different.

        /// <summary> 


        // Console.WriteLine($"Hello, World! -- {age}");

        // // More readable
        // int prize = 1_000_000;
        // double rating = 1.2;
        // string message = "";


        // // GET THE LENGTH OF THE STRING
        // int length = message.Length;

        // //CONCAT STRING
        // string firstName = "Huy";
        // string lastName = "Nguyen";
        // string fullName = firstName + lastName;

        // // VERBATIOM STRING 
        // string path = @"C:\users\";
        // Console.WriteLine(path);
        // string name = "Joe";
        // string greeting = $"Hello ${name}";
        // Console.WriteLine(greeting);

        // Console.WriteLine($"int range: ({int.MinValue},{int.MaxValue})");


        // string condition = "sunny";
        // bool free = true;
        // if (free)
        // {
        //     if (condition == "sunny")
        //     {
        //         Console.WriteLine("Let's go outside");
        //     }
        //     if (condition == "rainy")
        //     {
        //         Console.WriteLine("Go home");
        //     }
        //     else
        //     {
        //         Console.WriteLine("khò khò");
        //     }
        // }



        // // CHECK DAY 

        // Console.WriteLine("Please enter a day number (1-7):");
        // int day = Convert.ToInt32(Console.ReadLine());
        // string dayName;
        // if (day == 1)
        // {
        //     dayName = "Sunday";
        // }
        // else if (day == 2)
        // {
        //     dayName = "Monday";
        // }
        // else if (day == 3)
        // {
        //     dayName = "Tuesday";
        // }
        // else if (day == 4)
        // {
        //     dayName = "Wednesday";
        // }
        // else if (day == 5)
        // {
        //     dayName = "Thursday";
        // }
        // else if (day == 6)
        // {
        //     dayName = "Friday";
        // }
        // else if (day == 7)
        // {
        //     dayName = "Saturday";
        // }
        // else
        // {
        //     dayName = "Unknown";
        // }
        // Console.WriteLine($"It's {dayName}.");


        // Console.WriteLine("Body Mass Index (BMI) Calculation");

        // Console.WriteLine("Enter a weight (kg):");
        // double weight = Convert.ToDouble(Console.ReadLine());

        // Console.WriteLine("Enter a height (m):");
        // double height = Convert.ToDouble(Console.ReadLine());


        // double bmi = weight / (height * height);
        // string weightStatus;

        // if (bmi < 18.5)
        // {
        //     weightStatus = "Underweight";
        // }
        // else if (bmi >= 18.5 && bmi <= 24.9)
        // {
        //     weightStatus = "Healthy Weight";
        // }
        // else if (bmi >= 25 && bmi <= 29.9)
        // {
        //     weightStatus = "Overweight";
        // }
        // else
        // {
        //     weightStatus = "Obesity";
        // }

        // if (bmi < 18.5)
        // {
        //     weightStatus = "...";
        // }
        // else if (bmi >= 18.5 && bmi <= 25.9)
        // {
        //     weightStatus = "....cc";
        // }

        // Console.WriteLine($"BMI: {bmi:0.#}");
        // Console.WriteLine($"Weight status:{weightStatus}");

        // //FUNCTION
        // static string sayHi(string name)
        // {
        //     return $"Hi {name}";
        // }

        // sayHi("Hiền");



        /// <summary>
        /// Calculate the body mass index (BMI) based on weight in kg and height in meter
        /// </summary>
        /// <param name="weight">
        /// The weight in kilogram
        /// </param>
        /// <param name="height">
        /// The height in meter
        /// </param>
        /// <returns>
        /// The body mass index
        /// </returns>

        double CalculateBMI(double weight, double height) // FUNCTION FOR CALCULATING
        {
            return weight / (height * height);
        }


        string GetWeightStatus(double bmi) // CHECK CONDITION
        {
            string weightStatus = "";

            switch (bmi)
            {
                case < 18.5:
                    weightStatus = "Underweight";
                    break;
                case >= 18.5 and <= 24.9:
                    weightStatus = "Healthy Weight";
                    break;
                case >= 25 and <= 29.9:
                    weightStatus = "Overweight";
                    break;
                case > 30:
                    weightStatus = "Obesity";
                    break;
            }
            return weightStatus;
        }

        // MAIN PROGRAM

        // Console.WriteLine("Body Mass Index (BMI) Calculation");

        // Console.WriteLine("Enter a weight (kg):");
        // var weight = Convert.ToDouble(Console.ReadLine());

        // Console.WriteLine("Enter a height (m):");
        // var height = Convert.ToDouble(Console.ReadLine());

        // double bmi = CalculateBMI(weight, height); // CALCULATING 
        // string weightStatus = GetWeightStatus(bmi); // CHECK CONDITION HERE

        // Console.WriteLine($"BMI: {bmi:0.#}");
        // Console.WriteLine($"Weight status :{weightStatus}");

        // WE HAVE DEFAULT VALUE FOR SALETAX;
        double calculatePrice(double sellingPrice, double salesTax = 0.08)
        {
            return sellingPrice * (1 + salesTax);
        }

        var netPrice = calculatePrice(100, .9);

        Console.WriteLine($"The net price is {netPrice:0.##}");

        //WORK WITH ARRAY

        Console.WriteLine("Work with array");

        int[] scores = { 3, 2, 5, 4, 1 };

        Range r = 1..3;
        // Console.WriteLine("Range is ", scores[1..3]);
        // Indices
        // int indexLast = scores[^1];
        // Index lastIndex = scores[^1];


        // Console.WriteLine(scores.Length);

        // void PrintArray(int[] item)
        // {
        //     for (int i = 0; i < item.Length; i++)
        //     {
        //         Console.WriteLine(item[i]);
        //     }
        // }
        // Console.WriteLine("scores:");
        // PrintArray(scores);

        // // get the first two elements
        // int[] subScores = scores[..2];
        // Console.WriteLine("scores[..2]:");
        // PrintArray(subScores);

        // // get the elements starting from the 3rd element
        // subScores = scores[2..];
        // Console.WriteLine("scores[2..]:");
        // PrintArray(subScores);

        // // get all the elements starting from the 2nd element
        // Console.WriteLine("scores[1..3]:");
        // subScores = scores[1..3];
        // PrintArray(subScores);

        // DIMENSION ARRAY

        int[,] matrix =  {
            { 1, 2, 3 },
            { 4, 5, 6 },
        };


        // int[,,] tensor =  {
        //     { { 1, 2, 3 }, { 4, 5, 6 } },
        //     { { 7, 8, 9 }, { 10, 11, 12 } }
        // }; ;
        // foreach (var e in tensor)
        // {
        //     Console.Write($"{e} ");
        // }

        // decimal[] salaries = { 100000, 120000, 150000 };

        // void PrintArray(decimal[] salaries)
        // {
        //     for (int element = 0; element < salaries.Length; element++)
        //     {
        //         Console.WriteLine($"{salaries[element]:0.##}");
        //     }
        // }
        // void Increament(decimal[] salaries, decimal percentage = .05m)
        // {
        //     for (int element = 0; element < salaries.Length; element++)
        //     {
        //         salaries[element] *= (1 + percentage);
        //     }
        // }
        // PrintArray(salaries);
        // Increament(salaries);
        // Console.WriteLine(salaries);
        void PrintArray(decimal[] elements)
        {
            foreach (var element in elements)
            {
                Console.WriteLine($"{element:0.##}");
            }
        }

        void Increase(decimal[] salaries, decimal percentage = 0.05m)
        {
            for (int i = 0; i < salaries.Length; i++)
            {
                salaries[i] = salaries[i] * (1 + percentage);
            }
        }

        decimal[] salaries = { 100000, 120000, 150000 };

        Console.WriteLine("Before increment:");
        PrintArray(salaries);

        Increase(salaries);

        Console.WriteLine("After increment:");
        PrintArray(salaries);

    }
}

using System;

class unitConverter
{
    static void Main(String[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Unit Converter :)");
            Console.WriteLine("Please select from one of the following options:");
            Console.WriteLine("1. Convert from Miles to Kilometers");
            Console.WriteLine("2. Convert from Pounds to Kilograms");
            Console.WriteLine("3. Convert from Fahrenheit to Celsius");
            String input = Console.ReadLine();

            //Validate user input

            if (input == "1")
            {
                milesToKilometers();
            }
            else if (input == "2")
            {
                poundsToKilograms();
            }
            else if (input == "3")
            {
                fahrenheitToCelsius();
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }

        }
    }
    static void milesToKilometers()
    {
        Console.WriteLine("Please enter the number of miles: ");
        double miles = double.Parse(Console.ReadLine());
        double kilometers = miles * 1.609344;
        Console.WriteLine("{0} miles is equal to {1} kilometers. ", miles, kilometers);
    }
    static void poundsToKilograms()
    {
        Console.WriteLine("Please enter the number of pounds: ");
        double pounds = double.Parse(Console.ReadLine());
        double kilograms = pounds * 0.45359237;
        Console.WriteLine("{0} pounds is equal to {1} kilograms. ", pounds, kilograms);
    }

    static void fahrenheitToCelsius()
    {
        Console.WriteLine("Please enter Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());
        double celsius = ((fahrenheit-32)*5)/9;
        Console.WriteLine("{0} Fahrenheit is equal to {1} Celsius. ", fahrenheit, celsius);
    }
}
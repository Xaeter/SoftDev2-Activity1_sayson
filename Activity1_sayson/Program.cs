using System;
/*Create a simple temperature cpnversion program in c#. the program willl have a menu. The program flow will be something like this:
Welcome to Temperature Conversion!
[1.] C to F
[2.] F to C
[3.] K to C
[4.] F to K
select option: 1*/
namespace Activity1_sayson {
    class Program
{
    static void Main()
    {
        while (true)
        {
            //Menu
            Console.WriteLine("Welcome to Temperature Conversion!");
            Console.WriteLine("[1.] C to F");
            Console.WriteLine("[2.] F to C");
            Console.WriteLine("[3.] K to C");
            Console.WriteLine("[4.] F to K");
            Console.Write("Select option: ");
            //if invalid, recurse
            int option;
            if (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 4)
            {
                Console.WriteLine("Invalid option. Please select again.\n");
                continue;
            }
            //Selecting options from Menu
            Console.WriteLine($"Selected operation: {option}");
            double inputTemp, convertedTemp;
            
            switch (option)
            {
                case 1:
                    Console.Write("Enter temperature in Celsius: ");
                    inputTemp = double.Parse(Console.ReadLine());
                    convertedTemp = Celsius_ToFahrenheit.Convert(inputTemp);
                    Console.WriteLine($"{inputTemp} C is {convertedTemp:F2} F\n");
                    break;
                case 2:
                    Console.Write("Enter temperature in Fahrenheit: ");
                    inputTemp = double.Parse(Console.ReadLine());
                    convertedTemp = Fahrenheit_ToCelsius.Convert(inputTemp);
                    Console.WriteLine($"{inputTemp} F is {convertedTemp:F2} C\n");
                    break;
                case 3:
                    Console.Write("Enter temperature in Kelvin: ");
                    inputTemp = double.Parse(Console.ReadLine());
                    convertedTemp = Kelvin_ToCelsius.Convert(inputTemp);
                    Console.WriteLine($"{inputTemp} K is {convertedTemp:F2} C\n");
                    break;
                case 4:
                    Console.Write("Enter temperature in Fahrenheit: ");
                    inputTemp = double.Parse(Console.ReadLine());
                    convertedTemp = Fahrenheit_ToKelvin.Convert(inputTemp);
                    Console.WriteLine($"{inputTemp} F is {convertedTemp:F2} K\n");
                    break;
            }
            //ask user to convert again
            Console.Write("Back to menu? [Y/N]: ");
            string response = Console.ReadLine().Trim().ToLower();
            if (response != "y")
            {
                Console.WriteLine("Thank you for using the converter!");
                break;
            }
            Console.WriteLine();
        }
    }
} 
}


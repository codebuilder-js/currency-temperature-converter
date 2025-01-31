using System;
class CurrencyTemperatureConverter {
  static void Main() {
    Console.Write("Currency Converter / Temperature Converter (C/T): ");
    
    string answer = Console.ReadLine().ToLower();
    
    Console.WriteLine();
    
    if(answer == "c") {
        Console.WriteLine("-- Currency Converter --");
        Console.Write("Pounds / Euros (P/E): ");
        
        string choice = Console.ReadLine().ToLower();
        
        if(choice == "p") {
            Console.WriteLine();
            Console.Write("Enter your amount in British pounds: ");
            
            float pounds = float.Parse(Console.ReadLine());
            float euros = pounds * 1.16f;
            
            Console.WriteLine("Amount in euros: " + euros.ToString("0.00"));
            Console.WriteLine();
        } else if(choice == "e") {
            Console.Write("Enter your amount in euros: ");
            
            float euros = float.Parse(Console.ReadLine());
            float pounds = euros / 1.16f;
            
            Console.WriteLine("Amount in British pounds: " + pounds.ToString("0.00"));
            Console.WriteLine();
        }
    } else if(answer == "t") {
        Console.WriteLine("-- Temperature Converter --");
        Console.Write("Celsius / Farenheit (C/F): ");
        
        string choice = Console.ReadLine().ToLower();
        
        if(choice == "c") {
            Console.Write("Enter a temperature in celsius: ");
            
            float celsius = float.Parse(Console.ReadLine());
            float farenheit = celsius* 1.18f + 32f;
            
            Console.WriteLine("Temperature in farenheit is: " + farenheit);
            Console.WriteLine();
        } else if(choice == "f") {
            Console.Write("Enter a temperature in farenheit: ");
            
            float farenheit = float.Parse(Console.ReadLine());
            float celsius = (farenheit - 32f) / 1.8f;
            
            Console.WriteLine("Temperature in celcius is: " + celsius);
            Console.WriteLine();
        }
    }
  }
}

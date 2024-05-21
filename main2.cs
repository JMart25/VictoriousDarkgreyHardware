using System;

class PersonalInfo
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your birthdate (MM/DD/YYYY): ");
        DateTime birthdate = DateTime.Parse(Console.ReadLine());
        
        Console.Write("Enter your work phone number: ");
        string workPhoneNumber = Console.ReadLine();

        Console.Write("Enter your cell phone number: ");
        string cellPhoneNumber = Console.ReadLine();
        
        Console.WriteLine(name);
        Console.WriteLine(birthdate.ToString("M/d/yyyy"));
        Console.WriteLine("work " + workPhoneNumber);
        Console.WriteLine("cell " + cellPhoneNumber);
    }
}


//This file will also be able to run with the main.csproj file 
//within this repo due to both including the class 'PersonalInfo'

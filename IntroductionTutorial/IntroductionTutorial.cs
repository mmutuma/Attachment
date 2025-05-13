using System;

class EmploymentDetails
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter your name:");
        string employeeName = Console.ReadLine();

        Console.WriteLine("Enter the date of employment (yyyy-mm-dd):");
        string employmentDate = Console.ReadLine();

        Console.WriteLine("Enter the duration of employment (in years):");
        int employmentDuration = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the employer's name:");
        string employerName = Console.ReadLine();

        Console.WriteLine("Enter the location of employment:");
        string employmentLocation = Console.ReadLine();

    
        DateTime startDate = DateTime.Parse(employmentDate);
        DateTime endDate = startDate.AddYears(employmentDuration);

        
        Console.WriteLine("\n--- Employment Details ---");
        Console.WriteLine($"Employee Name: {employeeName}");
        Console.WriteLine($"Date of Employment: {startDate.ToShortDateString()}");
        Console.WriteLine($"Duration of Employment: {employmentDuration} years");
        Console.WriteLine($"Employer's Name: {employerName}");
        Console.WriteLine($"Location of Employment: {employmentLocation}");
        Console.WriteLine($"End Date of Employment: {endDate.ToShortDateString()}");

       
        Console.WriteLine("\nIs the above information correct? (yes/no)");
        string confirmation = Console.ReadLine();

        if (confirmation.ToLower() == "yes")
        {
            Console.WriteLine("Thank you! Your details have been saved.");
        }
        else
        {
            Console.WriteLine("Please restart the program to re-enter your details.");
        }
    }
}
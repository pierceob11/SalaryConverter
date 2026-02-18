// Main Program
var MainApp = new MainApp();
MainApp.Run();


public class MainApp
{
    public void Run()
    {
        var salaryConverter = new SalaryConverter();
        
        while (true)
        {
            DisplayMenu();
            
            int userInput = Convert.ToInt32(Console.ReadLine());

            salaryConverter.SalaryOrPph(userInput);
        }
    }
    
    
    private void DisplayMenu()
    {
        Console.WriteLine("Press '1' - Convert Salary to Pay Per Hour");
        Console.WriteLine("Press '2' - Convert Pay Per Hour to Salary");
    }
    
}


public class SalaryConverter
{
    public void SalaryOrPph(int userInput)
    {
        switch (userInput)
        {
            case 1:
                Console.Write("What salary do you want to convert to PPH?");
                int salaryInput = Convert.ToInt32(Console.ReadLine());
                float pphResult = ConvertSalaryToPph(salaryInput);
                Console.WriteLine($"Your Salary of {salaryInput} is works out to be {pphResult} per hour.");
                break;
            case 2:
                Console.Write("What Pay Per Hour do you want to convert to a Salary?");
                float payPerHourInput = Convert.ToSingle(Console.ReadLine());
                int salaryResult = ConvertPphToSalary(payPerHourInput);
                Console.WriteLine($"Your Pay Per Hour of {payPerHourInput} works out to be a salary of {salaryResult}.");
                break;
            default:
                Console.WriteLine("That is not a valid option");
                Console.Clear();
                break;
        }
    }

    private float ConvertSalaryToPph(int salary)
    {
        // Take salary and divide it by 52 weeks in year
        float payPerWeek = salary / 52; 
        
        // Take the return and divide it by five days a week
        float payPerDay = payPerWeek / 5;
        
        // Take the return and divide it by 8 hours a day
        float payPerHour = payPerDay / 8;
        
        // Return the result
        return payPerHour;
    }

    private int ConvertPphToSalary(float pph)
    {
        // Take the pph and multiply it by 8 hours a day
        float payPerDay = pph * 8;
        
        // Take the return and multiply it by 5 days a week
        float payPerWeek = payPerDay * 5;
        
        // Take the return and multiply it by 52 weeks a year
        float salary = payPerWeek * 52;
        
        return Convert.ToInt32(salary);
    }
}
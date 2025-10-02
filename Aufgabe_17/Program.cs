namespace Aufgabe_17;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your birthday: ");
        DateTime birthday = Convert.ToDateTime(Console.ReadLine());
        DateTime today = DateTime.Today;
        
        int ageYears = today.Year - birthday.Year;
        int remainingMonths = today.Month - birthday.Month;
        int remainingDays = today.Day - birthday.Day;
        
        if (remainingDays < 0)
        {
            DateTime previousMonth = today.AddMonths(-1);
            int daysInPreviousMonth = DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
            remainingDays += daysInPreviousMonth;
            remainingMonths--; 
        }
        
        if (remainingMonths < 0)
        {
            remainingMonths += 12;
            ageYears--;
        }
        
        int totalDays = (today - birthday).Days;
        int totalWeeks = totalDays / 7;
        int totalMonths = ageYears * 12 + remainingMonths;
        
        Console.WriteLine($"Years: {ageYears}");
        Console.WriteLine($"Months: {remainingMonths}");
        Console.WriteLine($"Weeks: {totalWeeks}");
        Console.WriteLine($"Days: {totalDays}");
    }
}

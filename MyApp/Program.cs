// See https://aka.ms/new-console-template for more information
namespace MyApp;

public class Program 
{
    public static void Main(String[] args)
    {

        if (args.Length > 0)
        {
            foreach (var arg in args)
            {
                
        
            if (int.TryParse(arg, out var val))
            {
                Console.WriteLine(IsLeapYear(val));
            } else Console.WriteLine("Error");
            }
        } else 
        {
        Console.WriteLine("Input a year");
        var input = Console.ReadLine();
        
            if (int.TryParse(input, out var val))
            {
                Console.WriteLine(IsLeapYear(val));
            } else Console.WriteLine("Error");
        }
        
    }

    static String IsLeapYear(int year)
    {
        if (year < 1582) return "This year is out of scope";
       if (year % 4 == 0) 
       {
            if (year % 100 == 0) 
            {
                if (year % 400 == 0)
                {
                    return "yay";
                } 
                return "nay";
            } 
            return "yay";
       } else return "nay";
    }
}

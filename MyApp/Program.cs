// See https://aka.ms/new-console-template for more information
namespace MyApp;

public class Program 
{
    public static void Main(String[] args)
    {
        foreach (string arg in args)
        {
            if (int.TryParse(arg, out var val))
            {
                Console.WriteLine(IsLeapYear(val));
            } else Console.WriteLine("Error");
        }
    }

    static bool IsLeapYear(int year)
    {
       if (year % 4 == 0) 
       {
            if (year % 100 == 0) 
            {
                if (year % 400 == 0)
                {
                    return true;
                } 
                return false;
            } 
            return true;
       } else return false;
    }
}

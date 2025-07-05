using Assignmnet01oop.NewFolder;
using System.Security.Cryptography.X509Certificates;
using static Assignmnet01oop.NewFolder.Class1;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Assignmnet01oop;

internal class Program
{
    static void Main(string[] args)
    {
      
        #region q1
        //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then,
        //write a C# program that prints out all the days of the week using this enum.

        //WeekDays weekDays= new WeekDays();
        //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
        //{
        //    Console.WriteLine(day);
        //}
        #endregion

        #region q2
        //Person[] person = new Person[3];
        // person[0] = new Person("Mohamed", 30);
        //person[1] = new Person("Bob", 25);
        //person[2] = new Person("Ahmed", 35);
        //    foreach(Person p in person)
        //    {
        //        Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
        //}



        #endregion

        #region q3
        //Write a C# program that takes a season name as input from the user and displays
        //the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)


            Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter): ");
            string input = Console.ReadLine()!;

  
        Season season;
            bool isValidSeason = Enum.TryParse(input, true, out season);
       

       string Renge= getRenge(season);
            if (isValidSeason)
            {
                Console.WriteLine($"The range for {season} is: {Renge}");
            }
            else
            {
                Console.WriteLine("Invalid season entered.");
        }





        #endregion


    }

    static string getRenge(Season season)
    {
        switch (season)
        {
            case Season.Spring:
                return "March to May";
            case Season.Summer:
                return "June to August";
            case Season.Autumn:
                return "September to November";
            case Season.Winter:
                return "December to February";
            default:
                return "Invalid season entered.";
        }
    }
}

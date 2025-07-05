using Assignmnet01oop.NewFolder;
using static Assignmnet01oop.NewFolder.Class1;
namespace Assignmnet01oop;

internal class Program
{
    static void Main(string[] args)
    {
      
        #region q1
        //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then,
        //write a C# program that prints out all the days of the week using this enum.

        WeekDays weekDays= new WeekDays();
        foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
        {
            Console.WriteLine(day);
        }
        #endregion

        #region q2


        #endregion


    }

}

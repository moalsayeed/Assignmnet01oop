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

        //WeekDays weekDays= new WeekDays();
        //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
        //{
        //    Console.WriteLine(day);
        //}
        #endregion

        #region q2
        Person[] person = new Person[3];
         person[0] = new Person("Mohamed", 30);
        person[1] = new Person("Bob", 25);
        person[2] = new Person("Ahmed", 35);
            foreach(Person p in person)
            {
                Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
        }



        #endregion

        #region q3

        #endregion


    }

}

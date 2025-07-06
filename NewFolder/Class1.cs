
using System.ComponentModel;
using System.Drawing;
using static Assignmnet01oop.NewFolder.Class1;

namespace Assignmnet01oop.NewFolder
{
    public class Class1
    {
        // Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }


        //Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then,
        //write a C# program to display the details of all the persons in the array.
        public struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        #region q3
        //  Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
        //  Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
        //  Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        #endregion

        #region q4
        //Create an enum called "Colors" with the basic colors(Red, Green, Blue) as its members.
        //Write a C# program that takes a color name as input from the user and
        //displays a message indicating whether the input color is a primary color or not.
            
        public enum Colors
        {
            Red,
            Green,
            Blue
        }


        #endregion

        #region q5

        //Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.





        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
      
        }

        #endregion

        #region q6

        //Create a struct called "Person" with properties "Name" and "Age".
        //Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.




        #endregion




    }
}


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



    }
}

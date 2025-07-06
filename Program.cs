using Assignmnet01oop.NewFolder;
using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using static Assignmnet01oop.NewFolder.Class1;
using static System.Runtime.InteropServices.JavaScript.JSType;


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


//     Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter): ");
//     string input = Console.ReadLine()!;


// Season season;
//     bool isValidSeason = Enum.TryParse(input, true, out season);


//string Renge= getRenge(season);
//     if (isValidSeason)
//     {
//         Console.WriteLine($"The range for {season} is: {Ren  ge}");
//     }
//     else
//     {
//         Console.WriteLine("Invalid season entered.");
// }





#endregion/


#region q4
//.Write a C# program that takes a color name as input from the user and displays
//a message indicating whether the input color is a primary color or not.

//Console.WriteLine("Enter a color (Red, Green, Blue): ");

//string colorInput = Console.ReadLine()!;


//Colors color;
//bool isValidColor = Enum.TryParse(colorInput, true, out color);
//if (isValidColor) {
//    switch (color)
//    {
//        case Colors.Red:
//        case Colors.Green:
//        case Colors.Blue:
//            Console.WriteLine($"{color} is a primary color.");
//            break;
//        default:
//            Console.WriteLine($"{color} is not a primary color.");
//            break;
//    }
//}
//else
//{
//    Console.WriteLine("Invalid color entered.");
//}


#endregion
#region q5
//Write a C# program that takes two points as input from the user and calculates the distance between them.


//Point p1 = new Point(3, 4);
//Point p2 = new Point(7, 1);


//public static double CalculateDistance(Point p1, Point p2)
//{
//    double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
//    return distance;
//}




#endregion

#region q6
//Create a struct called "Person" with properties "Name" and "Age".
//Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

Person[] people = new Person[3];

Console.WriteLine("Enter details for 3 people:");

// Input loop for 3 people
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"\nPerson {i + 1}:");
    Console.Write("Enter name: ");
    string name = Console.ReadLine()!;

    Console.Write("Enter age: ");
    int age = int.Parse(Console.ReadLine()!);

    people[i] = new Person(name, age);


    #endregion
}
Person oldest = FindOldestPerson(people);
Console.WriteLine($"the oldest person is {oldest.Name} and the age is {oldest.Age}");

string getRenge(Season season)
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
Person FindOldestPerson(Person[] people)
{
    Person oldest = people[0];

    for (int i = 1; i < people.Length; i++)
    {
        if (people[i].Age > oldest.Age)
        {
            oldest = people[i];
        }
    }

    return oldest;
}
    

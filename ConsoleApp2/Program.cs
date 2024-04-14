// See https://aka.ms/new-console-template for more information
Console.WriteLine("----------LINQ Task 1-----------");

int[] numbers = { 1, 2, 3, 4, 5 }; 
var evenNumbers = numbers.Where(n => n % 2 == 0 );

foreach ( var number in evenNumbers )
{
    Console.WriteLine( number );
}

Console.WriteLine("----------LINQ Task 2-----------");

List<int> grades = new List<int> { 90, 74, 85, 46, 78};
var averageGrades = grades.Average();

Console.WriteLine(averageGrades);

Console.WriteLine("----------LINQ Task 2-----------");

void GreetPerson(string name)
{ Console.WriteLine($"Hello {name}"); }

var name = "Nada";
GreetPerson(name);

//public class Greater
//{
//    public void GreetPerson(string name )
//    {
//        Console.WriteLine($"Hello {name}");
//    }
//    public void GreetPerson()
//    { Console.WriteLine("Unknown"); }
//}

Console.WriteLine("----------Function Task 2-----------");


 double CalculateVolume(double length, double width, double height)
    {
        return length * width * height;
    }
    double boxLength = 5.0;
    double boxWidth = 3.0;
    double boxHeight = 4.0;

    double volume = CalculateVolume(boxLength, boxWidth, boxHeight);

    Console.WriteLine("The volume of the box is: " + volume);


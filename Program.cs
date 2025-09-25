// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

Console.WriteLine("------------ STUDENT AVERAGE CALCULATOR ------------\n");

Console.Write("Enter your name: ");
String name = Console.ReadLine();

Console.Write("\nEnter your first grade   : ");
double grade1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter your second grade  : ");
double grade2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter your third grade   : ");
double grade3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter your fourth grade  : ");
double grade4 = Convert.ToDouble(Console.ReadLine());

double average = (grade1 + grade2 + grade3 + grade4) / 4;

Console.WriteLine("\n" + name + ", your average is " + average);


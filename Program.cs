using System;

class Program 
{
  static void Main(string[] args)
  {

    Console.WriteLine("Hello, World!");
    int age = 25;
    double salary = 5000.50;
    char grade = 'A';
    bool isStudent = true; 
    string name = "Jude";

    Console.Write($"{age} \n{salary} \n{grade} \n{isStudent} \n{name}");
    Console.ReadKey(); // Waits for a key press
  }

}

using System;

class Program 
{
  static void Main(string[] args)
  {

    // console.writeline("hello, world!");
    // int age = 25;
    // double salary = 5000.50;
    // char grade = 'a';
    // bool isstudent = true; 
    // string name = "jude";
    //
    // console.write($"{age} \n{salary} \n{grade} \n{isstudent} \n{name}");
    // Console.ReadKey(); // Waits for a key press
    // Console.Write("Enter your name: ");
    // string name = Console.ReadLine();
    //
    // Console.Write("Enter your age: ");
    // int age = Convert.ToInt32(Console.ReadLine());
    //
    // Console.WriteLine($"Hello {name}, you are {age} years old!");


    Console.Write("Enter number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int sum = num1 + num2;
    Console.WriteLine($"Sum is {sum}");

  }

}
